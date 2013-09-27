using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using AutoPoco;
using AutoPoco.DataSources;
using AutoPoco.Engine;

namespace site.Models
{
    public class Person
    {
        public Int32 Id { get; set; }
        public string Name { get; set; }
        public string FirstSurname { get; set; }
        public string SecondSurname { get; set; }
        public DateTime BornDate { get; set; }
        public DateTime Register { get; set; } 
    }

    public class RegisterDateSource : DatasourceBase<DateTime>
    {
        private readonly DateTime min;
        private readonly DateTime max;
        private readonly Random random = new Random();

        public RegisterDateSource(DateTime max)
            : this(DateTime.Now.AddYears(-10), max)
        {
        }

        public RegisterDateSource(DateTime min, DateTime max)
        {
            this.min = min;
            this.max = max;
        }

        public override DateTime Next(IGenerationSession session)
        {
            var range = new TimeSpan(max.Ticks - min.Ticks);
            var rnd = new Random();
            var randTimeSpan = new TimeSpan((long)(rnd.NextDouble() * range.Ticks));
            return min + randTimeSpan;
        }
    }


    public static class MyRepository
    {
        public static List<Person> GetPeople()
        {
            
            System.Threading.Thread.CurrentThread.CurrentCulture = new CultureInfo("es-ES");
            // Perform factory set up (once for entire test run)
            var factory = AutoPocoContainer.Configure(x =>
            {
                x.Conventions(c =>
                {
                    c.UseDefaultConventions();
                });
                x.AddFromAssemblyContainingType<Person>();
                x.Include<Person>()
                    .Setup(c => c.BornDate).Use<DateOfBirthSource>()
                    .Setup(c => c.Register).Use<RegisterDateSource>(DateTime.Now)
                    .Setup(c => c.Name).Use<FirstNameSource>()
                    .Setup(c => c.FirstSurname).Use<LastNameSource>()
                    .Setup(c => c.SecondSurname).Use<LastNameSource>()
                    .Setup(c => c.Id).Use<IntegerIdSource>();
            });


            // Generate one of these per test (factory will be a static variable most likely)
            IGenerationSession session = factory.CreateSession();

            // Get a collection of persons
            List<Person> people = (List<Person>)session.List<Person>(500).Get();
            return people;
        }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace site.Models
{
    public class Person
    {
        public Int32 Id { get; set; }
        //public string Name { get; set; }
        //public string FirstSurname { get; set; }
        //public string SecondSurname { get; set; }
        //public DateTime BornDate { get; set; }
        //public DateTime Register { get; set; } 
    }

    public static class MyRepository
    {
        //public static List<Person> GetPeople()
        //{
        //    List<Person> peoplelist = new List<Person>();
        //    peoplelist.Add(new Person()
        //        {
        //            Id = 1,
        //            Name = "Jose Manuel",
        //            FirstSurname = "La Mar",
        //            SecondSurname = "De Majo",
        //            BornDate = DateTime.Parse("20/09/1983 0:00:00"),
        //            Register = DateTime.Parse("17/11/2012 14:06:38")
        //        });
        //    peoplelist.Add(new Person()
        //        {
        //            Id = 2,
        //            Name = "Cechu",
        //            FirstSurname = "Pez",
        //            SecondSurname = "Volador",
        //            BornDate = DateTime.Parse("22/05/1982 0:00:00"),
        //            Register = DateTime.Parse("17/10/2012 14:06:38")
        //        });
        //    peoplelist.Add(new Person()
        //        {
        //            Id = 3,
        //            Name = "Miquel",
        //            FirstSurname = "Tigre",
        //            SecondSurname = "Fiero",
        //            BornDate = DateTime.Parse("21/12/1981 0:00:00"),
        //            Register = DateTime.Parse("17/02/2012 14:06:38")
        //        });
        //    peoplelist.Add(new Person()
        //        {
        //            Id = 4,
        //            Name = "Javi",
        //            FirstSurname = "Leon",
        //            SecondSurname = "Peludo",
        //            BornDate = DateTime.Parse("30/01/1977 0:00:00"),
        //            Register = DateTime.Parse("17/11/2002 14:06:38")
        //        });
        //    peoplelist.Add(new Person()
        //        {
        //            Id = 5,
        //            Name = "Roger",
        //            FirstSurname = "Jirafa",
        //            SecondSurname = "Cuellolargo",
        //            BornDate = DateTime.Parse("01/06/1975 0:00:00"),
        //            Register = DateTime.Parse("17/07/1997 14:06:38")
        //        });
        //    peoplelist.Add(new Person()
        //        {
        //            Id = 6,
        //            Name = "Juan",
        //            FirstSurname = "Avion",
        //            SecondSurname = "Pesado",
        //            BornDate = DateTime.Parse("12/05/1956 0:00:00"),
        //            Register = DateTime.Parse("17/01/1997 14:06:38")
        //        });
        //    peoplelist.Add(new Person()
        //        {
        //            Id = 7,
        //            Name = "Maria",
        //            FirstSurname = "Barco",
        //            SecondSurname = "Ligero",
        //            BornDate = DateTime.Parse("23/06/1963 0:00:00"),
        //            Register = DateTime.Parse("17/09/2008 14:06:38")
        //        });
        //    peoplelist.Add(new Person()
        //        {
        //            Id = 8,
        //            Name = "Andres",
        //            FirstSurname = "Tren",
        //            SecondSurname = "Lento",
        //            BornDate = DateTime.Parse("14/11/1988 0:00:00"),
        //            Register = DateTime.Parse("17/09/2008 14:06:38")
        //        });
        //    peoplelist.Add(new Person()
        //        {
        //            Id = 9,
        //            Name = "Jose Luis",
        //            FirstSurname = "Metro",
        //            SecondSurname = "Azul",
        //            BornDate = DateTime.Parse("12/08/1995 0:00:00"),
        //            Register = DateTime.Parse("17/11/2012 14:06:38")
        //        });
        //    peoplelist.Add(new Person()
        //        {
        //            Id = 10,
        //            Name = "Ivan",
        //            FirstSurname = "Zoo",
        //            SecondSurname = "Abandonado",
        //            BornDate = DateTime.Parse("19/05/2000 0:00:00"),
        //            Register = DateTime.Parse("17/11/2012 14:06:38")
        //        });
        //    peoplelist.Add(new Person()
        //        {
        //            Id = 11,
        //            Name = "Paco",
        //            FirstSurname = "Porras",
        //            SecondSurname = "Largas",
        //            BornDate = DateTime.Parse("20/09/1980 0:00:00"),
        //            Register = DateTime.Parse("17/11/2012 14:06:38")
        //        });
        //    peoplelist.Add(new Person()
        //        {
        //            Id = 12,
        //            Name = "Bob",
        //            FirstSurname = "Sinclair",
        //            SecondSurname = "Spectrum",
        //            BornDate = DateTime.Parse("22/05/1975 0:00:00"),
        //            Register = DateTime.Parse("17/10/2012 14:06:38")
        //        });
        //    peoplelist.Add(new Person()
        //        {
        //            Id = 13,
        //            Name = "Sasuke",
        //            FirstSurname = "Uchiha",
        //            SecondSurname = "Uzumaki",
        //            BornDate = DateTime.Parse("21/12/1974 0:00:00"),
        //            Register = DateTime.Parse("17/02/2012 14:06:38")
        //        });
        //    peoplelist.Add(new Person()
        //        {
        //            Id = 14,
        //            Name = "Escarlata",
        //            FirstSurname = "O'hara",
        //            SecondSurname = "O'Donnel",
        //            BornDate = DateTime.Parse("30/01/1973 0:00:00"),
        //            Register = DateTime.Parse("17/11/2002 14:06:38")
        //        });
        //    peoplelist.Add(new Person()
        //        {
        //            Id = 15,
        //            Name = "Minerva",
        //            FirstSurname = "Escritura",
        //            SecondSurname = "a Maquina",
        //            BornDate = DateTime.Parse("01/06/1972 0:00:00"),
        //            Register = DateTime.Parse("17/07/1997 14:06:38")
        //        });
        //    peoplelist.Add(new Person()
        //        {
        //            Id = 16,
        //            Name = "Raquel",
        //            FirstSurname = "Uhhh",
        //            SecondSurname = "Uoooo",
        //            BornDate = DateTime.Parse("12/05/1977 0:00:00"),
        //            Register = DateTime.Parse("17/01/1997 14:06:38")
        //        });
        //    peoplelist.Add(new Person()
        //        {
        //            Id = 17,
        //            Name = "Perdita",
        //            FirstSurname = "Durango",
        //            SecondSurname = "Pelimala",
        //            BornDate = DateTime.Parse("23/06/1978 0:00:00"),
        //            Register = DateTime.Parse("17/09/2008 14:06:38")
        //        });
        //    peoplelist.Add(new Person()
        //        {
        //            Id = 18,
        //            Name = "John",
        //            FirstSurname = "Doe",
        //            SecondSurname = "Fulanito",
        //            BornDate = DateTime.Parse("14/11/1976 0:00:00"),
        //            Register = DateTime.Parse("17/09/2008 14:06:38")
        //        });
        //    peoplelist.Add(new Person()
        //        {
        //            Id = 19,
        //            Name = "Charlie",
        //            FirstSurname = "Withing",
        //            SecondSurname = "Menganito",
        //            BornDate = DateTime.Parse("12/08/1975 0:00:00"),
        //            Register = DateTime.Parse("17/11/2012 14:06:38")
        //        });
        //    peoplelist.Add(new Person()
        //        {
        //            Id = 20,
        //            Name = "Henry",
        //            FirstSurname = "Mustafá",
        //            SecondSurname = "Mojame",
        //            BornDate = DateTime.Parse("19/05/2001 0:00:00"),
        //            Register = DateTime.Parse("17/11/2012 14:06:38")
        //        });
        //    return peoplelist;
        //}
    }
}
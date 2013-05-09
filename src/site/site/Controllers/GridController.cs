﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using site.Models;

namespace site.Controllers
{
    public class GridController : Controller
    {
        //
        // GET: /Grid/
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult ZeroConfig()
        {
            List<Person> peoplelist = new List<Person>();
            peoplelist.Add(new Person()
            {
                Id = 1,
                Name = "Jose Manuel",
                FirstSurname = "La Mar",
                SecondSurname = "De Majo",
                BornDate = DateTime.Parse("20/09/1983 0:00:00"),
                Register = DateTime.Parse("17/11/2012 14:06:38")
            });
            peoplelist.Add(new Person()
            {
                Id = 2,
                Name = "Cechu",
                FirstSurname = "Pez",
                SecondSurname = "Volador",
                BornDate = DateTime.Parse("22/05/1982 0:00:00"),
                Register = DateTime.Parse("17/10/2012 14:06:38")
            });

            return View(peoplelist);
        }

        
        //
        // GET: /Grid/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Grid/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Grid/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Grid/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Grid/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Grid/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Grid/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}

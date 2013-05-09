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
            List<Person> pp = new List<Person>();
            Person p = new Person();
            p.Id = 5;
            p.BornDate = DateTime.Now;
            p.Name = "Jose";
            p.FirstSurname = "Prueba";
            p.SecondSurname = "Segunda";
            p.Register = DateTime.Now;
            pp.Add(p);
            return View(pp);
            //return View(Models.MyRepository.GetPeople());
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

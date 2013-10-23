﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FutureReminders.Models;

namespace FutureReminders.Controllers
{
    public class PersonController : Controller
    {
        private PersonsContext db = new PersonsContext();

        //
        // GET: /Person/

        public ActionResult Index()
        {
            return View(db.PersonList.ToList());
        }

        //
        // GET: /Person/Details/5

        public ActionResult Details(int id = 0)
        {
            PersonModels personmodels = db.PersonList.Find(id);
            if (personmodels == null)
            {
                return HttpNotFound();
            }
            return View(personmodels);
        }

        //
        // GET: /Person/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Person/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PersonModels personmodels)
        {
            if (ModelState.IsValid)
            {
                db.PersonList.Add(personmodels);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(personmodels);
        }

        //
        // GET: /Person/Edit/5

        public ActionResult Edit(int id = 0)
        {
            PersonModels personmodels = db.PersonList.Find(id);
            if (personmodels == null)
            {
                return HttpNotFound();
            }
            return View(personmodels);
        }

        //
        // POST: /Person/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(PersonModels personmodels)
        {
            if (ModelState.IsValid)
            {
                db.Entry(personmodels).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(personmodels);
        }

        //
        // GET: /Person/Delete/5

        public ActionResult Delete(int id = 0)
        {
            PersonModels personmodels = db.PersonList.Find(id);
            if (personmodels == null)
            {
                return HttpNotFound();
            }
            return View(personmodels);
        }

        //
        // POST: /Person/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PersonModels personmodels = db.PersonList.Find(id);
            db.PersonList.Remove(personmodels);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}
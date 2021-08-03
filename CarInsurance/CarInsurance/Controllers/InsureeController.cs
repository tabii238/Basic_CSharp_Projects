using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarInsurance.Models;
using CarInsurance.ViewModels;

namespace CarInsurance.Controllers
{
    public class InsureeController : Controller
    {
        public decimal quote; // public field


        private InsuranceEntities2 db = new InsuranceEntities2();

        // GET: Insuree
        public ActionResult Index()
        {
            return View(db.Insurees.ToList());
        }

        // GET: Insuree/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        //GET: Insuree/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Insuree/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                if (DateTime.Now.Year - insuree.DateOfBirth.Year <= 18) // if insuree's age is 18 or less
                {
                    quote = 150; //base quote $50 + 100
                }
                else if (DateTime.Now.Year - insuree.DateOfBirth.Year > 18 && DateTime.Now.Year - insuree.DateOfBirth.Year < 25) // if insuree's age is over 18 and less than 25
                {
                    quote = 100; //base quote + 50
                }
                else // if insuree is over 25
                {
                    quote = 75; // base quote + 25
                }

                if (insuree.CarYear < 2000 || insuree.CarYear > 2015)
                {
                     quote += 25; // quote + 25
                }
                if (insuree.CarMake == "Porsche")
                {
                    quote += 25; // quote + 25
                    if (insuree.CarMake == "Porsche" && insuree.CarModel == "911 Carrera")
                    {
                        quote += 25; // quote + 25
                    }
                }
                if (insuree.SpeedingTickets >= 1)
                {
                    quote += 10 * insuree.SpeedingTickets; // add 10 for every speeding ticket
                }
                if (insuree.DUI == true)
                {
                    quote += quote * 25 / 100; // add 25%
                }
                if (insuree.CoverageType == true) // if full coverage 
                {
                    quote += quote * 50 / 100; // add 50%
                }
                Math.Round(quote, 2);
            }
            insuree.Quote = quote; // assigning quote variable to the property of Quote in the Insuree model
            db.Insurees.Add(insuree); //adding to db
            db.SaveChanges(); //saving additions to db
            return View("Quote", insuree);
        }

        // GET: Insuree/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                db.Entry(insuree).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(insuree);
        }

        // GET: Insuree/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Insuree insuree = db.Insurees.Find(id);
            db.Insurees.Remove(insuree);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        public ActionResult Admin()
        {
            using (InsuranceEntities2 db = new InsuranceEntities2()) //instantiating using this db object to access the database
            {
                var insurees = db.Insurees; //creating a variable which is equal to db.Insurees, which represents all the records in the db
                var insureeVms = new List<InsureeVm>(); //creating a new list of viewmodels, then mapping them from the model to the view model, and passing them to the view
                foreach (var insuree in insurees) // looping through items of viewmodel to display 
                {
                    var insureeVm = new InsureeVm();
                    insureeVm.FirstName = insuree.FirstName;
                    insureeVm.LastName = insuree.LastName;
                    insureeVm.EmailAddress = insuree.EmailAddress;
                    insureeVm.Quote = insuree.Quote;
                    insureeVms.Add(insureeVm);
                    db.SaveChanges();
                }
                return View(insureeVms);
            }
        }
    }
}

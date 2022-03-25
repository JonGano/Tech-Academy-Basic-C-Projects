using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarInsurance.Models;

namespace CarInsurance.Controllers
{
    public class InsureeController : Controller
    {
        private InsuranceEntities db = new InsuranceEntities();

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

        // GET: Insuree/Create
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
                db.Insurees.Add(insuree);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(insuree);
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

        //public void Quote()
        //{
        //    decimal quote = 50;
        //    //foreach (Insuree insuranceInquiry in db.Insurees)
        //    var insuranceQueries = db.Insurees.Where(x => x.Quote == 0).ToList();
        //    foreach (var insuranceInquiry in insuranceQueries)
        //    {
        //        //if (insuranceInquiry.DateOfBirth > (DateTime.Now.AddYears(-18))) quote += 100;

        //        if (insuranceInquiry.DateOfBirth > (DateTime.Now.AddYears(-18)) && insuranceInquiry.DateOfBirth < (DateTime.Now.AddYears(-25)))
        //        {
        //            quote += 50;
        //        }
        //        if (insuranceInquiry.DateOfBirth > (DateTime.Now.AddYears(-25)))
        //        {
        //            quote += 25;
        //        }
        //        if (insuranceInquiry.CarYear < 2000 || insuranceInquiry.CarYear > 2015) quote += 25;

        //        if (insuranceInquiry.CarMake.ToLower() == "porsche") quote += 25;

        //        if (insuranceInquiry.CarModel.ToLower() == "911 carrera") quote += 25;

        //        if (insuranceInquiry.SpeedingTickets > 0)
        //        {
        //            quote += (insuranceInquiry.SpeedingTickets * 10);
        //        }

        //        if (insuranceInquiry.DUI == true) quote += (quote / 4);

        //        if (insuranceInquiry.CoverageType == true)
        //        {
        //            quote += (quote / 2);
        //        }
        //        insuranceInquiry.Quote = quote;
        //    }

        //}
    }
}

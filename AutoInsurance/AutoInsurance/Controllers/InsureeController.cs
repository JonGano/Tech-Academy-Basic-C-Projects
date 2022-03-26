using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AutoInsurance.Models;

namespace AutoInsurance.Controllers
{
    public class InsureeController : Controller
    {
        private InsuredEntities db = new InsuredEntities();

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
        public decimal Quotes(Insuree insuree)
        {

            decimal quote = 50;
            
            
            
                if (insuree.DateOfBirth > (DateTime.Now.AddYears(-18))) quote += 100;

                if (insuree.DateOfBirth <= (DateTime.Now.AddYears(-18)) && insuree.DateOfBirth >= (DateTime.Now.AddYears(-25)))
                {
                    quote += 50;
                }
                if (insuree.DateOfBirth <= (DateTime.Now.AddYears(-26)))
                {
                    quote += 25;
                }
                if (insuree.CarYear < 2000 || insuree.CarYear > 2015) quote += 25;

                if (insuree.CarMake.ToLower() == "porsche") quote += 25;

                if (insuree.CarModel.ToLower() == "911 carrera") quote += 25;

                if (insuree.SpeedingTickets > 0)
                {
                    quote += (insuree.SpeedingTickets * 10);
                }
                //DateTime.Now.Year - insuree.DateOfBirth < 18
                if (insuree.DUI == true) quote += (quote / 4);

            if (insuree.CoverageType == true)
            {
                quote += (quote / 2);
            }

             
            
            return quote;

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
                

                try
                {
                    insuree.Quote = Quotes(insuree);
                    db.Insurees.Add(insuree);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                catch
                {
                    return RedirectToAction("Error");
                }
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

        //public ActionResult AdminInfo(string fName, string lName, string email)
        //{
        //    if (fName == "" || lName == "" || email == "")
        //    {
        //        return View("Erorr");
        //    }
        //    else
        //    {
        //        Administrator obj = new Administrator();
        //        obj.firstName = fName;
        //        obj.lastName = lName;
        //        obj.email = email;
        //        return View("Admin");
        //    }
        //}

        public ActionResult Admin()
        {
            //ViewBag.Message("Admin: ", adm.firstName, adm.lastName, adm.email);
            return View(db.Insurees.ToList());
        }
    }
}

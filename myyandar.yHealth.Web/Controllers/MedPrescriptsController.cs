using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using myyandar.yHealth.BizData;
using myyandar.yHealth.EntityFramework;

namespace myyandar.yHealth.Web.Controllers
{
    public class MedPrescriptsController : Controller
    {
        private yHealthDbContext db = new yHealthDbContext();

        // GET: MedPrescripts
        public ActionResult Index()
        {
            return View(db.MedPrescripts.ToList());
        }

        // GET: MedPrescripts/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MedPrescript medPrescript = db.MedPrescripts.Find(id);
            if (medPrescript == null)
            {
                return HttpNotFound();
            }
            return View(medPrescript);
        }

        // GET: MedPrescripts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MedPrescripts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,PrescDate,Dosage,MedicationPeriod,FurtherInstrs,MedCost,Username")] MedPrescript medPrescript)
        {
            if (ModelState.IsValid)
            {
                db.MedPrescripts.Add(medPrescript);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(medPrescript);
        }

        // GET: MedPrescripts/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MedPrescript medPrescript = db.MedPrescripts.Find(id);
            if (medPrescript == null)
            {
                return HttpNotFound();
            }
            return View(medPrescript);
        }

        // POST: MedPrescripts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,PrescDate,Dosage,MedicationPeriod,FurtherInstrs,MedCost,Username")] MedPrescript medPrescript)
        {
            if (ModelState.IsValid)
            {
                db.Entry(medPrescript).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(medPrescript);
        }

        // GET: MedPrescripts/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MedPrescript medPrescript = db.MedPrescripts.Find(id);
            if (medPrescript == null)
            {
                return HttpNotFound();
            }
            return View(medPrescript);
        }

        // POST: MedPrescripts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MedPrescript medPrescript = db.MedPrescripts.Find(id);
            db.MedPrescripts.Remove(medPrescript);
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
    }
}

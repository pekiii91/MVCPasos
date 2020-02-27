using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVCLicnaDokumentaPasos.Models;

namespace MVCLicnaDokumentaPasos.Controllers
{
    public class tblMaloletnoLicesController : Controller
    {
        private LicnaDokumentaPasosEntities db = new LicnaDokumentaPasosEntities();

        // GET: tblMaloletnoLices
        public ActionResult Index()
        {
            return View(db.tblMaloletnoLice.ToList());
        }

        // GET: tblMaloletnoLices/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblMaloletnoLouse tblMaloletnoLouse = db.tblMaloletnoLice.Find(id);
            if (tblMaloletnoLouse == null)
            {
                return HttpNotFound();
            }
            return View(tblMaloletnoLouse);
        }

        // GET: tblMaloletnoLices/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: tblMaloletnoLices/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaloletnoLiceID,UverenjeODrzavljanstvu,IzvodMaticneKnjigeRodjenih,UplaceneNaknade,SaglasnostRoditelja,Fotografija")] tblMaloletnoLouse tblMaloletnoLouse)
        {
            if (ModelState.IsValid)
            {
                db.tblMaloletnoLice.Add(tblMaloletnoLouse);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tblMaloletnoLouse);
        }

        // GET: tblMaloletnoLices/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblMaloletnoLouse tblMaloletnoLouse = db.tblMaloletnoLice.Find(id);
            if (tblMaloletnoLouse == null)
            {
                return HttpNotFound();
            }
            return View(tblMaloletnoLouse);
        }

        // POST: tblMaloletnoLices/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaloletnoLiceID,UverenjeODrzavljanstvu,IzvodMaticneKnjigeRodjenih,UplaceneNaknade,SaglasnostRoditelja,Fotografija")] tblMaloletnoLouse tblMaloletnoLouse)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tblMaloletnoLouse).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tblMaloletnoLouse);
        }

        // GET: tblMaloletnoLices/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblMaloletnoLouse tblMaloletnoLouse = db.tblMaloletnoLice.Find(id);
            if (tblMaloletnoLouse == null)
            {
                return HttpNotFound();
            }
            return View(tblMaloletnoLouse);
        }

        // POST: tblMaloletnoLices/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tblMaloletnoLouse tblMaloletnoLouse = db.tblMaloletnoLice.Find(id);
            db.tblMaloletnoLice.Remove(tblMaloletnoLouse);
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

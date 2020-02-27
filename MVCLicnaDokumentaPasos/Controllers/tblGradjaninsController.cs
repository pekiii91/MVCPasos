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
    public class tblGradjaninsController : Controller
    {
        private LicnaDokumentaPasosEntities db = new LicnaDokumentaPasosEntities();

        // GET: tblGradjanins
        public ActionResult Index()
        {
            var tblGradjanins = db.tblGradjanins.Include(t => t.tblMaloletnoLouse);
            return View(tblGradjanins.ToList());
        }

        // GET: tblGradjanins/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblGradjanin tblGradjanin = db.tblGradjanins.Find(id);
            if (tblGradjanin == null)
            {
                return HttpNotFound();
            }
            return View(tblGradjanin);
        }

        // GET: tblGradjanins/Create
        public ActionResult Create()
        {
            ViewBag.MaloletnoLice = new SelectList(db.tblMaloletnoLice, "MaloletnoLiceID", "UverenjeODrzavljanstvu");
            return View();
        }

        // POST: tblGradjanins/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "GradjaninID,Tip,Ime,Prezime,JMBG,Pol,DatumIzdavanja,DatumRodjenja,MestoRodjenja,DrzavaRodjenja,Prebivaliste,KodDrzave,MaloletnoLice")] tblGradjanin tblGradjanin)
        {
            if (ModelState.IsValid)
            {
                db.tblGradjanins.Add(tblGradjanin);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MaloletnoLice = new SelectList(db.tblMaloletnoLice, "MaloletnoLiceID", "UverenjeODrzavljanstvu", tblGradjanin.MaloletnoLice);
            return View(tblGradjanin);
        }

        // GET: tblGradjanins/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblGradjanin tblGradjanin = db.tblGradjanins.Find(id);
            if (tblGradjanin == null)
            {
                return HttpNotFound();
            }
            ViewBag.MaloletnoLice = new SelectList(db.tblMaloletnoLice, "MaloletnoLiceID", "UverenjeODrzavljanstvu", tblGradjanin.MaloletnoLice);
            return View(tblGradjanin);
        }

        // POST: tblGradjanins/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "GradjaninID,Tip,Ime,Prezime,JMBG,Pol,DatumIzdavanja,DatumRodjenja,MestoRodjenja,DrzavaRodjenja,Prebivaliste,KodDrzave,MaloletnoLice")] tblGradjanin tblGradjanin)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tblGradjanin).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MaloletnoLice = new SelectList(db.tblMaloletnoLice, "MaloletnoLiceID", "UverenjeODrzavljanstvu", tblGradjanin.MaloletnoLice);
            return View(tblGradjanin);
        }

        // GET: tblGradjanins/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblGradjanin tblGradjanin = db.tblGradjanins.Find(id);
            if (tblGradjanin == null)
            {
                return HttpNotFound();
            }
            return View(tblGradjanin);
        }

        // POST: tblGradjanins/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tblGradjanin tblGradjanin = db.tblGradjanins.Find(id);
            db.tblGradjanins.Remove(tblGradjanin);
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

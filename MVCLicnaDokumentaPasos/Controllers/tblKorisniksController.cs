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
    public class tblKorisniksController : Controller
    {
        private LicnaDokumentaPasosEntities db = new LicnaDokumentaPasosEntities();

        // GET: tblKorisniks
        public ActionResult Index()
        {
            var tblKorisniks = db.tblKorisniks.Include(t => t.tblPaso);
            return View(tblKorisniks.ToList());
        }

        // GET: tblKorisniks/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblKorisnik tblKorisnik = db.tblKorisniks.Find(id);
            if (tblKorisnik == null)
            {
                return HttpNotFound();
            }
            return View(tblKorisnik);
        }

        // GET: tblKorisniks/Create
        public ActionResult Create()
        {
            ViewBag.Pasos = new SelectList(db.tblPasos, "PasosID", "IzdajePU");
            return View();
        }

        // POST: tblKorisniks/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "KorsinikID,Email,Lozinka,Pasos")] tblKorisnik tblKorisnik)
        {
            if (ModelState.IsValid)
            {
                db.tblKorisniks.Add(tblKorisnik);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Pasos = new SelectList(db.tblPasos, "PasosID", "IzdajePU", tblKorisnik.Pasos);
            return View(tblKorisnik);
        }

        // GET: tblKorisniks/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblKorisnik tblKorisnik = db.tblKorisniks.Find(id);
            if (tblKorisnik == null)
            {
                return HttpNotFound();
            }
            ViewBag.Pasos = new SelectList(db.tblPasos, "PasosID", "IzdajePU", tblKorisnik.Pasos);
            return View(tblKorisnik);
        }

        // POST: tblKorisniks/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "KorsinikID,Email,Lozinka,Pasos")] tblKorisnik tblKorisnik)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tblKorisnik).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Pasos = new SelectList(db.tblPasos, "PasosID", "IzdajePU", tblKorisnik.Pasos);
            return View(tblKorisnik);
        }

        // GET: tblKorisniks/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblKorisnik tblKorisnik = db.tblKorisniks.Find(id);
            if (tblKorisnik == null)
            {
                return HttpNotFound();
            }
            return View(tblKorisnik);
        }

        // POST: tblKorisniks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tblKorisnik tblKorisnik = db.tblKorisniks.Find(id);
            db.tblKorisniks.Remove(tblKorisnik);
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

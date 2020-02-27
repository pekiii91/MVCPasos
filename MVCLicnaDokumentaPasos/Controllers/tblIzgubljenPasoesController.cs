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
    public class tblIzgubljenPasoesController : Controller
    {
        private LicnaDokumentaPasosEntities db = new LicnaDokumentaPasosEntities();

        // GET: tblIzgubljenPasoes
        public ActionResult Index()
        {
            return View(db.tblIzgubljenPasos.ToList());
        }

        // GET: tblIzgubljenPasoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblIzgubljenPaso tblIzgubljenPaso = db.tblIzgubljenPasos.Find(id);
            if (tblIzgubljenPaso == null)
            {
                return HttpNotFound();
            }
            return View(tblIzgubljenPaso);
        }

        // GET: tblIzgubljenPasoes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: tblIzgubljenPasoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IzgubljenPasosID,PrijavaNestanka,NevazecaIsprava,VadiNoviPasos")] tblIzgubljenPaso tblIzgubljenPaso)
        {
            if (ModelState.IsValid)
            {
                db.tblIzgubljenPasos.Add(tblIzgubljenPaso);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tblIzgubljenPaso);
        }

        // GET: tblIzgubljenPasoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblIzgubljenPaso tblIzgubljenPaso = db.tblIzgubljenPasos.Find(id);
            if (tblIzgubljenPaso == null)
            {
                return HttpNotFound();
            }
            return View(tblIzgubljenPaso);
        }

        // POST: tblIzgubljenPasoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IzgubljenPasosID,PrijavaNestanka,NevazecaIsprava,VadiNoviPasos")] tblIzgubljenPaso tblIzgubljenPaso)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tblIzgubljenPaso).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tblIzgubljenPaso);
        }

        // GET: tblIzgubljenPasoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblIzgubljenPaso tblIzgubljenPaso = db.tblIzgubljenPasos.Find(id);
            if (tblIzgubljenPaso == null)
            {
                return HttpNotFound();
            }
            return View(tblIzgubljenPaso);
        }

        // POST: tblIzgubljenPasoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tblIzgubljenPaso tblIzgubljenPaso = db.tblIzgubljenPasos.Find(id);
            db.tblIzgubljenPasos.Remove(tblIzgubljenPaso);
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

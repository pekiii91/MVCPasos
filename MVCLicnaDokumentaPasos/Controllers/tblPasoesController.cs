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
    public class tblPasoesController : Controller
    {
        private LicnaDokumentaPasosEntities db = new LicnaDokumentaPasosEntities();

        // GET: tblPasoes
        public ActionResult Index()
        {
            var tblPasos = db.tblPasos.Include(t => t.tblGradjanin).Include(t => t.tblInformacijeOPasosu).Include(t => t.tblIzgubljenPaso).Include(t => t.tblMaloletnoLouse).Include(t => t.tblUplata);
            return View(tblPasos.ToList());
        }

        // GET: tblPasoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblPaso tblPaso = db.tblPasos.Find(id);
            if (tblPaso == null)
            {
                return HttpNotFound();
            }
            return View(tblPaso);
        }

        // GET: tblPasoes/Create
        public ActionResult Create()
        {
            ViewBag.Gradjanin = new SelectList(db.tblGradjanins, "GradjaninID", "Tip");
            ViewBag.InformacijeOPasosu = new SelectList(db.tblInformacijeOPasosus, "InformacijeOPasosuID", "Email");
            ViewBag.IzgubljenPasos = new SelectList(db.tblIzgubljenPasos, "IzgubljenPasosID", "PrijavaNestanka");
            ViewBag.MaloletnoLice = new SelectList(db.tblMaloletnoLice, "MaloletnoLiceID", "UverenjeODrzavljanstvu");
            ViewBag.Uplata = new SelectList(db.tblUplatas, "UplataID", "ObrzacPutneIsprave");
            return View();
        }

        // POST: tblPasoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PasosID,IzdajePU,Drzava,Telefon,Email,InformacijeOPasosu,Uplata,Gradjanin,MaloletnoLice,IzgubljenPasos")] tblPaso tblPaso)
        {
            if (ModelState.IsValid)
            {
                db.tblPasos.Add(tblPaso);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Gradjanin = new SelectList(db.tblGradjanins, "GradjaninID", "Tip", tblPaso.Gradjanin);
            ViewBag.InformacijeOPasosu = new SelectList(db.tblInformacijeOPasosus, "InformacijeOPasosuID", "Email", tblPaso.InformacijeOPasosu);
            ViewBag.IzgubljenPasos = new SelectList(db.tblIzgubljenPasos, "IzgubljenPasosID", "PrijavaNestanka", tblPaso.IzgubljenPasos);
            ViewBag.MaloletnoLice = new SelectList(db.tblMaloletnoLice, "MaloletnoLiceID", "UverenjeODrzavljanstvu", tblPaso.MaloletnoLice);
            ViewBag.Uplata = new SelectList(db.tblUplatas, "UplataID", "ObrzacPutneIsprave", tblPaso.Uplata);
            return View(tblPaso);
        }

        // GET: tblPasoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblPaso tblPaso = db.tblPasos.Find(id);
            if (tblPaso == null)
            {
                return HttpNotFound();
            }
            ViewBag.Gradjanin = new SelectList(db.tblGradjanins, "GradjaninID", "Tip", tblPaso.Gradjanin);
            ViewBag.InformacijeOPasosu = new SelectList(db.tblInformacijeOPasosus, "InformacijeOPasosuID", "Email", tblPaso.InformacijeOPasosu);
            ViewBag.IzgubljenPasos = new SelectList(db.tblIzgubljenPasos, "IzgubljenPasosID", "PrijavaNestanka", tblPaso.IzgubljenPasos);
            ViewBag.MaloletnoLice = new SelectList(db.tblMaloletnoLice, "MaloletnoLiceID", "UverenjeODrzavljanstvu", tblPaso.MaloletnoLice);
            ViewBag.Uplata = new SelectList(db.tblUplatas, "UplataID", "ObrzacPutneIsprave", tblPaso.Uplata);
            return View(tblPaso);
        }

        // POST: tblPasoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PasosID,IzdajePU,Drzava,Telefon,Email,InformacijeOPasosu,Uplata,Gradjanin,MaloletnoLice,IzgubljenPasos")] tblPaso tblPaso)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tblPaso).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Gradjanin = new SelectList(db.tblGradjanins, "GradjaninID", "Tip", tblPaso.Gradjanin);
            ViewBag.InformacijeOPasosu = new SelectList(db.tblInformacijeOPasosus, "InformacijeOPasosuID", "Email", tblPaso.InformacijeOPasosu);
            ViewBag.IzgubljenPasos = new SelectList(db.tblIzgubljenPasos, "IzgubljenPasosID", "PrijavaNestanka", tblPaso.IzgubljenPasos);
            ViewBag.MaloletnoLice = new SelectList(db.tblMaloletnoLice, "MaloletnoLiceID", "UverenjeODrzavljanstvu", tblPaso.MaloletnoLice);
            ViewBag.Uplata = new SelectList(db.tblUplatas, "UplataID", "ObrzacPutneIsprave", tblPaso.Uplata);
            return View(tblPaso);
        }

        // GET: tblPasoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblPaso tblPaso = db.tblPasos.Find(id);
            if (tblPaso == null)
            {
                return HttpNotFound();
            }
            return View(tblPaso);
        }

        // POST: tblPasoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tblPaso tblPaso = db.tblPasos.Find(id);
            db.tblPasos.Remove(tblPaso);
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

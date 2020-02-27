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
    public class tblInformacijeOPasosusController : Controller
    {
        private LicnaDokumentaPasosEntities db = new LicnaDokumentaPasosEntities();

        // GET: tblInformacijeOPasosus
        public ActionResult Index()
        {
            var tblInformacijeOPasosus = db.tblInformacijeOPasosus.Include(t => t.tblIzdavanjePasosa).Include(t => t.tblProduzetakPasosa);
            return View(tblInformacijeOPasosus.ToList());
        }

        // GET: tblInformacijeOPasosus/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblInformacijeOPasosu tblInformacijeOPasosu = db.tblInformacijeOPasosus.Find(id);
            if (tblInformacijeOPasosu == null)
            {
                return HttpNotFound();
            }
            return View(tblInformacijeOPasosu);
        }

        // GET: tblInformacijeOPasosus/Create
        public ActionResult Create()
        {
            ViewBag.IzdavanjePasosa = new SelectList(db.tblIzdavanjePasosas, "IzdavanjePasosaID", "LicnaKarta");
            ViewBag.ProduzetakPasosa = new SelectList(db.tblProduzetakPasosas, "ProduzetekPasosaID", "LicnaKarta");
            return View();
        }

        // POST: tblInformacijeOPasosus/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "InformacijeOPasosuID,Email,Telefon,IzdavanjePasosa,ProduzetakPasosa")] tblInformacijeOPasosu tblInformacijeOPasosu)
        {
            if (ModelState.IsValid)
            {
                db.tblInformacijeOPasosus.Add(tblInformacijeOPasosu);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IzdavanjePasosa = new SelectList(db.tblIzdavanjePasosas, "IzdavanjePasosaID", "LicnaKarta", tblInformacijeOPasosu.IzdavanjePasosa);
            ViewBag.ProduzetakPasosa = new SelectList(db.tblProduzetakPasosas, "ProduzetekPasosaID", "LicnaKarta", tblInformacijeOPasosu.ProduzetakPasosa);
            return View(tblInformacijeOPasosu);
        }

        // GET: tblInformacijeOPasosus/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblInformacijeOPasosu tblInformacijeOPasosu = db.tblInformacijeOPasosus.Find(id);
            if (tblInformacijeOPasosu == null)
            {
                return HttpNotFound();
            }
            ViewBag.IzdavanjePasosa = new SelectList(db.tblIzdavanjePasosas, "IzdavanjePasosaID", "LicnaKarta", tblInformacijeOPasosu.IzdavanjePasosa);
            ViewBag.ProduzetakPasosa = new SelectList(db.tblProduzetakPasosas, "ProduzetekPasosaID", "LicnaKarta", tblInformacijeOPasosu.ProduzetakPasosa);
            return View(tblInformacijeOPasosu);
        }

        // POST: tblInformacijeOPasosus/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "InformacijeOPasosuID,Email,Telefon,IzdavanjePasosa,ProduzetakPasosa")] tblInformacijeOPasosu tblInformacijeOPasosu)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tblInformacijeOPasosu).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IzdavanjePasosa = new SelectList(db.tblIzdavanjePasosas, "IzdavanjePasosaID", "LicnaKarta", tblInformacijeOPasosu.IzdavanjePasosa);
            ViewBag.ProduzetakPasosa = new SelectList(db.tblProduzetakPasosas, "ProduzetekPasosaID", "LicnaKarta", tblInformacijeOPasosu.ProduzetakPasosa);
            return View(tblInformacijeOPasosu);
        }

        // GET: tblInformacijeOPasosus/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblInformacijeOPasosu tblInformacijeOPasosu = db.tblInformacijeOPasosus.Find(id);
            if (tblInformacijeOPasosu == null)
            {
                return HttpNotFound();
            }
            return View(tblInformacijeOPasosu);
        }

        // POST: tblInformacijeOPasosus/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tblInformacijeOPasosu tblInformacijeOPasosu = db.tblInformacijeOPasosus.Find(id);
            db.tblInformacijeOPasosus.Remove(tblInformacijeOPasosu);
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

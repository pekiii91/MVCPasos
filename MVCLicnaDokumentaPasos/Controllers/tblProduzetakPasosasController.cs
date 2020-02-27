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
    public class tblProduzetakPasosasController : Controller
    {
        private LicnaDokumentaPasosEntities db = new LicnaDokumentaPasosEntities();

        // GET: tblProduzetakPasosas
        public ActionResult Index()
        {
            return View(db.tblProduzetakPasosas.ToList());
        }

        // GET: tblProduzetakPasosas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblProduzetakPasosa tblProduzetakPasosa = db.tblProduzetakPasosas.Find(id);
            if (tblProduzetakPasosa == null)
            {
                return HttpNotFound();
            }
            return View(tblProduzetakPasosa);
        }

        // GET: tblProduzetakPasosas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: tblProduzetakPasosas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ProduzetekPasosaID,LicnaKarta,StariPasos,TroskoviUplate")] tblProduzetakPasosa tblProduzetakPasosa)
        {
            if (ModelState.IsValid)
            {
                db.tblProduzetakPasosas.Add(tblProduzetakPasosa);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tblProduzetakPasosa);
        }

        // GET: tblProduzetakPasosas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblProduzetakPasosa tblProduzetakPasosa = db.tblProduzetakPasosas.Find(id);
            if (tblProduzetakPasosa == null)
            {
                return HttpNotFound();
            }
            return View(tblProduzetakPasosa);
        }

        // POST: tblProduzetakPasosas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ProduzetekPasosaID,LicnaKarta,StariPasos,TroskoviUplate")] tblProduzetakPasosa tblProduzetakPasosa)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tblProduzetakPasosa).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tblProduzetakPasosa);
        }

        // GET: tblProduzetakPasosas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblProduzetakPasosa tblProduzetakPasosa = db.tblProduzetakPasosas.Find(id);
            if (tblProduzetakPasosa == null)
            {
                return HttpNotFound();
            }
            return View(tblProduzetakPasosa);
        }

        // POST: tblProduzetakPasosas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tblProduzetakPasosa tblProduzetakPasosa = db.tblProduzetakPasosas.Find(id);
            db.tblProduzetakPasosas.Remove(tblProduzetakPasosa);
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

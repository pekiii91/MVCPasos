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
    public class tblIzdavanjePasosasController : Controller
    {
        private LicnaDokumentaPasosEntities db = new LicnaDokumentaPasosEntities();

        // GET: tblIzdavanjePasosas
        public ActionResult Index()
        {
            return View(db.tblIzdavanjePasosas.ToList());
        }

        // GET: tblIzdavanjePasosas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblIzdavanjePasosa tblIzdavanjePasosa = db.tblIzdavanjePasosas.Find(id);
            if (tblIzdavanjePasosa == null)
            {
                return HttpNotFound();
            }
            return View(tblIzdavanjePasosa);
        }

        // GET: tblIzdavanjePasosas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: tblIzdavanjePasosas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IzdavanjePasosaID,LicnaKarta,Fotografija,IzvodMaticneKnjigeRodjenih,UverenjeODrzavljanstvu,UplataZaPasos")] tblIzdavanjePasosa tblIzdavanjePasosa)
        {
            if (ModelState.IsValid)
            {
                db.tblIzdavanjePasosas.Add(tblIzdavanjePasosa);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tblIzdavanjePasosa);
        }

        // GET: tblIzdavanjePasosas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblIzdavanjePasosa tblIzdavanjePasosa = db.tblIzdavanjePasosas.Find(id);
            if (tblIzdavanjePasosa == null)
            {
                return HttpNotFound();
            }
            return View(tblIzdavanjePasosa);
        }

        // POST: tblIzdavanjePasosas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IzdavanjePasosaID,LicnaKarta,Fotografija,IzvodMaticneKnjigeRodjenih,UverenjeODrzavljanstvu,UplataZaPasos")] tblIzdavanjePasosa tblIzdavanjePasosa)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tblIzdavanjePasosa).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tblIzdavanjePasosa);
        }

        // GET: tblIzdavanjePasosas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblIzdavanjePasosa tblIzdavanjePasosa = db.tblIzdavanjePasosas.Find(id);
            if (tblIzdavanjePasosa == null)
            {
                return HttpNotFound();
            }
            return View(tblIzdavanjePasosa);
        }

        // POST: tblIzdavanjePasosas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tblIzdavanjePasosa tblIzdavanjePasosa = db.tblIzdavanjePasosas.Find(id);
            db.tblIzdavanjePasosas.Remove(tblIzdavanjePasosa);
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

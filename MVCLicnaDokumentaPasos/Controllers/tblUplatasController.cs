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
    public class tblUplatasController : Controller
    {
        private LicnaDokumentaPasosEntities db = new LicnaDokumentaPasosEntities();

        // GET: tblUplatas
        public ActionResult Index()
        {
            return View(db.tblUplatas.ToList());
        }

        // GET: tblUplatas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblUplata tblUplata = db.tblUplatas.Find(id);
            if (tblUplata == null)
            {
                return HttpNotFound();
            }
            return View(tblUplata);
        }

        // GET: tblUplatas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: tblUplatas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "UplataID,ObrzacPutneIsprave,AdministrativnaTaksa")] tblUplata tblUplata)
        {
            if (ModelState.IsValid)
            {
                db.tblUplatas.Add(tblUplata);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tblUplata);
        }

        // GET: tblUplatas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblUplata tblUplata = db.tblUplatas.Find(id);
            if (tblUplata == null)
            {
                return HttpNotFound();
            }
            return View(tblUplata);
        }

        // POST: tblUplatas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "UplataID,ObrzacPutneIsprave,AdministrativnaTaksa")] tblUplata tblUplata)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tblUplata).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tblUplata);
        }

        // GET: tblUplatas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblUplata tblUplata = db.tblUplatas.Find(id);
            if (tblUplata == null)
            {
                return HttpNotFound();
            }
            return View(tblUplata);
        }

        // POST: tblUplatas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tblUplata tblUplata = db.tblUplatas.Find(id);
            db.tblUplatas.Remove(tblUplata);
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

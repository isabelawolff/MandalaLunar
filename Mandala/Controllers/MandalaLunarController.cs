using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Mandala.Dados;
using Mandala.Models;

namespace Mandala.Controllers
{
    public class MandalaLunarController : Controller
    {
        private MandalaContext db = new MandalaContext();

        // GET: MandalaLunar
        public ActionResult Index()
        {
            return View(db.Mandalas.ToList());
        }

        // GET: MandalaLunar/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MandalaLunar mandalaLunar = db.Mandalas.Find(id);
            if (mandalaLunar == null)
            {
                return HttpNotFound();
            }
            return View(mandalaLunar);
        }

        // GET: MandalaLunar/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MandalaLunar/Create
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdMandalaLunar")] MandalaLunar mandalaLunar)
        {
            if (ModelState.IsValid)
            {
                db.Mandalas.Add(mandalaLunar);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(mandalaLunar);
        }

        // GET: MandalaLunar/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MandalaLunar mandalaLunar = db.Mandalas.Find(id);
            if (mandalaLunar == null)
            {
                return HttpNotFound();
            }
            return View(mandalaLunar);
        }

        // POST: MandalaLunar/Edit/5
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdMandalaLunar")] MandalaLunar mandalaLunar)
        {
            if (ModelState.IsValid)
            {
                db.Entry(mandalaLunar).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(mandalaLunar);
        }

        // GET: MandalaLunar/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MandalaLunar mandalaLunar = db.Mandalas.Find(id);
            if (mandalaLunar == null)
            {
                return HttpNotFound();
            }
            return View(mandalaLunar);
        }

        // POST: MandalaLunar/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MandalaLunar mandalaLunar = db.Mandalas.Find(id);
            db.Mandalas.Remove(mandalaLunar);
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

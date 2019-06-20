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
    public class ParametroController : Controller
    {
        private MandalaContext db = new MandalaContext();

        // GET: Parametro
        public ActionResult Index()
        {
            return View(db.Parametros.ToList());
        }

        // GET: Parametro/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Parametro parametro = db.Parametros.Find(id);
            if (parametro == null)
            {
                return HttpNotFound();
            }
            return View(parametro);
        }

        // GET: Parametro/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Parametro/Create
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdParametro,NomeParametro")] Parametro parametro)
        {
            if (ModelState.IsValid)
            {
                db.Parametros.Add(parametro);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(parametro);
        }

        // GET: Parametro/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Parametro parametro = db.Parametros.Find(id);
            if (parametro == null)
            {
                return HttpNotFound();
            }
            return View(parametro);
        }

        // POST: Parametro/Edit/5
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdParametro,NomeParametro")] Parametro parametro)
        {
            if (ModelState.IsValid)
            {
                db.Entry(parametro).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(parametro);
        }

        // GET: Parametro/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Parametro parametro = db.Parametros.Find(id);
            if (parametro == null)
            {
                return HttpNotFound();
            }
            return View(parametro);
        }

        // POST: Parametro/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Parametro parametro = db.Parametros.Find(id);
            db.Parametros.Remove(parametro);
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

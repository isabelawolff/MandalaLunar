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
        private ParametroRepository db = new ParametroRepository();

        // GET: Parametro
        public ActionResult Index()
        {
            //var im = new DiaMandala()
            //{
            //    Data = DateTime.Today,
            //    Amorosidade = 7,
            //    AutoconfiancaPessoal = 8,
            //    AutoconfiancaProfissional = 9,
            //    EnergiaSexual = 10,
            //    Extroversao = 6,
            //    Foco = 5,
            //    ForcaDeAcao = 4,
            //    Vitalidade = 3

            //};

            //im.GerarId();

            //db.CreateParametro(im);

            return View(db.ReadParametros());
        }

        // GET: Parametro/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DiaMandala parametro = db.ReadParametro(id);
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
        public ActionResult Create(DiaMandala parametro)
        {
            List<string> errosValidacao = new List<string>();

            if (ModelState.IsValid && parametro.Validar(out errosValidacao))
            {
                parametro.GerarId();
                db.CreateParametro(parametro);
                
                return RedirectToAction("Index");
            }

            if (errosValidacao.Any())
            {
                foreach (var ev in errosValidacao)
                {
                    ModelState.AddModelError("Geral", ev);
                }
            }

            return View(parametro);
        }

        // GET: Parametro/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DiaMandala parametro = db.ReadParametro(id);
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
        public ActionResult Edit(DiaMandala parametro)
        {
            List<string> errosValidacao = new List<string>();

            if (ModelState.IsValid && parametro.Validar(out errosValidacao))
            {
                db.UpdateParametro(parametro);
                return RedirectToAction("Index");
            }
            
            if (errosValidacao.Any())
            {
                foreach (var ev in errosValidacao)
                {
                    ModelState.AddModelError("Geral", ev);
                }
            }

            return View(parametro);
        }

        // GET: Parametro/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DiaMandala parametro = db.ReadParametro(id);
            if (parametro == null)
            {
                return HttpNotFound();
            }
            return View(parametro);
        }

        // POST: Parametro/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            db.DeleteParametro(id);
            return RedirectToAction("Index");
        }

        
    }
}

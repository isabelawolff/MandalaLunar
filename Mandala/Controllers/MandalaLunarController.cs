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
        private ParametroRepository db = new ParametroRepository();

        public ActionResult GerarMandala(string Id)
        {

            var dias = db.ReadParametrosDoMes(Id);
            MandalaLunar ml = new MandalaLunar(Id, dias);

            return View("Index", ml);
        }


    }
}

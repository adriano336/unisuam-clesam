using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TCC_ACE.Controllers
{
    public class PacienteController : Controller
    {
        //
        // GET: /Paciente/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Incluir() {

            return View();
        }
	}
}
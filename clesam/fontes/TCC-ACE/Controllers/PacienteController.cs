using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TCC_ACE.Models;
using TCC_ACE.Persistence;

namespace TCC_ACE.Controllers
{
    public class PacienteController : Controller
    {
        //
        // GET: /Paciente/
        public ActionResult Index(ModelPaciente paciente, FormCollection form)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (var context = new ContextEntities())
                    {
                        new PacienteDb(context).SalvarPaciente(paciente);
                    }
                    
                   
                }
            }
            catch (Exception e)
            {
                
            }

            return View();
        }
	}
}
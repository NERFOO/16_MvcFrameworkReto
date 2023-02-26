using _16_MvcFrameworkReto.Models;
using _16_MvcFrameworkReto.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _16_MvcFrameworkReto.Controllers
{
    public class EmpleadosController : Controller
    {
        private IRepositoryEmpleado irepo;

        public EmpleadosController(IRepositoryEmpleado irepo)
        {
            this.irepo = irepo;
        }

        // GET: Empleados
        public ActionResult Index()
        {
            return View(this.irepo.GetEmpleados());
        }
    }
}
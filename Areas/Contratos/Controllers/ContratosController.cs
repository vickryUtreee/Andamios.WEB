using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ProyectoAndamios.Areas.Contratos.Controllers
{
    [Area("Contratos")]

    public class ContratosController : Microsoft.AspNetCore.Mvc.Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        // GET: Contratos/Details/5
        public ActionResult Ver(int id)
        {
            return View();
        }

        // GET: Contratos/Create
        public ActionResult Create()
        {
            return View();
        }




        // GET: Contratos/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }



        // GET: Contratos/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        //GET Contratos/CambiarEstado
        public ActionResult CambiarEstado(bool id)
        {
            return View();
        }
    }
}
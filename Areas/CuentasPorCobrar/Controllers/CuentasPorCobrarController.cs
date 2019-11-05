using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ProyectoAndamios.Areas.CuentasPorCobrar.Controllers
{
    [Area("CuentasPorCobrar")]

    public class CuentasPorCobrarController : Microsoft.AspNetCore.Mvc.Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        // GET: CuentasPorCobrar/Details/5
        public ActionResult Ver(int id)
        {
            return View();
        }

        // GET: CuentasPorCobrar/Create
        public ActionResult Create()
        {
            return View();
        }



        // GET: CuentasPorCobrar/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }



        // GET: CuentasPorCobrar/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        //GET: CuentasPorCobrar/Estado
        public ActionResult CambiarEstado(bool id)
        {
            return View();
        }

    }
}
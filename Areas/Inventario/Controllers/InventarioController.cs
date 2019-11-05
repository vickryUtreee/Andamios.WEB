using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ProyectoAndamios.Areas.Inventario.Controllers
{
    public class InventarioController : Microsoft.AspNetCore.Mvc.Controller
    {
        [Area("Inventario")]

        public IActionResult Index()
        {
            return View();
        }
        // GET: Inventario/Details/5
        public ActionResult Ver(int id)
        {
            return View();
        }

        // GET: Inventario/Create
        public ActionResult Create()
        {
            return View();
        }


        // GET: Inventario/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }



        // GET: Inventario/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }
        //GET: inventario/CambiarEstado
        public ActionResult CambiarEstado(bool id)
        {
            return View();
        }
    }
}
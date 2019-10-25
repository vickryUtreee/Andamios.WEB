using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ProyectoAndamios.Controllers
{
    public class ReportesController : Microsoft.AspNetCore.Mvc.Controller
    {
        // GET: Reportes
        public ActionResult Index()
        {
            return View();
        }

        // GET: Reportes/Details/5
        public ActionResult Ver(int id)
        {
            return View();
        }

        // GET: Reportes/Create
        public ActionResult Create()
        {
            return View();
        }

      

        // GET: Reportes/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

      

        // GET: Reportes/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        //GET: Reportes/CambiarEstado
        public ActionResult CambiarEstado(bool id)
        {
            return View();
        }
       
    }
}
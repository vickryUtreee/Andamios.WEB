using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ProyectoAndamios.Controllers
{
    public class SeguridadController : Microsoft.AspNetCore.Mvc.Controller
    {
        // GET: Seguridad
        public ActionResult Index()
        {
            return View();
        }

        // GET: Seguridad/Details/5
        public ActionResult Ver(int id)
        {
            return View();
        }

        // GET: Seguridad/Create
        public ActionResult Create()
        {
            return View();
        }

       

        // GET: Seguridad/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        

        // GET: Seguridad/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        //GET: Seguridad/CambiarEstado
        public ActionResult CambiarEstado(bool id)
        {
            return View();
        }
       
    }
}
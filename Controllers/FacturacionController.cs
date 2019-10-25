using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ProyectoAndamios.Controllers
{
    public class FacturacionController : Microsoft.AspNetCore.Mvc.Controller
    {
        // GET: Facturacion
        public ActionResult Index()
        {
            return View();
        }

        // GET: Facturacion/Details/5
        public ActionResult Ver(int id)
        {
            return View();
        }

        // GET: Facturacion/Create
        public ActionResult Create()
        {
            return View();
        }

       
       

        // GET: Facturacion/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        

        // GET: Facturacion/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        //GET: Facturacion/CambiarEstado
        public ActionResult CambiarEstado(bool id)
        {
            return View();
        }


    }
}
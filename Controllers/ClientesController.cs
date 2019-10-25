using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ProyectoAndamios.Controllers
{
    public class ClientesController : Microsoft.AspNetCore.Mvc.Controller
    {
        // GET: Clientes
        public ActionResult Index()
        {
            return View();
        }

        // GET: Clientes/Details/5
        public ActionResult Ver(int id)
        {
            return View();
        }

        // GET: Clientes/Create
        public ActionResult Create()
        {
            return View();
        }


        // GET: Clientes/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

 

        // GET: Clientes/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        //Get: Cliente/CambiarEstado
        public ActionResult CambiarEstado(bool id)
        {
            return View();
        }

 
    }
}
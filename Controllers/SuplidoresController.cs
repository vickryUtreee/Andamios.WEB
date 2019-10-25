using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ProyectoAndamios.Controllers
{
    public class SuplidoresController : Microsoft.AspNetCore.Mvc.Controller
    {
        // GET: Suplidores
        public ActionResult Index()
        {
            return View();
        }

        // GET: Suplidores/Details/5
        public ActionResult Ver(int id)
        {
            return View();
        }

        // GET: Suplidores/Create
        public ActionResult Create()
        {
            return View();
        }

       

        // GET: Suplidores/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        

        // GET: Suplidores/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        //GET: Suplidores/CambiarEstado
        public ActionResult CambiarEstado(bool id)
        {
            return View();
        }


    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProyectoAndamios.Helpers;
using ProyectoAndamios.Models;

namespace ProyectoAndamios.Areas.Usuarios.Controllers
{
    [Area("Usuarios")]

    public class UsuariosController : Microsoft.AspNetCore.Mvc.Controller
    {
        public class UsuarioController : Microsoft.AspNetCore.Mvc.Controller
        {


            public ActionResult Login(string titulo = "", string texto = "", string tipo = "")
            {
                ViewBag.mensaje = new MensajesViewModel(titulo, texto, tipo);

                return View();
            }

            public ActionResult Register(string titulo = "", string texto = "", string tipo = "")
            {
                ViewBag.mensaje = new MensajesViewModel(titulo, texto, tipo);

                var model = TempData.Get<RegisterViewModel>("model");

                if (model != null)
                {
                    return View(model);
                }

                return View(new RegisterViewModel());
            }
        }
    }
}
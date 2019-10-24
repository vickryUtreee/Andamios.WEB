
using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProyectoAndamios.Helpers;
using ProyectoAndamios.Models;

namespace ProyectoAndamios.Controller
{
    public class UsuarioServiceController : Microsoft.AspNetCore.Mvc.Controller
    {
        private string baseUrl = "https://localhost:5001";

        [HttpPost]
        public async Task<ActionResult> Register(RegisterViewModel model)
        {
            var client = CallClient(model);

            if (ModelState.IsValid)
            {
                try
                {
                    HttpResponseMessage response = await client.PostAsJsonAsync("/api/Usuario/Register", model);



                    if (response.IsSuccessStatusCode == true)
                    {

                        return RedirectToAction("Login", "Usuario", new { texto = "Usuario creado satisfactoriamente", titulo = "Usuario Creado", tipo = "success" });
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine(e);

                    TempData.Put("model", model);

                    if (e.InnerException != null)
                    {
                        return RedirectToAction("Register", "Usuario", new { titulo = "Hubo un error", tipo = "error", texto = e.Message + ", " + e.InnerException.Message });

                    }

                    return RedirectToAction("Register", "Usuario", new { titulo = "Hubo un error", tipo = "error", texto = e.Message });

                }
            }
            

            return RedirectToAction("Register", "Usuario", new { tipo = "error", texto = "Ocurrió un error inesperado, vuelva a intentarlo" });

        }

        [HttpPost]
        public async Task<ActionResult> Login(LoginModel model)
        {

            var client = CallClient(model);

            HttpResponseMessage response = await client.PostAsJsonAsync("/api/Usuario/Login", model);

            if (response.IsSuccessStatusCode == true)
            {
                return RedirectToAction("home", "Home");
            }

            TempData.Put("model", model);
            string texto = "";
            if (response.StatusCode == HttpStatusCode.BadRequest)
            {
                texto = "No se pudo encontrar el usuario, verifique que lo haya escrito correctamente";
            }

            return RedirectToAction("Login", "Usuario", new{ tipo = "error", texto = texto, titulo = "Nombre de usuario incorrecto" });
        }

        #region Private Methods

        private HttpClient CallClient(object model)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(baseUrl);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Accept.Clear();

            return client;
        }


        #endregion

    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoAndamios.Areas.Seguridad.Models
{
    public class SeguridadModel
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Imagen { get; set; }
        public string Role { get; set; }
        public bool Estado { get; set; }

        public string RefreshToken { get; set; }
    }
}

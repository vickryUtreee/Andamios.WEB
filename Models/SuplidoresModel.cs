﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoAndamios.Models
{
    public class SuplidoresModel
    {
        
        public string SuplidorDescripcion { get; set; }
        public string SuplidorPais { get; set; }
        public string SuplidorDireccion { get; set; }
        public string SuplidorTelOficina1 { get; set; }
        public string SuplidorTelOficina2 { get; set; }
        public string SuplidorTelFax1 { get; set; }
        public string SuplidorCorreoElec { get; set; }
        public string SuplidorUsuRegistro { get; set; }
        public DateTime? SuplidorFechaCreacion { get; set; }
        public DateTime? SuplidorFechaModifica { get; set; }
        public string SuplidorContacto { get; set; }
        public string SuplidorContactoTelCel { get; set; }
        public string SuplidorEstatus { get; set; }
    }
}

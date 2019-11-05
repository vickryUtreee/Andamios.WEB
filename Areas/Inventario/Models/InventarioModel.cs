﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoAndamios.Areas.Inventario.Models
{
    public class InventarioModel
    {
        public string MinvDescripcion { get; set; }
        public short? MinvClase { get; set; }
        public string MinvUnidad { get; set; }
        public string MinvPeso { get; set; }
        public int? MinvTotalIngresado { get; set; }
        public int? MinvTotalRentado { get; set; }
        public int? MinvTotalOrdenado { get; set; }
        public decimal? MinvPrecioVenta { get; set; }
        public decimal? MinvPrecioRentaFija { get; set; }
        public decimal? MinvPrecioRentaDia { get; set; }
        public decimal? MinvCostoAdquisicion { get; set; }
        public string MinvPiezaServicio { get; set; }
        public DateTime? MinvFechaCreacion { get; set; }
        public string MinvUsuarioCreacion { get; set; }
        public string MinvUsuarioModifica { get; set; }
        public DateTime? MinvFechaModifica { get; set; }
        public string MinvEstatus { get; set; }
    }
}

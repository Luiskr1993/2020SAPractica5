using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServicioRestaurante.ApiRestaurante.Models
{
    public class Pedido
    {
        public int estado { get; set; }
        public string detalle { get; set; }
    }
}
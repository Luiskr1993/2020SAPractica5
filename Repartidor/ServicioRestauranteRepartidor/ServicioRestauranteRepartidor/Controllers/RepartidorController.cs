using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ServicioRestauranteRepartidor.Controllers
{
    public class RepartidorController : ApiController
    {
        public string Get()
        {
            string respuesta = "";

            return respuesta;
        }

        public string Put(int id, [FromBody]string value)
        {
            string resultado = "";
            if (id == 1)
            {
                resultado = "Pedido asignado a Repartidor";
            }
            else {
                resultado = "Repartidor no disponible";
            }
            return resultado;

        }
    }
}

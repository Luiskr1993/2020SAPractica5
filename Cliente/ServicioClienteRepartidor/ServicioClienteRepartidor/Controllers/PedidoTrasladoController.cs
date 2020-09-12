using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ServicioClienteRepartidor.Controllers
{
    public class PedidoTrasladoController : ApiController
    {

        public string Get(int id)
        {
            string respuesta = "";
            if (id == 0)
            {
                respuesta = "Repartidor recogiendo el pedido";
            }
            else if (id == 1)
            {
                respuesta = "Pedido recogido en restaurante";
            }
            else if (id == 2)
            {
                respuesta = "Pedido en camino";
            }
            else if (id == 3) {
                respuesta = "Repartidor entregando el pedido";
            }
            return respuesta;
        }

        public string Put(int id, [FromBody]string value)
        {
            string resultado = "";
            if (id == 1)
            {
                resultado = "Pedido entregado al cliente exitosamente";
            }
            else
            {
                resultado = "Pedido pendiente de entregar";
            }
            return resultado;

        }
    }
}

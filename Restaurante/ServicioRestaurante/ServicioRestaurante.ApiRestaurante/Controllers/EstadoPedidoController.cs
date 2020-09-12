using ServicioRestaurante.ApiRestaurante.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ServicioRestaurante.ApiRestaurante.Controllers
{
    public class EstadoPedidoController : ApiController
    {

            public int estadoPedido;
            public List<Pedido> listaPedidos;

        public EstadoPedidoController() {
            this.estadoPedido = 0;
            Pedido nuevo = new Pedido();
            nuevo.detalle = "Pizza al pesto";
            nuevo.estado = 0;
            this.listaPedidos = new List<Pedido>();
            this.listaPedidos.Add(nuevo);
        }

        

        public string[] menuRestaurante = new string[] {
            "1. Yougurt con Frutas",
            "2. Ensalada de sandía y requesón",
            "3. Avena con manzana y canela",
            "4. Desayuno típico",
            "5. Huevos divorciados",
            "6. Cereal con leche",
            "7. Pizza napolitana",
            "8. Pizza al pesto",
            "9. Pollo rostizado con ensalada",
            "10. Filete empanizado de pescado",
            "11. Hamburguesa big steak",
            "12. Ensalada griega",
            "13. Torta española con queso"
        };
        /// <summary>
        /// Permite revisar el estado del pedido del cliente
        /// </summary>
        /// <returns></returns>
        public string Get()
        {
            if (listaPedidos.Count > 0)
            {
                estadoPedido = listaPedidos[0].estado;
            }
            else {
                estadoPedido = 0;
            }
            var seed = Environment.TickCount;
            var random = new Random(seed);
            estadoPedido = random.Next(0, 1);

            string estado = "";

            if (estadoPedido == 0)
            {
                estado = "Pedido en preparación";
            }
            else if (estadoPedido == 1)
            {
                estado = "Pedido listo";
            }


            return estado;
        }

        // POST api/<controller>/5
        public string Post(int id, [FromBody]string value)
        {
            Pedido nuevo = new Pedido();
            nuevo.estado = 0;
            string comida = menuRestaurante.GetValue(id - 1).ToString();
            nuevo.detalle = comida;
            listaPedidos.Add(nuevo);

            return "Pedido recibido";
        }

        public void Put(int id, [FromBody]string value)
        {
            if (listaPedidos.Count > 0)
            {
                listaPedidos[0].estado = id;
            }
            else
            {
                estadoPedido = id;
            }
            
        }
    }
}

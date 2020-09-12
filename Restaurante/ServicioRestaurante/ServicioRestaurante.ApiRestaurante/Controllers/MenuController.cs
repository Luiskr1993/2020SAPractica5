using ServicioRestaurante.ApiRestaurante.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;



namespace ServicioRestaurante.ApiRestaurante.Controllers
{
    public class MenuController : ApiController
    {
        List<Pedido> listaPedidos = new List<Pedido>();

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
        /// Permite consultar la información de toda la comida del menú.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<string> GetMenu()
        {
            return menuRestaurante;
        }

        
        // GET api/<controller>/Pedidos
        /// <summary>
        /// Permite regresar todos los pedidos
        /// </summary>
        /// <returns></returns>
        public List<Pedido> Pedidos()
        {
            return this.listaPedidos;
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

        /// <summary>
        /// Permite revisar el estado del pedido del cliente
        /// </summary>
        /// <returns></returns>


        // POST api/<controller>
        //public void Post([FromBody]string value)
        //{
        //}

        //// PUT api/<controller>/5
        public string Put(int id, [FromBody]string value)
        {
            string comida = menuRestaurante.GetValue(id - 1).ToString();
            return "Pedido recibido: " + comida;
        }

        //// DELETE api/<controller>/5
        //public void Delete(int id)
        //{
        //}
    }
}
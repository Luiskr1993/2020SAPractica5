using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ServicioESB.Controllers
{
    public class RepartidorController : ApiController
    {
        public string Put(int id, [FromBody]string value)
        {
            string respuesta = "";
            System.Diagnostics.Debug.WriteLine("****************************************************************************" + Environment.NewLine);
            System.Diagnostics.Debug.WriteLine("****************************************************************************" + Environment.NewLine);
            System.Diagnostics.Debug.WriteLine("****************************ESB ASIGNAR REPARTIDOR**************************" + Environment.NewLine);
            System.Diagnostics.Debug.WriteLine("****************************************************************************" + Environment.NewLine);
            System.Diagnostics.Debug.WriteLine("****************************************************************************" + Environment.NewLine);
            System.Diagnostics.Debug.WriteLine("");
            System.Diagnostics.Debug.WriteLine("");
            System.Diagnostics.Debug.WriteLine("Restaurante buscando repartidor...");
            System.Diagnostics.Debug.WriteLine("...");
            var client = new RestClient("http://localhost:50876/api/EstadoPedido/" + id.ToString());
            var peticion = new RestRequest(Method.PUT);
            IRestResponse response = client.Execute(peticion);
            respuesta = response.Content.ToString();

            System.Diagnostics.Debug.WriteLine("[ESB]Respuesta: " + respuesta);
            System.Diagnostics.Debug.WriteLine("****************************************************************************" + Environment.NewLine);
            System.Diagnostics.Debug.WriteLine("****************************************************************************" + Environment.NewLine);
            System.Diagnostics.Debug.WriteLine("");
            System.Diagnostics.Debug.WriteLine("");
            return respuesta;

        }
    }
}

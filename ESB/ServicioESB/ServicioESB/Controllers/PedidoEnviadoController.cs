using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ServicioESB.Controllers
{
    public class PedidoEnviadoController : ApiController
    {
        public string puerto = "54810";

        public string Get(int id)
        {
            
            string respuesta = "";
            System.Diagnostics.Debug.WriteLine("****************************************************************************" + Environment.NewLine);
            System.Diagnostics.Debug.WriteLine("****************************************************************************" + Environment.NewLine);
            System.Diagnostics.Debug.WriteLine("*******************ESB CLIENTE VERIFICA ESTADO ENVIO************************" + Environment.NewLine);
            System.Diagnostics.Debug.WriteLine("****************************************************************************" + Environment.NewLine);
            System.Diagnostics.Debug.WriteLine("****************************************************************************" + Environment.NewLine);
            System.Diagnostics.Debug.WriteLine("");
            System.Diagnostics.Debug.WriteLine("");
            System.Diagnostics.Debug.WriteLine("Cliente verificando estado del envío de su pedido con el repartidor...");
            System.Diagnostics.Debug.WriteLine("...");
            var client = new RestClient("http://localhost:"+puerto+"/api/PedidoTraslado/"+id.ToString());
            var peticion = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(peticion);
            respuesta = response.Content.ToString();

            System.Diagnostics.Debug.WriteLine("[ESB]Respuesta: " + respuesta);
            System.Diagnostics.Debug.WriteLine("****************************************************************************" + Environment.NewLine);
            System.Diagnostics.Debug.WriteLine("****************************************************************************" + Environment.NewLine);
            System.Diagnostics.Debug.WriteLine("");
            System.Diagnostics.Debug.WriteLine("");
            return respuesta;
        }


        public string Put(int id, [FromBody]string value)
        {
            string respuesta = "";
            System.Diagnostics.Debug.WriteLine("****************************************************************************" + Environment.NewLine);
            System.Diagnostics.Debug.WriteLine("****************************************************************************" + Environment.NewLine);
            System.Diagnostics.Debug.WriteLine("*******************ESB CLIENTE VERIFICA ESTADO ENVIO************************" + Environment.NewLine);
            System.Diagnostics.Debug.WriteLine("****************************************************************************" + Environment.NewLine);
            System.Diagnostics.Debug.WriteLine("****************************************************************************" + Environment.NewLine);
            System.Diagnostics.Debug.WriteLine("");
            System.Diagnostics.Debug.WriteLine("");
            System.Diagnostics.Debug.WriteLine("Repartidor actualizando su estado respecto al envío del pedido al cliente...");
            System.Diagnostics.Debug.WriteLine("...");
            var client = new RestClient("http://localhost:"+puerto+"/api/PedidoTraslado/" + id.ToString());
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

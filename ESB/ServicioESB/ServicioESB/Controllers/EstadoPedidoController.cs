using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ServicioESB.Controllers
{
    public class EstadoPedidoController : ApiController
    {
        public string Get()
        {
            string respuesta = "";

            System.Diagnostics.Debug.WriteLine("****************************************************************************" + Environment.NewLine);
            System.Diagnostics.Debug.WriteLine("****************************************************************************" + Environment.NewLine);
            System.Diagnostics.Debug.WriteLine("****************************ESB ESTADO PEDIDO*******************************" + Environment.NewLine);
            System.Diagnostics.Debug.WriteLine("****************************************************************************" + Environment.NewLine);
            System.Diagnostics.Debug.WriteLine("****************************************************************************" + Environment.NewLine);
            System.Diagnostics.Debug.WriteLine("");
            System.Diagnostics.Debug.WriteLine("");
            System.Diagnostics.Debug.WriteLine("Cliente realizando intrucción GET de estado...");
            System.Diagnostics.Debug.WriteLine("...");
            var client = new RestClient("http://localhost:50876/api/EstadoPedido");
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

        public string Post(int id, [FromBody]string value)
        {
            string respuesta = "";
            System.Diagnostics.Debug.WriteLine("****************************************************************************" + Environment.NewLine);
            System.Diagnostics.Debug.WriteLine("****************************************************************************" + Environment.NewLine);
            System.Diagnostics.Debug.WriteLine("****************************ESB PEDIR COMIDA********************************" + Environment.NewLine);
            System.Diagnostics.Debug.WriteLine("****************************************************************************" + Environment.NewLine);
            System.Diagnostics.Debug.WriteLine("****************************************************************************" + Environment.NewLine);
            System.Diagnostics.Debug.WriteLine("");
            System.Diagnostics.Debug.WriteLine("");
            System.Diagnostics.Debug.WriteLine("Cliente realizando intrucción GET de Menu de restaurante...");
            System.Diagnostics.Debug.WriteLine("...");
            var client = new RestClient("http://localhost:50876/api/EstadoPedido/" + id.ToString());
            var peticion = new RestRequest(Method.POST);
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

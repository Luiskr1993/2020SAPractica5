using RestSharp;
using ServicioESB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Text;

namespace ServicioESB.Controllers
{
    public class MenuController : ApiController
    {
       

        public string GetMenu()
        {
            string resultado = "";
            
            System.Diagnostics.Debug.WriteLine("****************************************************************************" + Environment.NewLine);
            System.Diagnostics.Debug.WriteLine("****************************************************************************" + Environment.NewLine);
            System.Diagnostics.Debug.WriteLine("****************************ESB MENU PEDIDO*********************************" + Environment.NewLine);
            System.Diagnostics.Debug.WriteLine("****************************************************************************" + Environment.NewLine);
            System.Diagnostics.Debug.WriteLine("****************************************************************************" + Environment.NewLine);
            System.Diagnostics.Debug.WriteLine("");
            System.Diagnostics.Debug.WriteLine("");
            System.Diagnostics.Debug.WriteLine("Cliente realizando intrucción GET de Menu de restaurante...");
            System.Diagnostics.Debug.WriteLine("...");
            var client = new RestClient("http://localhost:50876/api/Menu");
            var peticion = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(peticion);
            string respuesta = response.Content.Trim(new char[] { '[', ']' });
            //resultado = respuesta;
            string[] listado = respuesta.Split(',');
            for (int i = 0; i < listado.Length - 1; i++)
            {
                resultado = resultado + listado[i].ToString() + Environment.NewLine;
            }
            System.Diagnostics.Debug.WriteLine("[ESB]Respuesta: " + resultado);
            System.Diagnostics.Debug.WriteLine("****************************************************************************" + Environment.NewLine);
            System.Diagnostics.Debug.WriteLine("****************************************************************************" + Environment.NewLine);
            System.Diagnostics.Debug.WriteLine("");
            System.Diagnostics.Debug.WriteLine("");

            
            return resultado;
        }

        


    }
}

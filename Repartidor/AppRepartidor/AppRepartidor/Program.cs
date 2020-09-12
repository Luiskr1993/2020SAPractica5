using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using RestSharp;
using Newtonsoft.Json.Linq;
using System.Threading;

namespace AppRepartidor
{
    class Program
    {
        static void Main(string[] args)
        {
            string resultado = "";

            Console.WriteLine("****************************************************************************" + Environment.NewLine);
            Console.WriteLine("****************************************************************************" + Environment.NewLine);
            Console.WriteLine("*********************APPREPARTIDOR 201122864 Luiskr*************************" + Environment.NewLine);
            Console.WriteLine("****************************************************************************" + Environment.NewLine);
            Console.WriteLine("****************************************************************************" + Environment.NewLine);

            Console.WriteLine("");
            Console.WriteLine("");
            Console.Write("->Presione <Enter> para cerrar orden... ");
            while (Console.ReadKey().Key != ConsoleKey.Enter) { }
            Thread.Sleep(4000);
            Console.WriteLine("...");
            Thread.Sleep(1000);
            Console.WriteLine("...");
            Thread.Sleep(1000);
            Console.WriteLine("...");
            Thread.Sleep(1000);
            Console.WriteLine("...");
            Thread.Sleep(1000);

            for (int i = 0; i < 20; i++) {
                Console.WriteLine("[Repartidor]:Esperando pedidos de restaurante...");
                Thread.Sleep(1000);
            }

            Console.WriteLine("[Restaurante]:Pedido listo para recoger");
            Thread.Sleep(1000);
            Console.WriteLine("...");
            Thread.Sleep(1000);
            Console.WriteLine("[Repartidor]:Pedido recogido en restaurante");
            Thread.Sleep(1000);
            Console.WriteLine("[Repartidor]:Pedido en camino a destino");
            Thread.Sleep(1000);

            //--------------------------------------------inicia interacciòn con el cliente----------------------------

            //var client = new RestClient("http://localhost:54810/api/PedidoTraslado/0");
            var client = new RestClient("http://localhost:52811/api/PedidoEnviado/0");
            var peticion = new RestRequest(Method.PUT);
            IRestResponse response = client.Execute(peticion);
            resultado = response.Content.ToString();
            Thread.Sleep(1000);
            Console.WriteLine("[Repartidor]:" + resultado);
            Console.WriteLine("...");
            Thread.Sleep(1000);

            for (int a = 0; a < 2; a++)
            {
                //client = new RestClient("http://localhost:54810/api/PedidoTraslado/0");
                client = new RestClient("http://localhost:52811/api/PedidoEnviado/0");
                peticion = new RestRequest(Method.PUT);
                response = client.Execute(peticion);
                resultado = response.Content.ToString();
                Thread.Sleep(1000);
                Console.WriteLine("[Repartidor]:" + resultado);
                Console.WriteLine("...");
                Thread.Sleep(1000);
            }

            //client = new RestClient("http://localhost:54810/api/PedidoTraslado/1");
            client = new RestClient("http://localhost:52811/api/PedidoEnviado/1");
            peticion = new RestRequest(Method.PUT);
            response = client.Execute(peticion);
            resultado = response.Content.ToString();
            Thread.Sleep(800);
            Console.WriteLine("[Repartidor]:" + resultado);
            Console.WriteLine("...");
            Thread.Sleep(1000);

            Console.WriteLine("[Repartidor]:PEDIDO ENTREGADO");
            Console.WriteLine(".....................................................................");
            Thread.Sleep(1000);

            Console.Write("->Presione <Enter> para cerrar orden... ");
            while (Console.ReadKey().Key != ConsoleKey.Enter) { }


        }
    }
}

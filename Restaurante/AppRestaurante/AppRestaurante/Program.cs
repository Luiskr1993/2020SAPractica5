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

namespace AppRestaurante
{
    class Program
    {
        static void Main(string[] args)
        {
            string resultado = "";
            var client = new RestClient();
            var peticion = new RestRequest();
            IRestResponse response;
            Console.WriteLine("****************************************************************************" + Environment.NewLine);
            Console.WriteLine("****************************************************************************" + Environment.NewLine);
            Console.WriteLine("*********************RESTAURANTE 201122864 Luiskr****************************" + Environment.NewLine);
            Console.WriteLine("****************************************************************************" + Environment.NewLine);
            Console.WriteLine("****************************************************************************" + Environment.NewLine);
            Console.WriteLine("");
            Console.WriteLine("");
            Console.Write("->Presione <Enter> para cerrar orden... ");
            while (Console.ReadKey().Key != ConsoleKey.Enter) { }

            Console.WriteLine("->Esperando Pedido de cliente...");
            Thread.Sleep(3000);
            Console.WriteLine("->");
            Thread.Sleep(1000);
            Console.WriteLine("->");
            //Console.Write("->Presione <Enter> para preparar pedido... ");
            //while (Console.ReadKey().Key != ConsoleKey.Enter) { }
            Thread.Sleep(1000);
            Console.WriteLine("->...");
            Thread.Sleep(1000);
            Console.WriteLine("->...");
            Thread.Sleep(1000);
            Console.WriteLine("->...");
            Thread.Sleep(1000);
            Console.WriteLine("->...");
            Thread.Sleep(2000);

            Console.WriteLine("->");
            Console.WriteLine("->Pedido Recibido...");
            Thread.Sleep(2000);
            Console.WriteLine("->Preparando pedido...");
            Thread.Sleep(1000);
            int id = 0;
            Console.WriteLine("->...");
            Thread.Sleep(1000);
            Console.WriteLine("->...");
            Thread.Sleep(1000);
            Console.WriteLine("->...");
            Thread.Sleep(1000);
            int tiempoLimite = 0;

            //client = new RestClient("http://localhost:50876/api/EstadoPedido");
            client = new RestClient("http://localhost:52811/api/EstadoPedido");
            peticion = new RestRequest(Method.GET);
            response = client.Execute(peticion);
            resultado = response.Content.ToString();
            Thread.Sleep(1000);
            Console.WriteLine("[Estado de Pedido]:" + resultado);
            Console.WriteLine("...");
            Thread.Sleep(1000);
            Console.WriteLine("...");

            while (resultado == "\"Pedido en preparación\"" && tiempoLimite <= 5)
            {
                Console.WriteLine("[Restaurante]:Verificando estado de pedido: ");
                //client = new RestClient("http://localhost:50876/api/EstadoPedido");
                client = new RestClient("http://localhost:52811/api/EstadoPedido");
                peticion = new RestRequest(Method.GET);
                response = client.Execute(peticion);
                resultado = response.Content.ToString();
                Thread.Sleep(1000);
                Console.WriteLine("[Restaurante]:" + resultado);
                Console.WriteLine("...");
                tiempoLimite++;
            }

            if (resultado == "\"Pedido en preparación\"" || tiempoLimite > 5)
            {
                Console.WriteLine("[Restaurante]:Verificando estado de pedido: ");
                Thread.Sleep(1000);
                Console.WriteLine("[Restaurante]:Pedido Listo");
                Console.WriteLine("...");
                Thread.Sleep(1000);
                Console.WriteLine("...");
            }

            //-------------------------------Aqui termina interacción con el cliente------------------------------------

            //------------------------------Inicia interacciòn con el repartidor----------------------------------------

            Console.WriteLine("[Restaurante]:Buscando repartidor... ");
            Thread.Sleep(1000);
            //client = new RestClient("http://localhost:54250/api/Repartidor/0");
            client = new RestClient("http://localhost:52811//api/Repartidor/0");
            peticion = new RestRequest(Method.PUT);
            response = client.Execute(peticion);
            resultado = response.Content.ToString();
            Thread.Sleep(1000);
            Console.WriteLine("[Repartidor]:" + resultado);
            Console.WriteLine("...");
            Thread.Sleep(1000);

            Console.WriteLine("[Restaurante]:Buscando repartidor... ");
            Thread.Sleep(1000);
            //client = new RestClient("http://localhost:54250/api/Repartidor/1");
            client = new RestClient("http://localhost:52811/api/Repartidor/1");
            peticion = new RestRequest(Method.PUT);
            response = client.Execute(peticion);
            resultado = response.Content.ToString();
            Thread.Sleep(1000);
            Console.WriteLine("[Repartidor]:" + resultado);
            Console.WriteLine("...");
            Thread.Sleep(1000);


            Console.WriteLine("[Restaurante]:Pedido asignado a repartidor exitosamente... ");
            Console.WriteLine(".....................................................................");
            Thread.Sleep(1000);

            Console.Write("->Presione <Enter> para cerrar orden... ");
            while (Console.ReadKey().Key != ConsoleKey.Enter) { }
        }
    }
}

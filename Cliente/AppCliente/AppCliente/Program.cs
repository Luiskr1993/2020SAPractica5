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

namespace AppCliente
{
    class Program
    {
        static void Main(string[] args)
        {

            string resultado = "";

            Console.WriteLine("****************************************************************************" + Environment.NewLine);
            Console.WriteLine("****************************************************************************" + Environment.NewLine);
            Console.WriteLine("*********************APPCLIENTE 201122864 Luiskr****************************" + Environment.NewLine);
            Console.WriteLine("****************************************************************************" + Environment.NewLine);
            Console.WriteLine("****************************************************************************" + Environment.NewLine);
            Console.WriteLine("");
            Console.WriteLine("");
            Console.Write("->Presione <Enter> para cerrar orden... ");
            while (Console.ReadKey().Key != ConsoleKey.Enter) { }

            Console.WriteLine("[Cliente]:Realiza una petición del menú del restaurante para elegir su comida...");
            Thread.Sleep(1000);
            Console.WriteLine("...");
            Thread.Sleep(1000);
            Console.WriteLine("...");
            Thread.Sleep(1000);
            Console.WriteLine("[Cliente]:Se crea cliente de servicio para comunicarse con restaurante");
            Thread.Sleep(1000);
            Console.WriteLine("[Cliente]:Se realiza petición de menú al restaurante.");

            //var client = new RestClient("http://localhost:50876/api/Menu");
            var client = new RestClient("http://localhost:52811/api/Menu");
            var peticion = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(peticion);
            string respuesta =  response.Content.Trim(new char[] {'[', ']'});
            string[] listado = respuesta.Split(',');
            for (int i = 0; i < listado.Length - 1; i++) {
                resultado = resultado + listado[i].ToString() + Environment.NewLine;
            }
            Thread.Sleep(1000);
            Console.WriteLine("...");
            Thread.Sleep(1000);
            Console.WriteLine("[Restaurante]:Devuelve el menú...");
            Thread.Sleep(1000);
            Console.WriteLine(resultado);
            Thread.Sleep(1000);
            Console.WriteLine("...");
            Thread.Sleep(1000);
            Console.Write("[Cliente]:Debe elegir una opcion del menú: ");
            int seleccion = Int32.Parse(Console.ReadLine());

            Console.WriteLine("[Cliente]:Enviando pedido a restaurante...");
            //client = new RestClient("http://localhost:50876/api/EstadoPedido/"+seleccion);
            client = new RestClient("http://localhost:52811/api/EstadoPedido/" + seleccion);
            peticion = new RestRequest(Method.POST);
            response = client.Execute(peticion);
            resultado = response.Content.ToString();
            Thread.Sleep(1000);
            Console.WriteLine("[Restaurante]:" + resultado);
            Console.WriteLine("...");
            Thread.Sleep(1000);
            Console.WriteLine("...");
            Thread.Sleep(1000);
            Console.WriteLine("[Cliente]:Verificando estado de pedido: ");
            //client = new RestClient("http://localhost:50876/api/EstadoPedido");
            client = new RestClient("http://localhost:52811/api/EstadoPedido");
            peticion = new RestRequest(Method.GET);
            response = client.Execute(peticion);
            resultado = response.Content.ToString();
            Thread.Sleep(1000);
            Console.WriteLine("[Restaurante]:" + resultado);
            Console.WriteLine("...");
            Thread.Sleep(1000);
            Console.WriteLine("...");
            Thread.Sleep(1000);
            int tiempoLimite = 0;
            while (resultado == "\"Pedido en preparación\"" && tiempoLimite <= 5) {
                Console.WriteLine("[Cliente]:Verificando estado de pedido: ");
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
                Console.WriteLine("[Cliente]:Verificando estado de pedido: ");
                Thread.Sleep(3000);
                Console.WriteLine("[Restaurante]:Pedido Listo");
                Console.WriteLine("...");
                Thread.Sleep(2000);
                Console.WriteLine("...");
            }

            //---------------------------------termina interacciòn con el restaurante------------------------------------------

            //------------------------------inicia interacción con el repartidor -----------------------------------------------

            Console.WriteLine("[Cliente]:Verificando envío del pedido: ");
            Thread.Sleep(1000);
            //client = new RestClient("http://localhost:54810/api/PedidoTraslado/1");
            client = new RestClient("http://localhost:52811/api/PedidoEnviado/1");
            peticion = new RestRequest(Method.GET);
            response = client.Execute(peticion);
            resultado = response.Content.ToString();
            Thread.Sleep(1000);
            Console.WriteLine("[Repartidor]:" + resultado);
            Console.WriteLine("...");
            Thread.Sleep(1000);

            for (int a = 0; a < 5; a++) {
                client = new RestClient("http://localhost:54810/api/PedidoTraslado/" + a.ToString());
                client = new RestClient("http://localhost:52811/api/PedidoEnviado/" + a.ToString());
                peticion = new RestRequest(Method.GET);
                response = client.Execute(peticion);
                resultado = response.Content.ToString();
                Thread.Sleep(1000);
                Console.WriteLine("[Repartidor]:" + resultado);
                Console.WriteLine("...");
                Thread.Sleep(1000);
            }

            Console.WriteLine("[Cliente]:Pedido recibido exitosamente");
            Console.WriteLine(".....................................................................");
            Thread.Sleep(1000);

            Console.Write("->Presione <Enter> para cerrar orden... ");
            while (Console.ReadKey().Key != ConsoleKey.Enter) { }

        }
    }
}

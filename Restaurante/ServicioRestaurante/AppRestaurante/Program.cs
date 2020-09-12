using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using RestSharp;
using Newtonsoft.Json.Linq;

namespace AppRestaurante
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****************************************************************************" + Environment.NewLine);
            Console.WriteLine("****************************************************************************" + Environment.NewLine);
            Console.WriteLine("*********************RESTAURANTE 201122864 Luiskr****************************" + Environment.NewLine);
            Console.WriteLine("****************************************************************************" + Environment.NewLine);
            Console.WriteLine("****************************************************************************" + Environment.NewLine);
            Console.WriteLine("\n");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("->Esperando Pedido de cliente...");
            Console.WriteLine("->");
            Console.WriteLine("->");
            Console.Write("->Presione <Enter> para preparar pedido... ");
            while (Console.ReadKey().Key != ConsoleKey.Enter) { }

            Console.WriteLine("->...");
            Console.WriteLine("->...");
            Console.WriteLine("->...");
            Console.WriteLine("->...");
            Console.WriteLine("->");
            Console.WriteLine("->Pedido Recibido...");
            Console.WriteLine("->Preparando pedido...");
            int id = 0;
            Console.WriteLine("->...");
            Console.WriteLine("->...");
            Console.WriteLine("->...");
            Console.WriteLine("->...");
            Console.Write("->Cocinero indique Y si el pedido esta listo o N si no lo esta: ");
            
            switch (Console.ReadLine()) {
                case "Y":
                    id = 1;
                    break;
                case "N":
                    id = 0;
                    break;
            }

            while(id == 0) {
                Console.Write("->Cocinero indique Y si el pedido esta listo o N si no lo esta: ");

                switch (Console.ReadLine())
                {
                    case "Y":
                        id = 1;
                        break;
                    case "N":
                        id = 0;
                        break;
                }
            }

            Console.WriteLine("->...");
            Console.WriteLine("->...");
            Console.WriteLine("->...");
            var client = new RestClient("http://localhost:50876/api/EstadoPedido/1");
            var peticion = new RestRequest(Method.PUT);
            IRestResponse response = client.Execute(peticion);
            Console.WriteLine("->Pedido Preparado y listo para entregar");
            Console.WriteLine("->...");
            Console.WriteLine("->...");
            Console.WriteLine("->...");
            Console.WriteLine("->Avisando al repartidor");
            Console.WriteLine("->...");
            Console.WriteLine("->...");
            Console.WriteLine("->...");
            Console.WriteLine("->Pedido Entregado al Repartidor");
            Console.WriteLine("->...");
            Console.WriteLine("->...");
            Console.WriteLine("->...");
            Console.Write("->Presione <Enter> para cerrar orden... ");
            while (Console.ReadKey().Key != ConsoleKey.Enter) { }
        }
    }
}

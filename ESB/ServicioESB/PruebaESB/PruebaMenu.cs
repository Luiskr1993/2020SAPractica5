using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestSharp;

namespace PruebaESB
{
    /// <summary>
    /// Descripción resumida de PruebaMenu
    /// </summary>
    [TestClass]
    public class PruebaMenu
    {
        String respuesta;

        public PruebaMenu()
        {
            //
            // TODO: Agregar aquí la lógica del constructor
            //
            respuesta = "";
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Obtiene o establece el contexto de las pruebas que proporciona
        ///información y funcionalidad para la serie de pruebas actual.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Atributos de prueba adicionales
        //
        // Puede usar los siguientes atributos adicionales conforme escribe las pruebas:
        //
        // Use ClassInitialize para ejecutar el código antes de ejecutar la primera prueba en la clase
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup para ejecutar el código una vez ejecutadas todas las pruebas en una clase
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Usar TestInitialize para ejecutar el código antes de ejecutar cada prueba 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup para ejecutar el código una vez ejecutadas todas las pruebas
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void TestMenu()
        {
            //
            // TODO: Agregar aquí la lógica de las pruebas
            //
            var client = new RestClient("http://localhost:50876/api/Menu");
            var peticion = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(peticion);
            string respuesta = response.Content.Trim(new char[] { '[', ']' });
            Assert.IsTrue(respuesta != "", "Prueba Exitosa");
        }
    }
}

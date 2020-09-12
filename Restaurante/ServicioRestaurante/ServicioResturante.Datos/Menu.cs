using System;
using System.Collections.Generic;
using System.Text;

namespace ServicioResturante.Datos
{
    public class Menu
    {
        public string[] getDesayunos() {
            string[] menu = new string[] {
                "Yougurt con Frutas",
                "Ensalada de sandía y requesón",
                "Avena con manzana y canela",
                "Desayuno típico",
                "Huevos divorciados",
                "Cereal con leche"
            };

            return menu;
        }

        public string[] getOtros()
        {
            string[] menu = new string[] {
                "Pizza napolitana",
                "Pizza al pesto",
                "Pollo rostizado con ensalada",
                "Filete empanizado de pescado",
                "Hamburguesa big steak",
                "Ensalada griega",
                "Torta española con queso"
            };

            return menu;
        }
    }
}

using System;
using System.Collections.Generic;

namespace CapaDatos
{
    public class Pedidos
    {
        public String entradas { get; set; }

        public String platoFuerte { get; set; }

        public String postre { get; set; }

        public String bebidas { get; set; }

        public String mesa { get; set; }


        public void opciones()
        {
            List<String> entradas = new List<string>();
            List<String> platoFuerte = new List<string>();
            List<String> postre = new List<string>();
            List<String> bebidas = new List<string>();

            entradas.Add("entrada1");
            entradas.Add("entrada2");
            entradas.Add("entrada3");
            entradas.Add("entrada4");
            entradas.Add("entrada5");

            platoFuerte.Add("plato fuerte 1");
            platoFuerte.Add("plato fuerte 2");
            platoFuerte.Add("plato fuerte 3");
            platoFuerte.Add("plato fuerte 4");
            platoFuerte.Add("plato fuerte 5");

            postre.Add("postre 1");
            postre.Add("postre 2");
            postre.Add("postre 3");
            postre.Add("postre 4");
            postre.Add("postre 5");

            bebidas.Add("bebida 1");
            bebidas.Add("bebida 2");
            bebidas.Add("bebida 3");
            bebidas.Add("bebida 4");
            bebidas.Add("bebida 5");


        }
    }
}

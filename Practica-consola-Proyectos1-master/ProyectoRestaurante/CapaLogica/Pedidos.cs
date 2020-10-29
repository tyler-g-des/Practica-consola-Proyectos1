using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CapaLogica
{
    public class Pedidos
    {
        public String entradas { get; set; }

        public String platoFuerte { get; set; }

        public String postre { get; set; }

        public String bebidas { get; set; }

        public String mesa { get; set; }


        public void opciones(ComboBox entrada,ComboBox platoFuerte,ComboBox postre,ComboBox bebida)
        {

            entrada.Items.Add("entrada1");
            entrada.Items.Add("entrada2");
            entrada.Items.Add("entrada3");
            entrada.Items.Add("entrada4");
            entrada.Items.Add("entrada5");

            platoFuerte.Items.Add("plato fuerte 1");
            platoFuerte.Items.Add("plato fuerte 2");
            platoFuerte.Items.Add("plato fuerte 3");
            platoFuerte.Items.Add("plato fuerte 4");
            platoFuerte.Items.Add("plato fuerte 5");

            postre.Items.Add("postre 1");
            postre.Items.Add("postre 2");
            postre.Items.Add("postre 3");
            postre.Items.Add("postre 4");
            postre.Items.Add("postre 5");

            bebida.Items.Add("bebida 1");
            bebida.Items.Add("bebida 2");
            bebida.Items.Add("bebida 3");
            bebida.Items.Add("bebida 4");
            bebida.Items.Add("bebida 5");


        }
    }
}

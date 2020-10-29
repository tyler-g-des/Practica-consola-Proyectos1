using System;
using System.Collections.Generic;
using System.Text;

namespace CapaLogica
{
    public class crudPedidos
    {
        public static List<Pedidos> pedidoMesa1 = new List<Pedidos>();
        public static List<Pedidos> pedidoMesa2 = new List<Pedidos>();
        public static List<Pedidos> pedidoMesa3 = new List<Pedidos>();
        public static List<Pedidos> pedidoMesa4 = new List<Pedidos>();
        public static List<Pedidos> pedidoMesa5 = new List<Pedidos>();
        public static List<Pedidos> pedidoMesa6 = new List<Pedidos>();
        public static List<Pedidos> pedidoMesa7 = new List<Pedidos>();
        public static List<Pedidos> pedidoMesa8 = new List<Pedidos>();


        public void guardarPerdido(String entradas, String platoFuerte, String postre, String bebidas, String mesa)
        {
            if (mesa.Equals("MESA 1"))
            {
                pedidoMesa1.Add(new Pedidos
                {
                    entradas = entradas,
                    platoFuerte = platoFuerte,
                    postre = postre,
                    bebidas = bebidas
                });
            }

            else if(mesa == "MESA 2")
            {
                pedidoMesa2.Add(new Pedidos
                {
                    entradas = entradas,
                    platoFuerte = platoFuerte,
                    postre = postre,
                    bebidas = bebidas
                });
            }

            else if (mesa == "MESA 3")
            {
                pedidoMesa3.Add(new Pedidos
                {
                    entradas = entradas,
                    platoFuerte = platoFuerte,
                    postre = postre,
                    bebidas = bebidas
                });
            }

            else if (mesa == "MESA 4")
            {
                pedidoMesa4.Add(new Pedidos
                {
                    entradas = entradas,
                    platoFuerte = platoFuerte,
                    postre = postre,
                    bebidas = bebidas
                });
            }

            else if (mesa == "MESA 5")
            {
                pedidoMesa5.Add(new Pedidos
                {
                    entradas = entradas,
                    platoFuerte = platoFuerte,
                    postre = postre,
                    bebidas = bebidas
                });
            }

            else if (mesa == "MESA 6")
            {
                pedidoMesa6.Add(new Pedidos
                {
                    entradas = entradas,
                    platoFuerte = platoFuerte,
                    postre = postre,
                    bebidas = bebidas
                });
            }

            else if (mesa == "MESA 7")
            {
                pedidoMesa7.Add(new Pedidos
                {
                    entradas = entradas,
                    platoFuerte = platoFuerte,
                    postre = postre,
                    bebidas = bebidas
                });
            }

            else if (mesa == "MESA 8")
            {
                pedidoMesa8.Add(new Pedidos
                {
                    entradas = entradas,
                    platoFuerte = platoFuerte,
                    postre = postre,
                    bebidas = bebidas
                });
            }

        }



    }
}

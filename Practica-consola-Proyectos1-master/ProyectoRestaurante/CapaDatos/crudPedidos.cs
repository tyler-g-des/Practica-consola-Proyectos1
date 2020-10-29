using System;
using System.Collections.Generic;
using System.Text;

namespace CapaDatos
{
    public class crudPedidos
    {
        public static List<Pedidos> pedidoMesa1 = new List<Pedidos>();
        public static List<Pedidos> pedidoMesa2 = new List<Pedidos>();
        public static List<Pedidos> pedidoMesa3 = new List<Pedidos>();
        public static List<Pedidos> pedidoMesa4 = new List<Pedidos>();
        public static List<Pedidos> pedidoMesa5 = new List<Pedidos>();


        public void guardarPerdido(String entradas, String platoFuerte, String postre, String bebidas)
        {
            pedidoMesa1.Add(new Pedidos { entradas = entradas, platoFuerte = platoFuerte,
                                          postre = postre,     bebidas = bebidas});
        }



    }
}

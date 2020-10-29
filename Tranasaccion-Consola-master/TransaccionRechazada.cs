using Practica.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica
{
    public class TransaccionRechazada : Rechazada
    {
        public static List<Transaccion> transaccionesElimina = new List<Transaccion>();

        public void MostrarTransaccionesEliminada()
        {
            foreach (var item in transaccionesElimina)
            {
                String tipo;
                if (item.tipoTransaccion == 1)
                    tipo = "Transaccion Aceptada";
                else
                    tipo = "Transaccion rechazada";

                Console.WriteLine("ID: " + item.numeroTransaccion + ", " + "Nombre cliente: " + item.nombreCliente + ", " + "Monto: " + item.montoTransaccion + ", " + tipo);
            }


        }

        public void TransaccionesEliminada(List<Transaccion> transacciones)
        {
            foreach (var item in transacciones)
            {
                transaccionesElimina.Add(new Transaccion { montoTransaccion = item.montoTransaccion, nombreCliente = item.nombreCliente, numeroTransaccion = item.numeroTransaccion, tipoTransaccion = item.tipoTransaccion });
            }
        }
    }
}

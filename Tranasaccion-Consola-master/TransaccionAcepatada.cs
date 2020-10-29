using Practica.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica
{
    public class TransaccionAceptada : Aceptada
    {
        public static List<Transaccion> transaccionesCanceladas = new List<Transaccion>();

        public void AgregadasTransaccionesCanceladas(List<Transaccion> transacciones)
        {
            
            foreach (var item in transacciones)
            {
                transaccionesCanceladas.Add(new Transaccion { montoTransaccion = item.montoTransaccion, nombreCliente = item.nombreCliente,numeroTransaccion=item.numeroTransaccion,tipoTransaccion=item.tipoTransaccion});
            }
        }

        public void MostrarTransaccionesCanceladas()

        {

            foreach (var item in transaccionesCanceladas)
            {
                String tipo;
                if (item.tipoTransaccion == 1)
                    tipo = "Transaccion Aceptada";
                else
                    tipo = "Transaccion rechazada";

                Console.WriteLine("ID: " + item.numeroTransaccion + ", " + "Nombre cliente: " + item.nombreCliente + ", " + "Monto: " + item.montoTransaccion + ", " + tipo);
            }



        }
    }
}

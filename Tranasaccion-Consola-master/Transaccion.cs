using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica
{
     public class Transaccion
     {
        public static List<Transaccion> transacciones = new List<Transaccion>();

        //Propiedades
        public  int numeroTransaccion { get; set; }
        public String nombreCliente { get; set; }
        public Double montoTransaccion { get; set; }

        // 1 = transaccion aprobada
        //2 = transaccion rechazada
        public int tipoTransaccion { get; set; }


        // Metodos contructor
        public Transaccion(){}

        public Transaccion(int numeroTransaccion, String nombreCliente, int montoTransaccion)
        {
            this.numeroTransaccion = numeroTransaccion;
            this.nombreCliente = nombreCliente;
            this.montoTransaccion = montoTransaccion; 
        }
     }
}

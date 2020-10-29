using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica
{
    public class LogicaTransaccion
    {
        Transaccion transaccion;
        TransaccionAceptada transaccionA;
        static int conteo = 0;
        static int auto = 100;

        public void mostrarTransacciones()
        {
            foreach (var item in Transaccion.transacciones)
            {
                String tipo;
                if (item.tipoTransaccion == 1)
                    tipo = "Transaccion Aceptada";
                else
                    tipo = "Transaccion rechazada";

                Console.WriteLine("ID: " + item.numeroTransaccion + ", " + "Nombre cliente: " + item.nombreCliente + ", " + "Monto: " + item.montoTransaccion + ", " + tipo);
            }
        }

        public void AgregarTransaccion(int tipo)
        {
            transaccion = new Transaccion();

            Console.WriteLine("REGISTRO DE TRANSACCION" + "\n INTRODUZCA SU NOMBRE");

            transaccion.nombreCliente = Console.ReadLine();
            Console.ReadKey();

            Console.WriteLine("REGISTRO DE TRANSACCION" + "\n INTRODUZCA EL MONTO");
            transaccion.montoTransaccion = Double.Parse(Console.ReadLine());
            Console.ReadKey();


            transaccion.numeroTransaccion = auto++;
            conteo++;
            transaccion.tipoTransaccion = tipo;

            Transaccion.transacciones.Add(new Transaccion() { nombreCliente = transaccion.nombreCliente, montoTransaccion = transaccion.montoTransaccion, numeroTransaccion = transaccion.numeroTransaccion, tipoTransaccion = transaccion.tipoTransaccion });

            Console.WriteLine("TRANSACCION GUARDADA DE MANERA EXITOSA !!");
            Console.ReadKey();

            Console.Clear();
        }

        public void EliminarTransaccion(int h)
        {
            //---------------Lista Auxiliar-----------------//
            //List<Transaccion> listAux = new List<Transaccion>();

            //foreach (Transaccion item in Transaccion.transacciones)
            //{
            //   if(!item.numeroTransaccion.ToString().Contains(h))
            //    {
            //        listAux.Add(item);
            //    }

            //}

            //foreach(Transaccion item in Transaccion.transacciones)
            //{

            //        Transaccion.transacciones.Remove(item);
            //        Console.WriteLine("Si");
            //        Console.ReadKey();

            //}

            // Busqueda



            var busqueda = (from item in Transaccion.transacciones
                            where item.numeroTransaccion.Equals(h)
                            select item);

            var busqueda1 = (from item in busqueda
                             where item.tipoTransaccion.Equals(1)
                             select item);

            var busqueda2 = (from item in busqueda
                             where item.tipoTransaccion.Equals(2)
                             select item);


              foreach (var item in busqueda)
              {
                if (item.tipoTransaccion == 1) 
                {
                    TransaccionAceptada.transaccionesCanceladas.Add(new Transaccion { nombreCliente = item.nombreCliente, montoTransaccion = item.montoTransaccion, numeroTransaccion = item.numeroTransaccion, tipoTransaccion = item.tipoTransaccion });
                }
                else
                {
                    TransaccionRechazada.transaccionesElimina.Add(new Transaccion { nombreCliente = item.nombreCliente, montoTransaccion = item.montoTransaccion, numeroTransaccion = item.numeroTransaccion, tipoTransaccion = item.tipoTransaccion });

                }
            }
                    


                    Transaccion.transacciones.Remove(busqueda.First());
        }

        public void EditarTransaccionNombre(int h, String texto)
        {
            var busqueda = (from item in Transaccion.transacciones
                            where item.numeroTransaccion.Equals(h)
                            select item);

            List<Transaccion> b = (from item in Transaccion.transacciones
                                   where item.numeroTransaccion.Equals(h)
                                   select item).ToList();

            
                if (busqueda != null)
                {
                    Transaccion.transacciones.Remove(busqueda.First());
                    Transaccion.transacciones.Add(new Transaccion { nombreCliente = texto, numeroTransaccion = h, tipoTransaccion = b.First().tipoTransaccion, montoTransaccion = b.First().montoTransaccion});
                }
                else
                {
                    Console.WriteLine("Ese ID no existe");
                    Program pp = new Program();
                    pp.menuPrincipal();
                }

         }
        public void EditarTransaccionMonto(int h, String texto)
        {
            var busqueda = (from item in Transaccion.transacciones
                            where item.numeroTransaccion.Equals(h)
                            select item);

            List<Transaccion> b = (from item in Transaccion.transacciones
                                   where item.numeroTransaccion.Equals(h)
                                   select item).ToList();


            if (busqueda != null)
            {
                Transaccion.transacciones.Remove(busqueda.First());
                Transaccion.transacciones.Add(new Transaccion { nombreCliente = b.First().nombreCliente, numeroTransaccion = h, tipoTransaccion = b.First().tipoTransaccion, montoTransaccion = int.Parse(texto)});
            }
            else
            {
                Console.WriteLine("El ID no es valido");
                Console.ReadKey();
                Program pp = new Program();
                pp.menuPrincipal();
            }

        }

    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica
{
    public class Program
    {

        private int seleccionMenuPrincipal;
        private int seleccionMenuAgregarTransaccion;
        private int seleccionMenueEliminarTransaccion;
        private int seleccionAuditorias;
        private int seleccionMenuEditar;
        private int editar;
        private string nombre;

        static void Main(string[] args)
        {
            Program clase = new Program(); 
            clase.menuPrincipal();
        }


        public void menuPrincipal()
        {
            Console.WriteLine("REGISTRO DE TRANSACCION" + "\n 1. Registro de Transaccion" + "\n 2. Mostrar Transacciones"
                + "\n 3. Eliminar Transaccion" + "\n 4. Control de auditorias" + "\n 5. Editar Transaccion");
            seleccionMenuPrincipal = int.Parse(Console.ReadLine());
            Console.ReadKey();
            Console.Clear();

            switch (seleccionMenuPrincipal)
            {
                case 1:
                    Console.WriteLine("REGISTRO DE TRANSACCION" + "\n 1. Transaccion Aceptada" +
                    "\n 2. Transaccion Rechazada");

                    seleccionMenuAgregarTransaccion = int.Parse(Console.ReadLine());


                    switch (seleccionMenuAgregarTransaccion)
                    {

                        case 1:
                            Console.ReadKey();
                            Console.Clear();
                            LogicaTransaccion tra = new LogicaTransaccion();
                            tra.AgregarTransaccion(1);
                            menuPrincipal();
                            break;

                        case 2:
                            Console.ReadKey();
                            Console.Clear();
                            LogicaTransaccion trr = new LogicaTransaccion();
                            trr.AgregarTransaccion(2);
                            menuPrincipal();
                            break;

                        default:
                            Console.WriteLine("\n !! DEBE INTRODUCIR UNA OPCION VALIDA !!");
                            break;
                    }
                    break;

                case 2:
                    LogicaTransaccion traV = new LogicaTransaccion();
                    traV.mostrarTransacciones();
                    Console.ReadKey();
                    Console.Clear();
                    menuPrincipal();
                    break;

                case 3:
                    Console.WriteLine("Introduzca el numero el id de la transaccion que desea eleminar"
                      + "\n 0. Si no conoce el numero el ID vaya al menu principal la opcion MOSTRAR TRANSACCIONES");

                    seleccionMenueEliminarTransaccion = int.Parse(Console.ReadLine());
                    if (seleccionMenueEliminarTransaccion == 0)
                    {
                        Console.ReadKey();
                        Console.Clear();
                        menuPrincipal();
                    }
                    else
                    {
                        LogicaTransaccion traE = new LogicaTransaccion();
                        traE.EliminarTransaccion(seleccionMenueEliminarTransaccion);
                        Console.WriteLine("TRANSACCION ELIMINADA DE MANERA EXITOSA !!");
                        Console.ReadKey();
                        Console.Clear();
                        menuPrincipal();
                    }
                    break;

                case 4:
                    Console.WriteLine("1. Transacciones Canceladas" + "\n 2. Transacciones Eliminadas");
                    seleccionAuditorias = int.Parse(Console.ReadLine());
                    switch (seleccionAuditorias)
                    {
                        case 1:
                            TransaccionAceptada ta = new TransaccionAceptada();
                            ta.MostrarTransaccionesCanceladas();
                            Console.ReadKey();
                            Console.Clear();
                            menuPrincipal();
                            break;

                        case 2:
                            TransaccionRechazada te = new TransaccionRechazada();
                            te.MostrarTransaccionesEliminada();
                            Console.ReadKey();
                            Console.Clear();
                            menuPrincipal();
                            break;

                        default:
                            Console.WriteLine("\n !! DEBE INTRODUCIR UNA OPCION VALIDA !!");
                            Console.ReadKey();
                            Console.Clear();
                            menuPrincipal();
                            break;
                    }
                    break;

                case 5:

                    Console.WriteLine("Introduzca el numero el id de la transaccion que desea editar"
               + "\n 0. Si no conoce el numero el ID vaya al menu principal la opcion MOSTRAR TRANSACCIONES");
                    seleccionMenuEditar = int.Parse(Console.ReadLine());

              
                    if (seleccionMenuEditar  ==  0)
                    {
                        Console.ReadKey();
                        Console.Clear();
                        menuPrincipal();
                    }
                    else
                    {

                        Console.WriteLine("Que desea editar " + "\n 1. nombre " + "2. monto");
                        editar = int.Parse(Console.ReadLine());
                        switch (editar) 
                        {
                            case 1:
                                
                                Console.WriteLine("Escriba el nuevo nombre");
                                nombre = Console.ReadLine();
                                Console.ReadKey();
                                LogicaTransaccion traE = new LogicaTransaccion();
                                traE.EditarTransaccionNombre(seleccionMenuEditar,nombre);
                                Console.WriteLine("!! Nombre modificado !!");
                                Console.ReadKey();
                                Console.Clear();
                                menuPrincipal();
                                break;

                            case 2:
                                Console.WriteLine("Escriba el nuevo monto");
                                nombre = Console.ReadLine();
                                Console.ReadKey();
                                LogicaTransaccion traMN = new LogicaTransaccion();
                                traMN.EditarTransaccionMonto(seleccionMenuEditar, nombre);
                                Console.WriteLine("!! Nombre modificado !!");
                                Console.ReadKey();
                                Console.Clear();
                                menuPrincipal();
                                break;

                        }
                          
                    
                    }

                    break;
                  
                default:
                    Console.WriteLine("\n !! DEBE INTRODUCIR UNA OPCION VALIDA !!");
                    Console.ReadKey();
                    Console.Clear();
                    menuPrincipal();
                    break;
            }
        }

    


    }
}

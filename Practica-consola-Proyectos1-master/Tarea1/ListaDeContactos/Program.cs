using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeContactos
{
    class Program
    {
        static void Main(string[] args)
        {
            Program pg = new Program();
            pg.menuPrincipal();
        }

        void menuPrincipal()
        {
            int eleccionMP;

            Console.WriteLine("Seleccione con el numero de la opcion " +
                " \n 1. Agregar Contacto" +
                " \n 2. Mostrar Contacto" +
                " \n 3. Editar Contacto" +
                " \n 4. Eliminar Contacto");

            try
            {
                eleccionMP = int.Parse(Console.ReadLine());
                if(eleccionMP > 4 )
                {
                    Console.WriteLine("Debe introducir el numero de la opcion");
                    Console.ReadLine();
                    Console.Clear();
                    menuPrincipal();
                }

                else if (eleccionMP == 1) 
                {
                    Console.Clear();
                    menuAgregarContacto();
                }

                else if(eleccionMP == 2)
                {
                    Console.Clear();
                    mostrarContacto();

                }

                else if (eleccionMP == 3)
                {
                    Console.Clear();
                    editarContacto();
                }

                else if (eleccionMP == 4)
                {
                    Console.Clear();
                    menuEliminar();
                }

            }
            catch
            {
                Console.WriteLine("Debe introducir el numero de la opcion");
                Console.ReadLine();
                Console.Clear();
                menuPrincipal();
            }
        }

        void menuAgregarContacto()
        {
            String nombre;
            int numero;

            Console.WriteLine("Introduzca el nombre del contacto");
            nombre = Console.ReadLine();
            Console.Clear();

            if (nombre == "")
            {
                Console.WriteLine("Debe intrducir un nombre");
                Console.ReadLine();
                Console.Clear();
                menuAgregarContacto();
            }

            Console.WriteLine("Introduzca el numero del contacto");
            try
            {
                numero = int.Parse(Console.ReadLine());
                Console.Clear();

                LogicaContacto lg = new LogicaContacto();
                lg.AgregarContacto(nombre,numero);
                menuPrincipal();    

            }
            catch
            {
                Console.WriteLine("Debes introducir numeros");
                Console.ReadLine();
                Console.Clear();
                menuAgregarContacto();
            }
        }

        void mostrarContacto()
        {
            LogicaContacto lg = new LogicaContacto();
            lg.Mostrar();
            menuPrincipal();
        }

        void editarContacto()
        {
            String nombreAntiguo, nombreNuevo;
            int nuevoNumero;

            Console.WriteLine("Introduzca el nombre del contacto que desea editar");
            nombreAntiguo =  Console.ReadLine();


            Console.Clear();
            Console.WriteLine("Introduzca el nuevo nombre");
            nombreNuevo = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Introduzca el nuevo numero");

            try
            {
                nuevoNumero =int.Parse( Console.ReadLine());

                LogicaContacto lg = new LogicaContacto();
                lg.Edita(nombreAntiguo,nombreNuevo,nuevoNumero);
                menuPrincipal();
            }
            catch
            {
                Console.WriteLine("Introduzca el nombre del contacto que desea que tenga el contacto");
                Console.ReadLine();
                Console.Clear();
                editarContacto();
            }
        }

        void menuEliminar()
        {
            int numero;

            Console.WriteLine("Introduzca el numero que desea eliminar");
            try
            {
                numero = int.Parse(Console.ReadLine());
                LogicaContacto lg = new LogicaContacto();
                lg.Eliminar(numero);

                menuPrincipal();

            }
            catch
            {
                Console.WriteLine("Debes introducir el numero del contacto");
                Console.ReadLine();
                Console.Clear();
                menuEliminar();
            }
        }
    }
}

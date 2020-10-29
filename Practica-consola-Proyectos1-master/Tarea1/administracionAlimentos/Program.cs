using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace administracionAlimentos
{
    class Program
    {

        int eleccionLista;
        static void Main(string[] args)
        {
            Program pg = new Program();
            pg.menuPrincipal();
        }

        void menuPrincipal()
        {
            int eleccionMP;

            Console.WriteLine("Seleccione una opcion \n 1. Editar alimentos " +
                "\n 2. Ver una lista de alimentos " +
                "\n 3. Ver todos los alimentos ");

            try
            {
                eleccionMP = int.Parse(Console.ReadLine());
                if (eleccionMP > 3)
                {
                    Console.WriteLine("Debe seleccionar una opcion valida");
                    Console.ReadLine();
                    Console.Clear();
                    menuPrincipal();
                }
                if (eleccionMP == 1) { Console.Clear(); menuCRUDAlimentos(); }
                if (eleccionMP == 2) { Console.Clear(); mostrarAlimentos(); }
                if (eleccionMP == 3) { Alimentos al = new Alimentos(); al.MostrarTodosAlimento(); menuPrincipal(); }
            }
            catch
            {
                Console.WriteLine("Debe colocar solo el numero de la opcion");
                Console.ReadLine();
                Console.Clear();
                menuPrincipal();
            }
        }
        void menuCRUDAlimentos()
        {
            int eleccionMP;

            Console.WriteLine("Seleccione una opcion \n 1. Agregar Alimentos " +
                "\n 2. Editar Alimentos " +
                "\n 3. Borrar Alimentos ");

            try
            {
                eleccionMP = int.Parse(Console.ReadLine());

                if (eleccionMP > 3)
                {
                    Console.WriteLine("Debe seleccionar una opcion valida");
                    Console.ReadLine();
                    Console.Clear();
                    menuPrincipal();
                }

                if (eleccionMP == 1) { 
                    Console.Clear(); 
                    seleccionarLista();
                    Console.Clear();
                    agregarAlimento(); 
                }

                if (eleccionMP == 2)
                {
                    Console.Clear();
                    seleccionarLista();
                    Console.Clear();
                    renombrarAlimento();
                }

                if (eleccionMP == 3)
                {
                    Console.Clear();
                    seleccionarLista();
                    Console.Clear();
                    eliminarAlimento();
                }


            }
            catch
            {
                Console.WriteLine("Debe colocar solo el numero de la opcion");
                Console.ReadLine();
                Console.Clear();
                menuCRUDAlimentos();
            }
        }
        void seleccionarLista()
        {
            

            Console.WriteLine("Seleccione una lista \n 1. frutas " +
                "\n 2. vegetales " +
                "\n 3. lacteos");

            try
            {
                eleccionLista = int.Parse(Console.ReadLine());
                if (eleccionLista > 3)
                {
                    Console.WriteLine("Debe seleccionar una opcion valida");
                    Console.ReadLine();
                    Console.Clear();
                    menuPrincipal();
                }
                      

            }
            catch
            {
                Console.WriteLine("Debe colocar solo el numero de la opcion");
                Console.ReadLine();
                Console.Clear();
                seleccionarLista();
            }

     
        }


        // CRUD 
        void agregarAlimento()
        {

            String nombreElementos;
            Console.WriteLine("Escriba el elemento que desea agregar");

            try
            {
                nombreElementos = Console.ReadLine();

                Alimentos al = new Alimentos();
                al.AgregarAlimentos(eleccionLista, nombreElementos);
                Console.Clear();
                menuPrincipal();
            }
            catch
            {

            }
        }

        void eliminarAlimento()
        {
            int alimento;
            Console.WriteLine("Escriba el numero del alimento que desea eliminar");

            try
            {
                alimento = int.Parse(Console.ReadLine());

                Alimentos al = new Alimentos();
                al.BorrarElementos(eleccionLista,alimento);
                Console.Clear();
                menuPrincipal();
            }
            catch
            {
                Console.WriteLine("Debe escribir el numero del elemento");
                Console.ReadLine();
                Console.Clear();

                eliminarAlimento();

            }
        }

        void renombrarAlimento()
        {
            int alimento;
            Console.WriteLine("Escriba el numero del alimento que desea renombrar");

         
            try
            {
                alimento = int.Parse(Console.ReadLine());

                Console.Clear();

                String nombre;
                Console.WriteLine("Escriba el nuevo nombre");

                try
                {
                    nombre = Console.ReadLine();


                    Alimentos al = new Alimentos();
                    al.EditarAlimento(eleccionLista, alimento,nombre);
                    Console.Clear();
                    menuPrincipal();
                }
                catch 
                {
                    Console.WriteLine("Debe escribir el nombre nuevo");
                    Console.ReadLine();
                    Console.Clear();

                    renombrarAlimento();
                }
              
            }
            catch
            {
                Console.WriteLine("Debe escribir el numero del elemento");
                Console.ReadLine();
                Console.Clear();

                renombrarAlimento();

            }
        }

        void mostrarAlimentos()
        {
            seleccionarLista();
            Console.Clear();

            Alimentos al = new Alimentos();
            al.MostrarAlimento(eleccionLista);

            Console.Clear();
            menuPrincipal();
        }


    }
}


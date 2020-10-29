using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace administracionAlimentos
{
    class Alimentos
    {
        private static List<String> frutas = new List<String>(9);
        private static List<String> vegetales = new List<String>(9);
        private static List<String> lacteos = new List<String>(9);


        public void AgregarAlimentos(int lista, String nombreAlimento)
        {
            try
            {

                if (nombreAlimento.Equals(""))
                {
                    Console.WriteLine("Debes introducir el nombre del alimento");
                    Console.ReadLine();
                }
                else
                {

                    if (lista == 1)
                    {
                        if (frutas.Count() > 8)
                        {
                            Console.WriteLine("La lista esta llena");
                            Console.ReadLine();
                        }
                        else
                        {
                            frutas.Add(nombreAlimento);
                            Console.WriteLine("Agregado de manera Exitosa !!");
                            Console.ReadLine();
                        }
                    }

                    if (lista == 2)
                    {
                        if (vegetales.Count() > 8)
                        {
                            Console.WriteLine("La lista esta llena");
                            Console.ReadLine();

                        }
                        else
                        {
                            vegetales.Add(nombreAlimento);
                            Console.WriteLine("Agregado de manera Exitosa !!");
                            Console.ReadLine();
                        }
                    }

                    if (lista == 3)
                    {
                        if (lacteos.Count() > 8)
                        {
                            Console.WriteLine("La lista esta llena");
                            Console.ReadLine();

                        }
                        else
                        {
                            lacteos.Add(nombreAlimento);
                            Console.WriteLine("Agregado de manera Exitosa !!");
                            Console.ReadLine();
                        }
                    }

                }

            }
            catch
            {
                Console.WriteLine("Debe escribir el nombre del alimento");
            }
        }

        public void BorrarElementos(int lista, int alimento)
        {
            try
            {
                if (lista == 1)
                {
                    if (frutas.Count() > alimento)
                    {
                        Console.WriteLine("Debe seleccionar un numero de la lista");
                        Console.ReadLine();
                    }
                    else
                    {
                        frutas.RemoveAt(alimento - 1);
                        Console.WriteLine("Eliminado de manera Exitosa !!");
                        Console.ReadLine();
                    }
                }

                if (lista == 2)
                {
                    if (vegetales.Count() > alimento)
                    {
                        Console.WriteLine("Debe seleccionar un numero de la lista");
                        Console.ReadLine();
                    }
                    else
                    {
                        frutas.RemoveAt(alimento - 1);
                        Console.WriteLine("Eliminado de manera Exitosa !!");
                        Console.ReadLine();
                    }
                }

                if (lista == 3)
                {
                    if (vegetales.Count() > alimento)
                    {
                        Console.WriteLine("Debe seleccionar un numero de la lista");
                        Console.ReadLine();
                    }
                    else
                    {
                        frutas.RemoveAt(alimento - 1);
                        Console.WriteLine("Eliminado de manera Exitosa !!");
                        Console.ReadLine();
                    }
                }

            }
            catch
            {
                Console.WriteLine("Debe escribir el numero del alimento");
            }
        }

        public void MostrarAlimento(int lista)
        {
            if (lista == 1)
            {
                int conteo = 1;
                foreach (var item in frutas)
                {
                    Console.WriteLine(conteo + ". " + item);
                    conteo++;
                }
            }

            if (lista == 2)
            {
                int conteo = 1;

                foreach (var item in vegetales)
                {
                    Console.WriteLine(conteo + ". " + item);
                    conteo++;
                }

            }

            if (lista == 3)
            {
                int conteo = 1;

                foreach (var item in lacteos)
                {
                    Console.WriteLine(conteo + ". " + item);
                    conteo++;
                }

            }

            Console.ReadLine();
        }

        public void MostrarTodosAlimento()
        {
            int conteo = 1;
            foreach (var item in frutas)
            {

                foreach (var item1 in vegetales)
                {
                    foreach (var item2 in lacteos)
                    {
                        Console.WriteLine(conteo + ". " + item);
                        conteo++;
                        Console.WriteLine(conteo + ". " + item1);
                        conteo++;
                        Console.WriteLine(conteo + ". " + item2);
                        conteo++;

                    }
                }
            }
            Console.ReadLine();
            Console.Clear();
        }

        public void EditarAlimento(int lista, int alimento, String nombre)
        {
            try
            {
                BorrarElementos(lista, alimento);
                AgregarAlimentos(lista, nombre);

                Console.WriteLine("Modificado de manera exitosa !!");
            }
            catch
            {
                Console.WriteLine("Debes escribir el numero de la lista");
            }
        }
    }
}

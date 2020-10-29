using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Program pg = new Program();
            pg.menuPrincipal();
        }

        public void menuPrincipal()
        {
            double eleccion;

            Console.WriteLine("Seleccionar Opcion \n 1. Calcular \n 2. Salir");

            try
            {
                eleccion = double.Parse(Console.ReadLine());

                if(eleccion > 2)
                {
                    Console.WriteLine("Debe seleccionar una opcion con su numero");
                    Console.ReadLine();
                    Console.Clear();
                    menuPrincipal();
                }
                else if(eleccion == 1)
                {
                    menuCalculos();
                    Console.Clear();
                    menuPrincipal();
                }
            }
            catch
            {
                Console.WriteLine("Debes doubleroducir un numero");
                Console.ReadLine();
                Console.Clear();
                menuPrincipal();
            }
        }

        void menuCalculos()
        {
            double eleccion;
            Console.Clear();
            Console.WriteLine("Seleccionar Opcion \n 1. Sumar \n 2. Restar \n 3. Multiplicar \n 4. Dividir");

            try
            {
                eleccion = double.Parse(Console.ReadLine());


                if (eleccion > 5)
                {
                    Console.WriteLine("Debe seleccionar una opcion con su numero");
                    Console.ReadLine();
                    Console.Clear();
                    menuCalculos();
                }
                else if(eleccion == 1)
                {
                    Sumar();
                }
                else if (eleccion == 2)
                {
                    resta();
                }
                else if (eleccion == 3)
                {
                    multiplicar();
                }
                else if (eleccion == 4)
                {
                    dividir();
                }

            }
            catch
            {
                Console.WriteLine("Debes doubleroducir un numero");
                Console.ReadLine();
                Console.Clear();
                menuPrincipal();
            }
        }

        void Sumar()
        {
            double num1, num2;
            Console.Clear();
            Console.WriteLine("doubleroduca el primer numero");

            try
            {
                num1 = double.Parse(Console.ReadLine());

                Console.WriteLine("doublerouzca el segundo numero");
                try
                {
                    num2 = double.Parse(Console.ReadLine());

                    Operaciones op = new Operaciones();
                    
                    Console.Clear();
                    Console.WriteLine("La suma es: " +  op.sumar(num1,num2));
                    Console.ReadLine();
                    Console.Clear();
                }
                catch 
                {
                    Console.WriteLine("Debes doubleroducir un numero");
                    Console.ReadLine();
                    Console.Clear();
                    Sumar();
                }
            }
            catch 
            {
                Console.WriteLine("Debes doubleroducir un numero");
                Console.ReadLine();
                Console.Clear();
                Sumar();
            }
        }

        void resta()
        {
            double num1, num2;
            Console.Clear();
            Console.WriteLine("doubleroduca el primer numero");

            try
            {
                num1 = double.Parse(Console.ReadLine());

                Console.WriteLine("doublerouzca el segundo numero");
                try
                {
                    num2 = double.Parse(Console.ReadLine());

                    Operaciones op = new Operaciones();

                    Console.Clear();
                    Console.WriteLine("La resta es: " + op.resta(num1, num2));
                    Console.ReadLine();
                    Console.Clear();
                }
                catch
                {
                    Console.WriteLine("Debes doubleroducir un numero");
                    Console.ReadLine();
                    Console.Clear();
                    Sumar();
                }
            }
            catch
            {
                Console.WriteLine("Debes doubleroducir un numero");
                Console.ReadLine();
                Console.Clear();
                Sumar();
            }


        }

        void multiplicar()
        {
            double num1, num2;
            Console.Clear();
            Console.WriteLine("doubleroduca el primer numero");

            try
            {
                num1 = double.Parse(Console.ReadLine());

                Console.WriteLine("doublerouzca el segundo numero");
                try
                {
                    num2 = double.Parse(Console.ReadLine());

                    Operaciones op = new Operaciones();

                    Console.Clear();
                    Console.WriteLine("La division es: " + op.multiplicar(num1, num2));
                    Console.ReadLine();
                    Console.Clear();
                }
                catch
                {
                    Console.WriteLine("Debes doubleroducir un numero");
                    Console.ReadLine();
                    Console.Clear();
                    Sumar();
                }
            }
            catch
            {
                Console.WriteLine("Debes doubleroducir un numero");
                Console.ReadLine();
                Console.Clear();
                Sumar();
            }


        }

        void dividir()
        {
            double num1, num2;
            Console.Clear();
            Console.WriteLine("doubleroduca el primer numero");

            try
            {
                num1 = double.Parse(Console.ReadLine());

                Console.WriteLine("doublerouzca el segundo numero");
                try
                {
                    num2 = double.Parse(Console.ReadLine());

                    Operaciones op = new Operaciones();

                    Console.Clear();
                    Console.WriteLine("La division es: " + op.dividir(num1, num2));
                    Console.ReadLine();
                    Console.Clear();
                }
                catch
                {
                    Console.WriteLine("Debes doubleroducir un numero");
                    Console.ReadLine();
                    Console.Clear();
                    Sumar();
                }
            }
            catch
            {
                Console.WriteLine("Debes doubleroducir un numero");
                Console.ReadLine();
                Console.Clear();
                Sumar();
            }


        }
    }
}

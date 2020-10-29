using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Operaciones
    {

        public double sumar(double num1,double num2)
        {
            try
            {
                return num1 + num2; 
            }  
            catch
            {
                Console.Clear();
                Console.WriteLine("Debe seleccionar una opcion con su numero");
                Console.ReadLine();
                Console.Clear();
                return 0;
            }
        }
        public double resta(double num1, double num2)
        {
            try
            {
                if (num1 > num2)
                {
                    return num1 - num2;
                }

                else if (num2 > num1)
                {
                    return num2 - num1;
                }


                else if (num2 == num1)
                {
                    return num2 - num1;
                }

                else
                {
                    return num1 - num2;
                }

            }
            catch
            {
                Console.Clear();
                Console.WriteLine("Debe seleccionar una opcion con su numero");
                Console.ReadLine();
                Console.Clear();
                return 0;
            }
        }
        public double multiplicar(double num1, double num2)
        {
            try
            {
                return num1 * num2;
            }
            catch
            {
                Console.Clear();
                Console.WriteLine("Debe seleccionar una opcion con su numero");
                Console.ReadLine();
                Console.Clear();
                return 0;
            }
        }
        public double dividir(double num1, double num2)
        {
            try
            {
                if (num2 == 0)
                {
                    return 0;
                }

                return num1 / num2;
            }
            catch
            {
                Console.Clear();
                Console.WriteLine("Debe seleccionar una opcion con su numero");
                Console.ReadLine();
                Console.Clear();
                return 0;
            }
        }
    }
}

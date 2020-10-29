using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persona
{
    class Persona :  IPersona
    {
        public String nombre { get; set; }

        public int edad { get; set; }

        public String cedula { get; set; }

        public char sexo { get; set; }

        public double peso { get; set; }

        public double altura { get; set; }

        public void calcularIMC(double peso, double altura)
        {
            double pesoIdeal;

           try
           {
                pesoIdeal = peso / altura * 2;

                if(pesoIdeal < 20)
                {
                    Console.WriteLine("Estas casi desnutrido");
                    Console.ReadLine();
                    Console.Clear();
                }

                else if(pesoIdeal >= 20 || pesoIdeal <= 25)
                {
                    Console.WriteLine("Estas por debajo de su peso ideal");
                    Console.ReadLine();
                    Console.Clear();
                }

                else if (pesoIdeal > 25)
                {
                    Console.WriteLine("Estas en sobre peso");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
           catch
           {
                pesoIdeal = 0;
           }
        }

        public bool esMayorDeEdad(int edad)
        {
            if (edad >= 18)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

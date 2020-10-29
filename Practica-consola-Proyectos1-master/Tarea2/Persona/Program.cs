using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persona
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona();

            Console.WriteLine("INTRODUZCA SU NOMBRE");
            persona.nombre = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("INTRODUZCA SU EDAD");
            int.TryParse(Console.ReadLine(),out int edad);
            persona.edad = edad;
            Console.Clear();


            Console.WriteLine("INTRODUZCA SU CEDULA");
            String cedula = Console.ReadLine();

            while(cedula == "" || cedula == null)
            {
              Console.WriteLine("INTRODUZCA SU CEDULA");
              cedula = Console.ReadLine();
            }
            Console.Clear();

            Console.WriteLine("INTRODUZCA SU SEXO CON H O M");
            try
            {
                persona.sexo = char.Parse(Console.ReadLine());
            }
            catch
            {
                persona.sexo = 'H';
            }
            Console.Clear();


            Console.WriteLine("INTRODUZCA SU PESO");
            try
            {
                persona.peso = double.Parse(Console.ReadLine());
            }
            catch
            {
                persona.peso = 0;
            }
            Console.Clear();


            Console.WriteLine("INTRODUZCA SU ALTURA");
            try
            {
                persona.altura = double.Parse(Console.ReadLine());
            }
            catch
            {
                persona.altura = 0;
            }
            Console.Clear();

            persona.calcularIMC(persona.peso,persona.altura);
            
            if(persona.esMayorDeEdad(persona.edad) == true)
            {
                Console.WriteLine("Es mayor de edad");
                Console.ReadLine();
                Console.Clear();
            }
            else
            {
                Console.WriteLine("Es menor de edad");
                Console.ReadLine();
                Console.Clear();
            }

        }
    }
}

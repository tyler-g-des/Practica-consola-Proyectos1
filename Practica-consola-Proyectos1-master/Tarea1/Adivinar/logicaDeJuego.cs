using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adivinar
{
     public class logicaDeJuego
     {
        public static int numeroIntento = 10;

        public int generarNumero()
        {
            int numero = (new Random().Next(1, 100));
            return numero;
        }

        public void jugar(int numeroJugado, int numeroCorrecto)
        {        
            try
            {
                if (numeroJugado == numeroCorrecto)
                {

                   numeroIntento = 10;
                }

                else if(numeroJugado + 5 == numeroCorrecto || numeroJugado - 5 == numeroCorrecto)
                {
                    Console.WriteLine("Esta muy caliente");
                    Console.ReadLine();
                    Console.Clear();
                   numeroIntento--;
                }

                else if (numeroJugado + 10 == numeroCorrecto || numeroJugado - 10 == numeroCorrecto)
                {
                    Console.WriteLine("Esta caliente");
                    Console.ReadLine();
                    Console.Clear();
                   numeroIntento--;

                }

                else if (numeroJugado + 20 == numeroCorrecto || numeroJugado - 20 == numeroCorrecto)
                {
                    Console.WriteLine("Se esta acercando");
                    Console.ReadLine();
                    Console.Clear();
                    numeroIntento--;

                }

                else if (numeroJugado + 30 == numeroCorrecto || numeroJugado - 30 == numeroCorrecto)
                {
                    Console.WriteLine("Estas muy frio");
                    Console.ReadLine();
                    Console.Clear();
                    numeroIntento--;


                }
                else if (numeroJugado + 50 == numeroCorrecto || numeroJugado - 50 == numeroCorrecto)
                {
                    Console.WriteLine("Estas frio");
                    Console.ReadLine();
                    Console.Clear();
                    numeroIntento--;
                }
                else if(numeroIntento == -1 || numeroIntento == -2)
                {
                     numeroIntento = 9;
                }
                else
                {
                    numeroIntento--;
                }

            }
            catch
            {
                Console.WriteLine("Debes introducir un numero");
                Console.ReadLine();
                Console.Clear();

            }
        }

        public void validarJugador()
        {
            if (numeroIntento == 0 || numeroIntento < 0)
            {

                Console.WriteLine("Haz perdido");
                Console.ReadLine();
                Console.Clear();
            }
            else if (numeroIntento == 10)
            {
                Console.WriteLine("FELICIDADES GANASTE");
                Console.ReadLine();
                Console.Clear();

            }
            else
            {
                Console.WriteLine("Continua jugando te quedan " + numeroIntento + " intentos");
                Console.ReadLine();
                Console.Clear();
            }
        }


    }
}

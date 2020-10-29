using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adivinar
{
    class Program
    {
        public static int numeroGenerado;
     

        static void Main(string[] args)
        {

            Program pg = new Program();
            logicaDeJuego lg = new logicaDeJuego();
            numeroGenerado = lg.generarNumero();

            pg.menuPrincipal(numeroGenerado);
        }

        void menuPrincipal(int numeroGenerado)
        {
            int numero;
     
            Console.WriteLine("Inicio del juego, Introduce un numero");
            logicaDeJuego lg = new logicaDeJuego();

            try
            {
                numero = int.Parse(Console.ReadLine());

                while (logicaDeJuego.numeroIntento != 0)
                {
                    lg.jugar(numero, numeroGenerado);
                    lg.validarJugador(); 
                    menuPrincipal(numeroGenerado);
                }
                Console.Clear();
                menuPrincipal(numeroGenerado);

            }
            catch
            {
                Console.WriteLine("Debes introducir un numero");
                Console.ReadLine();
                Console.Clear();
                menuPrincipal(numeroGenerado);
            }
        }

    }
}

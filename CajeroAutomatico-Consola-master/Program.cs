using PrimerParcial.Configuraciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcial
{
    class Program
    {
        private int selMenuPrincipal;
        private int selDipensar;
        ConfiguracionCajero configuracion;

         static void Main(string[] args)
         {
            Program pg = new Program();
            pg.MenuPrincipal();
         }

        void MenuPrincipal()
        {
            Console.WriteLine(" 1. Dispensacion del cajero "  + "\n 2. Retiro dinero");

            try
            {
                selMenuPrincipal = int.Parse(Console.ReadLine());
            }
            catch(Exception) { 
                Console.WriteLine("DEBE INTRODUCIR UNA OPCION VALIDA");
                Console.ReadLine();
                Console.Clear();

                MenuPrincipal();
            }

            switch(selMenuPrincipal)
            {
                case 1:
                    Console.ReadKey();
                    Console.Clear();

                    OpcionesCajero();
                    break;

                case 2:
                    Console.ReadKey();
                    Console.Clear();


                    Console.WriteLine("Introduzca el monto");

                    configuracion = new ConfiguracionCajero();
                    configuracion.configuracionEficiente(Console.ReadLine());
                    Console.ReadKey();
                    Console.Clear();
                    MenuPrincipal();

                    break;
            }
        }

        void OpcionesCajero()
        {
            Console.WriteLine(" 1. Configuracion papeletas 200 y 1000" +
                             "\n 2. Configuracion papeletas 100 y 500" + 
                             "\n 3. Configuracion eficiente ");

            try
            {
                selDipensar = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("DEBE INTRODUCIR UNA OPCION VALIDA");
                Console.ReadLine();
                Console.Clear();

                OpcionesCajero();
            }

            switch (selDipensar)
            {
                case 1:
                    Console.Clear();

                    Console.WriteLine("Introduzca el monto");

                    configuracion = new ConfiguracionCajero();
                    configuracion.configurarCajero(Console.ReadLine(),200,1000);
                    Console.ReadLine();
                    Console.Clear();
                    MenuPrincipal();
                    break;

                case 2:
                    Console.Clear();

                    Console.WriteLine("Introduzca el monto");

                    configuracion = new ConfiguracionCajero();
                    configuracion.configurarCajero(Console.ReadLine(), 100, 500);
                    Console.ReadLine();
                    Console.Clear();
                    MenuPrincipal();
                    break;


                case 3:
                    Console.ReadKey();
                    Console.Clear();


                    Console.WriteLine("Introduzca el monto");

                    configuracion = new ConfiguracionCajero();
                    configuracion.configuracionEficiente(Console.ReadLine());
                    Console.ReadKey();
                    Console.Clear();
                    MenuPrincipal();
                    break;
            }

        }
    }
}

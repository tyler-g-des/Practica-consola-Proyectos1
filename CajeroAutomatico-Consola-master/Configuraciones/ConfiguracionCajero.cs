using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcial.Configuraciones
{
    class ConfiguracionCajero
    {
        public void configurarCajero(String monto, int primeraPapeleta, int segudoPapeleta)
        {
            int montoValidado = 0;
            int conteo = 0;
            int conteo1 = 0;
            

            montoValidado = validarMonto(monto);

           
           if (montoValidado % segudoPapeleta == 0)
           {
             
                while (montoValidado != 0)
                {           
                    montoValidado = montoValidado - segudoPapeleta;
                    conteo++;
                }
                Console.WriteLine("papeletas de " +segudoPapeleta+ ":" + conteo);
                Console.ReadKey();    
           }

            else
            {        
                while (montoValidado != 0)
                {
                   

                    if(montoValidado <= segudoPapeleta)
                    {
                       montoValidado = montoValidado - primeraPapeleta;
                        conteo1++;
                    }


                    if (montoValidado >= segudoPapeleta)
                    {
                        montoValidado = montoValidado - segudoPapeleta;
                        conteo++;
                    }

                    if (montoValidado <  0)
                    {
                        Console.WriteLine("El cajero no puede devolver esta cantidad en papeletas de 200 y 1000");
                        Console.ReadKey();
                        montoValidado = 0;
                    }

                }

                Console.WriteLine("papeletas de " + segudoPapeleta + ":" + conteo);
                Console.WriteLine("papeletas de " + primeraPapeleta + ":" + conteo1);
                Console.ReadKey();
            }

        }

        public void configuracionEficiente(String monto)
        {
            int montoValidado = 0;
      
            int[] conteos = new int[7];

   
            montoValidado = validarMonto(monto);

            while (montoValidado != 0)
            {

                if (montoValidado >= 2000)
                {
                    montoValidado = montoValidado - 2000;
                    conteos[1]++;
                }

                else if (montoValidado >= 1000)
                {
                    montoValidado = montoValidado - 1000;
                    conteos[2]++;
                }

                else if (montoValidado >= 500)
                {
                        montoValidado = montoValidado - 500;
                        conteos[3]++;

                }

                else if (montoValidado >= 200)
                {

                        montoValidado = montoValidado - 200;
                        conteos[4]++;

                }

                else if (montoValidado >= 100)
                {                
                        montoValidado = montoValidado - 100;
                        conteos[5]++;

                }

                else if (montoValidado >= 50)
                {
                        montoValidado = montoValidado - 50;
                        conteos[6]++;
                }
                
                else
                {
                    Console.WriteLine("El cajero no puede devolver esta cantidad en papeletas");
                }

            }

            for (int i = 1; i < 7; i++)
            {
                int[] valores =  {0,2000,1000,500,200,100,50};

                if(conteos[i] != 0)
                {
                    Console.WriteLine("Papeletas de " + valores[i].ToString() + ": " + conteos[i].ToString());
                }
            }
            
        }


        int validarMonto(String monto)
        {
            int montoValidado=0;

            try
            {
                montoValidado = int.Parse(monto);
                return montoValidado;
            }

            catch(Exception)
            {
                Console.WriteLine("Debe introducir un monto real sin decimales");
                Console.ReadLine();
                montoValidado = 0;
            }

            return montoValidado;
        }

    }
}

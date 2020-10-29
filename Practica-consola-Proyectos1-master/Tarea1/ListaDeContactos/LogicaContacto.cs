using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeContactos
{
    class LogicaContacto
    {
        private static List<Contacto> listaContactos = new List<Contacto>();

        public void AgregarContacto(String nombre, int numero)
        {

            try
            {
                listaContactos.Add(new Contacto { nombre = nombre, numero = numero });
                Console.WriteLine("Guardado de manera exitosa !!");
                Console.ReadLine();
                Console.Clear();
            }
            catch
            {
                Console.WriteLine("Debes introducir el nombre y numero");
                Console.ReadLine();
                Console.Clear();

            }
        }

        public void Eliminar(int numero)
        {

            try
            {
                listaContactos.RemoveAt(numero - 1);
                Console.WriteLine("Eliminado de manera exitosa !!");
                Console.ReadLine();
                Console.Clear();
            }
            catch
            {
                Console.WriteLine("Debes introducir numero de orden del contacto que deseas eleminar");
                Console.ReadLine();
                Console.Clear();
            }
        }

        public void Mostrar()
        {
            int conteo = 1;
            foreach (var item in listaContactos)
            {
                Console.WriteLine(conteo + ". " + "Nombre: "+ item.nombre + ", "+ " Numero: " + item.numero);
                conteo++;
                if (item.nombre == null)
                {
                    Console.WriteLine("Debes agregar contactos");
                    Console.ReadLine();
                }

            }

            Console.ReadLine();
            Console.Clear();
        }

        public void Edita(String nombreContacto, String nombreNuevo , int numero)
        {
            try
            {

                Contacto contacto = listaContactos.Single(s => s.nombre == nombreContacto);

                foreach (var item in listaContactos)
                {
                    if(item.Equals(contacto))
                    {
                        item.nombre = nombreNuevo;
                        item.numero = numero;
                        break;
                    }
                    
                }

                Console.WriteLine("Editado de manera exitosa");
                Console.ReadLine();
                Console.Clear();
            }
            catch
            {
                Console.WriteLine("El nombre que deseas cambiar no existe");
                Console.ReadLine();
                Console.Clear();
            }
        }

    }
}

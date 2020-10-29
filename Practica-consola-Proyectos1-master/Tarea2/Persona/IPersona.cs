using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persona
{
    interface IPersona
    {
        void calcularIMC(double peso, double altura);

        bool esMayorDeEdad(int edad);

    }
}

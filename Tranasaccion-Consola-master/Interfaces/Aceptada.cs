using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practica;

namespace Practica.Interfaces
{
    public interface Aceptada
    {
        void AgregadasTransaccionesCanceladas(List<Transaccion> transacciones);

        void MostrarTransaccionesCanceladas();
    }
}

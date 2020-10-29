using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.Interfaces
{
    public interface Rechazada
    {
       void TransaccionesEliminada(List<Transaccion> transacciones);

        void MostrarTransaccionesEliminada();
    }
}

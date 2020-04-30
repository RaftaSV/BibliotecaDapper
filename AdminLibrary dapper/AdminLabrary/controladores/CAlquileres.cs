using AdminLabrary.entidades;
using AdminLabrary.modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminLabrary.controladores
{
    class CAlquileres

    {
        MAlquileres a = new MAlquileres();
        public List<Alquileres> Listado()
        {
            return a.Listado();
        }
    }
}

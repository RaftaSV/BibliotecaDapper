using AdminLabrary.entidades;
using AdminLabrary.modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminLabrary.controladores
{
    class CAdministradores
    {
        MAdministradores MAdministrador = new MAdministradores();
        public List<Administradores> Listado()
        {
            return MAdministrador.Listado();
        }
        internal void guardar(Administradores c)
        {
            MAdministrador.guardar(c);
        }
    }
}

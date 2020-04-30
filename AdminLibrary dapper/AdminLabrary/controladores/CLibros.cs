using AdminLabrary.entidades;
using AdminLabrary.modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminLabrary.controladores
{
    class CLibros
    {
        MLibros MLibros = new MLibros();
        public List<Libros> Listado()
        {
            return MLibros.Listado();
        }
        internal void guardar(Libros c)
        {
            MLibros.guardar(c);
        }
    }
}

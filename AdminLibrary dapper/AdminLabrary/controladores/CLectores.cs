using AdminLabrary.entidades;
using AdminLabrary.modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminLabrary.controladores
{
    class CLectores
    {
        MLectores MLectores = new MLectores();
        public List<Lectores> Listado()
        {
            return MLectores.Listado();
        }
        internal void guardar(Lectores c) { 
            MLectores.guardar(c);
        }
       

       

    }

}

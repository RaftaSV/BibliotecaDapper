using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdminLabrary.conexion;
using AdminLabrary.entidades;
using Dapper;

namespace AdminLabrary.modelos
{
    class MAlquileres
    {
        public List<Alquileres> Listado()
        {
            IDbConnection con = Conexion.Conectar();
            String consulta = "select *from Alquileres";
            List<Alquileres> listado = new List<Alquileres>();
            con.Open();
            listado = con.Query<Alquileres>(consulta).ToList();
            con.Close();
            return listado;

        }  
    }
}

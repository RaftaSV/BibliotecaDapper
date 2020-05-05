using AdminLabrary.conexion;
using AdminLabrary.entidades;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminLabrary.modelos
{
    class MAutores
    {
        public List<entidades.Autores> Listado()
        {
            IDbConnection con = Conexion.Conectar();
            String consulta = "Select * from Autores";
            List<entidades.Autores> listado = new List<entidades.Autores>();
            con.Open();
            listado = con.Query<entidades.Autores>(consulta).ToList();
            con.Close();
            return listado;
        }

       

        internal void guardar(entidades.Autores c)
        {
            IDbConnection con = Conexion.Conectar();
            String consulta = "sp_insertarAutores";
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@Nombre", c.Nombre, DbType.String);
            parametros.Add("@fecha_nacimiento", c.fecha_nacimiento, DbType.Date);
            parametros.Add("@Nacionalidad", c.Nacionalidad, DbType.String);
            con.Execute(consulta, parametros, commandType: CommandType.StoredProcedure);
            con.Close();

        }
    }
}

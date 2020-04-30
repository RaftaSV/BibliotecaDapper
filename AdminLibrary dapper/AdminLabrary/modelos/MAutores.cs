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
        public List<Autores> Listado()
        {
            IDbConnection con = Conexion.Conectar();
            String consulta = "Select * from Autores";
            List<Autores> listado = new List<Autores>();
            con.Open();
            listado = con.Query<Autores>(consulta).ToList();
            con.Close();
            return listado;
        }

        internal void guardar(Autores c)
        {
            throw new NotImplementedException();
        }

        internal void Guardar(Autores c)
        {
            IDbConnection con = Conexion.Conectar();
            String consulta = "sp_MostrarAutores";
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@Id_autor", c.Id_autor, DbType.Int32);
            parametros.Add("@Nombre", c.Nombre, DbType.String);
            parametros.Add("@fecha_nacimiento", c.fecha_nacimiento, DbType.Date);
            parametros.Add("@Nacionalidad", c.Nacionalidad, DbType.String);

            con.Execute(consulta, parametros, commandType: CommandType.StoredProcedure);
            con.Close();
        }
    }
}

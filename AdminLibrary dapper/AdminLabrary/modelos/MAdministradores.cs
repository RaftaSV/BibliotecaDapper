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
    class MAdministradores
    {
        public List<Administradores> Listado()
        {
            IDbConnection con = Conexion.Conectar();
            String consulta = "Select * from Administradores";
            List<Administradores> listado = new List<Administradores>();
            con.Open();
            listado = con.Query<Administradores>(consulta).ToList();
            con.Close();
            return listado;
        }
        internal void guardar(Administradores c)
        {
            IDbConnection con = Conexion.Conectar();
            String consulta = "sp_InsertarAdministradores";
            DynamicParameters parametros = new DynamicParameters();
            
            parametros.Add("@Usuario", c.Usuario, DbType.String);
            parametros.Add("@Contraseña", c.Contraseña, DbType.String);
            parametros.Add("@Lector", c.lector, DbType.Int32);


            con.Execute(consulta, parametros, commandType: CommandType.StoredProcedure);
            con.Close();
        }
    }
}

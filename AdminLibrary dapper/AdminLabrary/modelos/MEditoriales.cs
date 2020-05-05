using AdminLabrary.conexion;
using AdminLabrary.controladores;
using AdminLabrary.entidades;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace AdminLabrary.modelos
{
    class MEditoriales
    {
        public List<entidades.Editoriales> Listado()
        {
            IDbConnection con = Conexion.Conectar();
            String consulta = "Select * from Editoriales";
            List<entidades.Editoriales> listado = new List<entidades.Editoriales>();
            con.Open();
            listado = con.Query<entidades.Editoriales>(consulta).ToList();
            con.Close();
            return listado;
        }
        internal void guardar(entidades.Editoriales c)
        {
            IDbConnection con = Conexion.Conectar();
            String consulta = "sp_InsertarEditoriales";
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@Editorial", c.Editorial, DbType.String);
            parametros.Add("@Fundada", c.Fundada, DbType.Date);
            parametros.Add("@Direccion", c.Direccion, DbType.String);
            con.Execute(consulta, parametros, commandType: CommandType.StoredProcedure);
            con.Close();
        }
    }
}

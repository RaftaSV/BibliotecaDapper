﻿using AdminLabrary.conexion;
using AdminLabrary.controladores;
using AdminLabrary.entidades;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;


namespace AdminLabrary.modelos
{
    class MLibros
    {
        public List<Libros> Listado()
        {
            IDbConnection con = Conexion.Conectar();
            String consulta = "Select * from Libros";
            List<Libros> listado = new List<Libros>();
            con.Open();
            listado = con.Query<Libros>(consulta).ToList();
            con.Close();
            return listado;
        }
        internal void guardar(Libros c)
        {
            IDbConnection con = Conexion.Conectar();
            String consulta = "sp_InsertarLibros";
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@Nombre", c.Nombre, DbType.String);
            parametros.Add("@cantidad", c.cantidad, DbType.Int32);
            parametros.Add("@Año", c.Año, DbType.Date);
            parametros.Add("@Numero_edicion", c.Numero_edicion, DbType.Int32);
            parametros.Add("@Id_autor", c.Id_autor, DbType.Int32);
            parametros.Add("@Id_Editorial", c.Id_Editorial, DbType.Int32);
            parametros.Add("@Id_categoria", c.Id_categoria, DbType.Int32);

            con.Execute(consulta, parametros, commandType: CommandType.StoredProcedure);
            con.Close();
        }
    }
}

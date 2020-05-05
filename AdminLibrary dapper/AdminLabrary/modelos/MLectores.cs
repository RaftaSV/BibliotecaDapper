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
    class MLectores
    {

        public List<entidades.Lectores> Listado()
        {
            IDbConnection con = Conexion.Conectar();
            String consulta = "Select * from Lectores";
            List<entidades.Lectores> listado = new List<entidades.Lectores>();
            con.Open();
            listado = con.Query<entidades.Lectores>(consulta).ToList();
            con.Close();
            return listado;
        }
        internal void guardar(entidades.Lectores c)
        {
            IDbConnection con = Conexion.Conectar();
            String consulta = "sp_InsertarLectores";
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@Nombres", c.Nombres, DbType.String);
            parametros.Add("@Apellidos", c.Apellidos, DbType.String);
            con.Execute(consulta, parametros, commandType: CommandType.StoredProcedure);
            con.Close();
        }
        
        
        

    }
}
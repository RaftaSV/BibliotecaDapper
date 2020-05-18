﻿using AdminLabrary.controladores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminLabrary.formularios.insert_update
{
    public partial class frmActualizarCategoria : Form
    {
        public entidades.Categorias C = new entidades.Categorias();
        public frmActualizarCategoria(entidades.Categorias C)
        {
            InitializeComponent();
            this.C = C;
        }

        private void frmActualizarCategoria_Load(object sender, EventArgs e)
        {
            categoriasBindingSource.DataSource = C; 

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            entidades.Categorias categoria = new entidades.Categorias();
            categoriasBindingSource.EndEdit();
            categoria = (entidades.Categorias)categoriasBindingSource.Current;
            CCategorias C = new CCategorias();
            C.Actualizar(categoria);
            this.Close();
        }
    }
}

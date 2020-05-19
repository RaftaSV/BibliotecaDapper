﻿using AdminLabrary.entidades;
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
    public partial class frmActualizarEditorial : Form
    {
        public Editoriales C = new Editoriales();


        public frmActualizarEditorial(Editoriales C)
        {
            InitializeComponent();
            this.C = C;

           

           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            entidades.Editoriales editorial = new entidades.Editoriales();
            editorialesBindingSource.EndEdit();
            editorial = (entidades.Editoriales)editorialesBindingSource.Current;
            controladores.CEditoriales c = new controladores.CEditoriales();
            c.actualizar(editorial);
            this.Close();


        }

        private void FrmActualizarEditorial_Load(object sender, EventArgs e)
        {
            editorialesBindingSource.DataSource = C;
        }
    }
}

﻿using AdminLabrary.controladores;
using AdminLabrary.formularios.principales;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminLabrary.formularios
{
    public partial class frmAlquileres : Form
    {
        public frmAlquileres()
        {
            InitializeComponent();
        }

        private void frmAlquileres_Load(object sender, EventArgs e)
        {
            CAlquileres f = new CAlquileres();
            alquileresDataGridView.DataSource = f.Listado();
            CLectores l = new CLectores();
            lectoresBindingSource.DataSource = l.Listado();
            CLibros li = new CLibros();
            librosBindingSource.DataSource = li.Listado();
            CAdministradores a = new CAdministradores();
            administradoresBindingSource.DataSource = a.Listado();
            administradoresBindingSource1.DataSource = a.Listado();

        
        }

        private void alquileresDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

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
            CargarDatos();
        }

        private void alquileresDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void CargarDatos()
        {
            CAlquileres f = new CAlquileres();
            alquileresPendientesBindingSource.DataSource = f.Listadop();
            CLectores lec = new CLectores();
            CLibros libros = new CLibros();
            CAdministradores admin = new CAdministradores();
            librosBindingSource.DataSource = libros.Listado();
            lectoresBindingSource.DataSource = lec.Listado();
            administradoresBindingSource.DataSource = admin.Listado();


        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            btnRecibir.Enabled = false;
          
            frmPrincipal.alquiler.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmPrincipal.recibir.a = (entidades.AlquileresPendientes)alquileresPendientesBindingSource.Current;
            frmPrincipal.recibir.txtLibro.Text = alquileresDataGridView.CurrentRow.Cells[2].FormattedValue.ToString();
            frmPrincipal.recibir.txtLector.Text = alquileresDataGridView.CurrentRow.Cells[1].FormattedValue.ToString();
            frmPrincipal.recibir.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            btnNuevo.Enabled = false;
            frmPrestamosFinalizados prestamos = new frmPrestamosFinalizados();
            frmLogin.f.MostrarPanel(prestamos);
        }

        private void alquileresDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnNuevo.Enabled = true;
        }

        private void btnRecibir_Click(object sender, EventArgs e)
        {
            

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            btnRecibir.Enabled = false;
            frmPrincipal.recibir.a = (entidades.AlquileresPendientes)alquileresPendientesBindingSource.Current;
            frmPrincipal.recibir.txtLibro.Text = alquileresDataGridView.CurrentRow.Cells[2].FormattedValue.ToString();
            frmPrincipal.recibir.txtLector.Text = alquileresDataGridView.CurrentRow.Cells[1].FormattedValue.ToString();
            frmPrincipal.recibir.ShowDialog();

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            btnRecibir.Enabled = false;
            frmPrestamosFinalizados prestamos = new frmPrestamosFinalizados();
            frmLogin.f.MostrarPanel(prestamos);
        }

        private void alquileresDataGridView_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            btnRecibir.Enabled = true;
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://desktop-bgitd0d/ReportServer/Pages/ReportViewer.aspx?%2fPENDIENTES+DE+ENTREGA%2fpendientes+de+entrega&rs:Command=Render");
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://localhost/ReportServer/Pages/ReportViewer.aspx?%2fPENDIENTES+DE+ENTREGA%2ffinalizado&rs:Command=Render");
        }
    }
}

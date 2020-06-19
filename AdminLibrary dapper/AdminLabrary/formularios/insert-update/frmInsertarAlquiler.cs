using AdminLabrary.controladores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdminLabrary.formularios.frmBuscar;
using AdminLabrary.conexion;
using AdminLabrary.modelos;

namespace AdminLabrary.formularios.principales
{
    public partial class frmInsertarAlquiler : Form
    {
        public int id;
        public frmInsertarAlquiler()
        {
            InitializeComponent();
            
        }

        private void frmInsertarAlquiler_Load(object sender, EventArgs e)
        {
            limpiarbinding();


        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtLector.Text != "" && txtLibro.Text != "" && txtUsuario.Text != "")
            {

                entregadoTextBox.Text = id.ToString();
                alquileresBindingSource.EndEdit();
                entidades.Alquileres alq = new entidades.Alquileres();
                alq = (entidades.Alquileres)alquileresBindingSource.Current;
                CAlquileres cAlq = new CAlquileres();
                cAlq.Guardar(alq);
                alquileresBindingSource.Clear();
                txtLector.Text = "";
                txtLibro.Text = "";
                frmPrincipal.alquileres.CargarDatos();
                this.Close();

            }
            else
            {
                MessageBox.Show("Todos los campos son obligatorios");
            }
        }

     
      

        private void btnSelecLIbro_Click(object sender, EventArgs e)
        {
            frmBuscarlibro buscarlibro = new frmBuscarlibro();
            buscarlibro.cargar();
            LinqL.Libros.Clear();
            buscarlibro.ShowDialog();
        }
       
        public void limpiarbinding()
        {
            alquileresBindingSource.MoveLast();
            alquileresBindingSource.AddNew();
        }

        
        private void btnSelecLec_Click(object sender, EventArgs e)
        {
            frmPrincipal.buscarlector.lector.Clear();
            frmPrincipal.buscarlector.lector1.Clear();

            frmPrincipal.buscarlector.enviar = 1;
            frmPrincipal.buscarlector.ShowDialog();
            
        }

       
    }
}

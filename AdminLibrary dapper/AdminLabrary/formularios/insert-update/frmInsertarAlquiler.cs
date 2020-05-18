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

namespace AdminLabrary.formularios.principales
{
    public partial class frmInsertarAlquiler : Form
    {
        
        public frmInsertarAlquiler()
        {
            InitializeComponent();
            
        }

        private void frmInsertarAlquiler_Load(object sender, EventArgs e)
        {
           
         
            CargarID();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtLector.Text != "" && txtLibro.Text != "" && txtUsuario.Text != "")
            {
                
                    alquileresBindingSource.EndEdit();
                    entidades.Alquileres alq = new entidades.Alquileres();
                    alq = (entidades.Alquileres)alquileresBindingSource.Current;
                    CAlquileres cAlq = new CAlquileres();
                    cAlq.Guardar(alq);
                    alquileresBindingSource.Clear();
                    txtLector.Text = "";
                    txtLibro.Text = "";
                    frmPrincipal.alquileres.CargarDatos();
                
            
              
            
        }
}
     
        public  frmBuscarlibro buscarlibro = new frmBuscarlibro();

        private void btnSelecLIbro_Click(object sender, EventArgs e)
        {
            CargarID();
            buscarlibro.ShowDialog();
        }
        public void CargarID()
        {
            
            using (BibliotecaEntities1 db = new BibliotecaEntities1())
            {
                Administradores admi = new Administradores();
                admi = db.Administradores.Where(busca => busca.Usuario == txtUsuario.Text).First();

                entregadoTextBox.Text = admi.Id_Admin.ToString();
                
            }
        }
        public void limpiarbinding()
        {
            alquileresBindingSource.MoveLast();
            alquileresBindingSource.AddNew();
        }

        public frmBuscarLector lector = new frmBuscarLector();
        private void btnSelecLec_Click(object sender, EventArgs e)
        {
            limpiarbinding();
            CargarID();
            lector.enviar = 1;
            lector.ShowDialog();
            
        }

        private void id_libroTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

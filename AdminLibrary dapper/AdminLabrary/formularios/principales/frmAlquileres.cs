using AdminLabrary.controladores;
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
            frmPrincipal.alquiler.CargarID();
            frmPrincipal.alquiler.ShowDialog();
        }
    }
}

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
using AdminLabrary.formularios.insert_update;
namespace AdminLabrary.formularios.principales
{
    public partial class frmAdministradores : Form
    {
        public frmAdministradores()
        {
            InitializeComponent();
        }
        

        private void Carreras_Load(object sender, EventArgs e)
        {
            CargarDatos();
            
        }
        public void CargarDatos()
        {
            CAdministradores C = new CAdministradores();
            CLectores l = new CLectores();
            lectoresBindingSource.DataSource = l.Listado();
            administradoresBindingSource.DataSource = C.Listado();
        }
        public static frmInsertarAdministrador admin = new frmInsertarAdministrador();
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            admin.ShowDialog();
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
        }
      
       public frmActualizarAdmin admi = new frmActualizarAdmin();
        private void btnEditar_Click(object sender, EventArgs e)
        {
            entidades.Administradores Ad = new entidades.Administradores();
            Ad = (entidades.Administradores)administradoresBindingSource.Current;
            string Nombre = administradoresDataGridView.CurrentRow.Cells[3].FormattedValue.ToString();
            admi.txtLecNombre.Text = Nombre;
            admi.A = Ad;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            admi.btnActualizar.Enabled = true;
            admi.btnEliminar.Enabled = false;
            admi.btnBuscar.Enabled = true;
            admi.ShowDialog();
        }
       

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            entidades.Administradores Ad = new entidades.Administradores();
            Ad = (entidades.Administradores)administradoresBindingSource.Current;
            string Nombre = administradoresDataGridView.CurrentRow.Cells[3].FormattedValue.ToString();
            admi.txtLecNombre.Text = Nombre;
            admi.A = Ad;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            admi.btnActualizar.Enabled = false;
            admi.btnEliminar.Enabled = true;
            admi.btnBuscar.Enabled = false;
            admi.ShowDialog();
        }

        private void administradoresDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEditar.Enabled = true;
            btnEliminar.Enabled = true;
           
        }

        private void administradoresDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

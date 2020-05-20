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
       
        private void btnEditar_Click(object sender, EventArgs e)
        {
          entidades.Administradores Ad = new entidades.Administradores();
            frmActualizarAdmin admi = new frmActualizarAdmin(Ad);  
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            admi.ShowDialog();
        }
       

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;        
        }

        private void administradoresDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEditar.Enabled = true;
            btnEliminar.Enabled = true;
        }
    }
}

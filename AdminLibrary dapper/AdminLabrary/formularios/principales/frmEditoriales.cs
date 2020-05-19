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
    public partial class frmEditoriales : Form
    {
        public frmEditoriales()
        {
            InitializeComponent();
        }

        private void FpEditoriales_Load(object sender, EventArgs e)
        {
            CargarDatos();        
        }

       public void CargarDatos()
        {

            CEditoriales c = new CEditoriales();
            editorialesBindingSource.DataSource = c.Listado();

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmInsertarEditorial f = new frmInsertarEditorial();
            f.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            entidades.Editoriales c = new entidades.Editoriales();
            c = (entidades.Editoriales)editorialesBindingSource.Current;
            frmActualizarEditorial cat = new frmActualizarEditorial();
        }
    }
}
 
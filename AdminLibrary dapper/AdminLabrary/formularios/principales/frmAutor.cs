using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdminLabrary.controladores;
using AdminLabrary.formularios.insert_update;

namespace AdminLabrary.formularios.principales
{
    public partial class frmAutor : Form
    {
        public frmAutor()
        {
            InitializeComponent();
        }

        private void FpAutor_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }
        public void CargarDatos()
        {
            CAutores c = new CAutores();
            autoresBindingSource.DataSource = c.Listado();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmInsertarAutores f = new frmInsertarAutores();
            f.ShowDialog();
        }
    }
}

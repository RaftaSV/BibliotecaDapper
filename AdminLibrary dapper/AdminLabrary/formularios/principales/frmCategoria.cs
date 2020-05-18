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
    public partial class frmCategoria : Form
    {
        public frmCategoria()
        {
            InitializeComponent();
        }

        private void FpCategoria_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }
        public void CargarDatos()
        {
            CCategorias c = new CCategorias();
            categoriasBindingSource.DataSource = c.Listado();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmInsertarCategoria f = new frmInsertarCategoria();
            f.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            entidades.Categorias c = new entidades.Categorias();
            c  = (entidades.Categorias)categoriasBindingSource.Current;
            frmActualizarCategoria cat = new frmActualizarCategoria(c);
            cat.ShowDialog();

        }
    }
}

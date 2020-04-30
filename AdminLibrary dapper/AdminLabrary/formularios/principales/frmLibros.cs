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

namespace AdminLabrary.formularios.principales
{
    public partial class frmLibros : Form
    {
        public frmLibros()
        {
            InitializeComponent();
        }

        private void fpLibros_Load(object sender, EventArgs e)
        {

            CEditoriales ed = new CEditoriales();
            CAutores au = new CAutores();
            CCategorias ca = new CCategorias();
            CLibros li = new CLibros();

            editorialesBindingSource.DataSource = ed.Listado();
            autoresBindingSource.DataSource = au.Listado();
            categoriasBindingSource.DataSource = ca.Listado();
            librosBindingSource.DataSource = li.Listado();

        }

        private void librosDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

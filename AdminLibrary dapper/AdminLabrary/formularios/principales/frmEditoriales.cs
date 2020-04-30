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
            //// TODO: esta línea de código carga datos en la tabla 'bibliotecaDataSet.Editoriales' Puede moverla o quitarla según sea necesario.
            //this.editorialesTableAdapter.Fill(this.bibliotecaDataSet.Editoriales);

            CEditoriales c = new CEditoriales();
            editorialesBindingSource.DataSource = c.Listado();
                
                
                
        }

        private void editorialesBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}

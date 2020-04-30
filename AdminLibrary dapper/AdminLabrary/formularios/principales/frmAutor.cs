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
    public partial class frmAutor : Form
    {
        public frmAutor()
        {
            InitializeComponent();
        }

        private void FpAutor_Load(object sender, EventArgs e)
        {

            //// TODO: esta línea de código carga datos en la tabla 'bibliotecaDataSet.Autores' Puede moverla o quitarla según sea necesario.
            //this.autoresTableAdapter.Fill(this.bibliotecaDataSet.Autores);

            CAutores c = new CAutores();
            autoresBindingSource.DataSource = c.Listado();

        }

       
    }
}

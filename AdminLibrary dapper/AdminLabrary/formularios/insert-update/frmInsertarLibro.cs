using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdminLabrary.entidades;
using AdminLabrary.controladores;
using AdminLabrary.formularios.principales;
using AdminLabrary.formularios.frmBuscar;

namespace AdminLabrary.formularios.insert_update
{
    public partial class frmInsertarLibro : Form
    {
        public frmInsertarLibro()
        {
            InitializeComponent();
        }
        public string id_A;
        public string id_Ed;
        private void frmInsertarLibro_Load(object sender, EventArgs e)
        {
            librosBindingSource.MoveLast();
            librosBindingSource.AddNew();
            añoDateTimePicker.Text = DateTime.Now.ToString("yyyy - MM - dd");
            CCategorias categorias = new CCategorias();            
            categoriasBindingSource.DataSource = categorias.Listado();
          
        }

        private void btnGuardar_Click(object sender, EventArgs e )
        {
            if (txtAutor.Text!=""&& txtEditorial.Text!=""&& id_autorTextBox.Text!=""&&   int.Parse(cantidadTextBox.Text)>0 && añoDateTimePicker != null)
            {
                id_autorTextBox.Text = id_A;
                id_EditorialTextBox.Text = id_Ed;
                CLibros li = new CLibros();
                Libros libro = new Libros();
                librosBindingSource.EndEdit();
                libro = (Libros)librosBindingSource.Current;
                li.guardar(libro);
                librosBindingSource.MoveLast();
                librosBindingSource.AddNew();
                txtAutor.Text = "";
                txtEditorial.Text = "";
                id_A = "";
                id_Ed = "";
                frmPrincipal.libros.CargarDatos();

                this.Close();

            }
            else
            {
                MessageBox.Show("Todos los Campos son obligatorios");
            }
           
   
        }

        private void btnAutor_Click(object sender, EventArgs e)
        {
            frmBuscarAutor f = new frmBuscarAutor();
            f.Enviar = 1;
            id_EditorialTextBox.Text = id_Ed;
            f.ShowDialog();
        }

        private void btnEditorial_Click(object sender, EventArgs e)
        {
            frmBuscarEditorial f = new frmBuscarEditorial();
            id_autorTextBox.Text = id_A;
            f.enviar = 1;
            f.ShowDialog();
        }

        private void id_EditorialLabel_Click(object sender, EventArgs e)
        {

        }

        private void frmInsertarLibro_FormClosing(object sender, FormClosingEventArgs e)
        {
            txtAutor.Text = "";
            txtEditorial.Text = "";
            id_A = "";
            id_Ed = "";
        }
    }
}

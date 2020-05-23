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

namespace AdminLabrary.formularios.insert_update
{
    public partial class frmInsertarLibro : Form
    {
        public frmInsertarLibro()
        {
            InitializeComponent();
        }

        private void frmInsertarLibro_Load(object sender, EventArgs e)
        {
            librosBindingSource.MoveLast();
            librosBindingSource.AddNew();
            CAutores autores = new CAutores();
            CCategorias categorias = new CCategorias();
            CEditoriales editoriales = new CEditoriales();
            editorialesBindingSource.DataSource = editoriales.Listado();
            categoriasBindingSource.DataSource = categorias.Listado();
            autoresBindingSource.DataSource = autores.Listado();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (int.Parse(cantidadTextBox.Text)>0)
            {
                CLibros li = new CLibros();
                Libros libro = new Libros();
                libro = (Libros)librosBindingSource.Current;
                li.guardar(libro);
                librosBindingSource.Clear();
                frmPrincipal.libros.CargarDatos();
                MessageBox.Show("libro guardado exitosamentes");




            }
            else
            {
                MessageBox.Show("Todos los Campos son obligatorios");
            }
            
            

        }
    }
}

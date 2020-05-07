using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdminLabrary.conexion;
using AdminLabrary.formularios.principales;

namespace AdminLabrary.formularios.frmBuscar
{
    public partial class frmBuscarlibro : Form
    {
        public frmBuscarlibro()
        {
            InitializeComponent();
        }

        private void frmBuscarlibro_Load(object sender, EventArgs e)
        {
            filtro();
        }
        public void filtro()
        {
            using (BibliotecaEntities1 db = new BibliotecaEntities1())
            {
                string nombre = txtBuscar.Text;
                var lista = from libros in db.Libros
                            from auto in db.Autores
                            from cat in db.Categorias
                            where libros.Id_categoria == cat.Id_categoria
                            && libros.Id_autor == auto.Id_autor
                            && libros.Nombre.Contains(nombre)
                            && libros.cantidad>0
                            select new
                            {
                                ID = libros.Id_libro,
                                LIBRO = libros.Nombre,
                                CANTIDAD = libros.cantidad,
                                AUTOR = auto.Nombre,
                                CATEGORIA = cat.Categoria

                            };
                dgvLibros.DataSource = lista.ToList();
            }

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            filtro();
        }

        private void dgvLibros_DoubleClick(object sender, EventArgs e)
        {
            seleccionar();
        }
        void seleccionar()
        {
            string libro = dgvLibros.CurrentRow.Cells[1].Value.ToString();
            string id = dgvLibros.CurrentRow.Cells[0].Value.ToString();
            frmPrincipal.alquiler.txtLibro.Text = libro;
            frmPrincipal.alquiler.id_libroTextBox.Text = id;
            this.Close();
        }

        

        private void dgvLibros_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                seleccionar();
            }
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}

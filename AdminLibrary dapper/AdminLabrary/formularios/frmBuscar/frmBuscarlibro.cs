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
using AdminLabrary.controladores;
using AdminLabrary.formularios.principales;

namespace AdminLabrary.formularios.frmBuscar
{
    public partial class frmBuscarlibro : Form
    {
        public frmBuscarlibro()
        {
            InitializeComponent();
        }

         public  List<entidades.Libros> Libros = new List<entidades.Libros>();
        private void frmBuscarlibro_Load(object sender, EventArgs e)
        {

            cargarLista();
            filtro();
        }

        void cargarLista()
        {
            CLibros cLibros = new CLibros();
            librosBindingSource.DataSource = cLibros.Listado();
            foreach (DataGridViewRow i in dgvLibros.Rows)
            {
                int id = int.Parse(i.Cells[0].Value.ToString());
                int cantidad = int.Parse(i.Cells[2].Value.ToString());
                Libros.Add(new entidades.Libros { Id_libro = id, Nombre = i.Cells[1].Value.ToString(), cantidad = cantidad });
            }

        }
        public void filtro()
        {
            string nombre = txtBuscar.Text;
                var lista = from libros in Libros
                           
                            where libros.Nombre.Contains(nombre)
                            && libros.cantidad>0
                            select new
                            {
                                Id_libro = libros.Id_libro,
                                Nombre = libros.Nombre,
                                CANTIDAD = libros.cantidad,
                            };
                dgvLibros.DataSource = lista.ToList();
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
            Libros.Clear();
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

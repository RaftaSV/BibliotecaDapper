using AdminLabrary.controladores;
using AdminLabrary.formularios.principales;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminLabrary.formularios.frmBuscar
{
    public partial class frmBuscarEditorial : Form
    {
        public int enviar;
        List<entidades.Editoriales> edi = new List<entidades.Editoriales>();
        public frmBuscarEditorial()
        {
            InitializeComponent();
        }

        private void frmBuscarEditorial_Load(object sender, EventArgs e)
        {
            cargarLista();
            filtro();

        }
        void cargarLista()
        {
            CEditoriales c = new CEditoriales();
            editorialesBindingSource.DataSource = c.Listado();
            foreach (DataGridViewRow i in dtgEditoriales.Rows)
            {
                edi.Add(new entidades.Editoriales {Id_Editorial = int.Parse(i.Cells[0].Value.ToString()), Editorial = i.Cells[1].Value.ToString(),Fundada = Convert.ToDateTime(i.Cells[2].Value.ToString()), Direccion = i.Cells[3].Value.ToString()});
            }
        }void filtro()
        {
            string Buscar = txtBuscar.Text;
            var lista = from i in edi
                        where i.Editorial.Contains(Buscar)
                        select new 
                        {
                            Id_editorial = i.Id_Editorial,
                            Editorial = i.Editorial,
                            Fundada = i.Fundada,
                            Direccion = i.Direccion
                        };
            dtgEditoriales.DataSource = lista.ToList();
        }
        void seleccionar()
        {
            if (enviar == 1)
            {
                string id = dtgEditoriales.CurrentRow.Cells[0].Value.ToString();
                string nombre = dtgEditoriales.CurrentRow.Cells[1].Value.ToString();
                frmPrincipal.libros.nuevoL.id_EditorialTextBox.Text = id;
                frmPrincipal.libros.nuevoL.txtEditorial.Text = nombre;
                frmPrincipal.libros.nuevoL.id_Ed= id;
            }
            this.Close();
        }



        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            filtro();
        }

        private void dtgEditoriales_DoubleClick(object sender, EventArgs e)
        {
            seleccionar();
        }

        private void dtgEditoriales_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                seleccionar();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}

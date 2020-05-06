using AdminLabrary.conexion;
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
    public partial class frmBuscarLector : Form
    {
        public frmBuscarLector()
        {
            InitializeComponent();
        }

        private void frmBuscarLector_Load(object sender, EventArgs e)
        {
            filtro();
        }
       

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            
        }

        
        private void seleccionar()
        {
            string Lector = dgvLectores.CurrentRow.Cells[1].Value.ToString();
            string id = dgvLectores.CurrentRow.Cells[0].Value.ToString();
            frmPrincipal.alquiler.txtLector.Text = Lector;
            frmPrincipal.alquiler.id_LectorTextBox.Text = id;
            this.Close();
        }

       
        void filtro()
        {
            using (BibliotecaEntities db = new BibliotecaEntities())
            {
                string buscar = txtBuscar.Text;
                var lista = from lec in db.Lectores
                            where lec.Nombres.Contains(buscar)
                            select new
                            {
                                ID = lec.Id_Lector,
                                NOMBRES = lec.Nombres,
                                APELLIDOS = lec.Apellidos
                            };

                dgvLectores.DataSource = lista.ToList();

            }

        }

        private void frmBuscarLector_DoubleClick(object sender, EventArgs e)
        {
            seleccionar();
        }

        

        private void dgvLectores_KeyDown(object sender, KeyEventArgs e)
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

        private void dgvLectores_DoubleClick(object sender, EventArgs e)
        {
            seleccionar();
        }
    }
}

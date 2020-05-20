using AdminLabrary.controladores;
using AdminLabrary.formularios.insert_update;
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
    public partial class frmLectores : Form
    {
        public frmLectores()
        {
            InitializeComponent();
        }

        private void fLectores_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }
        public void CargarDatos()
        {
            CLectores c = new CLectores();
            lectoresBindingSource.DataSource = c.Listado();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmInsertarLector f = new frmInsertarLector();
            f.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            entidades.Lectores lectores = new entidades.Lectores();
            lectores = (entidades.Lectores)lectoresBindingSource.Current;
            frmActualizarLectores llector = new frmActualizarLectores(lectores);
            llector.ShowDialog();
        }
    }
}

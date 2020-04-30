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
    public partial class frmAdministradores : Form
    {
        public frmAdministradores()
        {
            InitializeComponent();
        }

        private void Carreras_Load(object sender, EventArgs e)
        {
            CAdministradores C = new CAdministradores();
            administradoresBindingSource.DataSource = C.Listado();

        }
    }
}

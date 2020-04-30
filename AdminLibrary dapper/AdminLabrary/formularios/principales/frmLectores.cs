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
    public partial class frmLectores : Form
    {
        public frmLectores()
        {
            InitializeComponent();
        }

        private void fLectores_Load(object sender, EventArgs e)
        {
            CLectores c = new CLectores();
            lectoresBindingSource.DataSource = c.Listado();


        }
    }
}

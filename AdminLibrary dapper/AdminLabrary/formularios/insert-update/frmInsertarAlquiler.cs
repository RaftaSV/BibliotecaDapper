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
    public partial class frmInsertarAlquiler : Form
    {
        public  string id;
        public frmInsertarAlquiler()
        {
            InitializeComponent();
            
        }

        private void frmInsertarAlquiler_Load(object sender, EventArgs e)
        {
          
            alquileresBindingSource.MoveLast();
            alquileresBindingSource.AddNew();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
           
            entregadoTextBox.Text = id;
           
            alquileresBindingSource.EndEdit();
            entidades.Alquileres alq = new entidades.Alquileres();
            alq = (entidades.Alquileres)alquileresBindingSource.Current;
            CAlquileres cAlq = new CAlquileres();
            cAlq.Guardar(alq);
            frmPrincipal.alquileres.CargarDatos();
        }
    }
}

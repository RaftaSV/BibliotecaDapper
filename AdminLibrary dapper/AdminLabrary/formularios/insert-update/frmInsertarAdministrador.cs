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
    public partial class frmInsertarAdministrador : Form
    {
        public frmInsertarAdministrador()
        {
            InitializeComponent();
            administradoresBindingSource.MoveLast();
            administradoresBindingSource.AddNew();
            CLectores lectores = new CLectores();
            lectoresBindingSource.DataSource = lectores.Listado();
        }

       

        private void btnGuardar_Click(object sender, EventArgs e)
        {
           
            administradoresBindingSource.EndEdit();
            
                Administradores admi = new Administradores();
                admi = (Administradores)administradoresBindingSource.Current;
                CAdministradores cadmin = new CAdministradores();
                cadmin.guardar(admi);
                administradoresBindingSource.Clear();
                frmPrincipal.admi.CargarDatos();
            
        }

        private void frmInsertarAdministrador_Load(object sender, EventArgs e)
        {

        }
    }
}

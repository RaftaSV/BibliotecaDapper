﻿using AdminLabrary.conexion;
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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            txtContraseña.PasswordChar = '#';

        }

        public void btnIniciarsesion_Click(object sender, EventArgs e)

        {

            string u = txtUsuario.Text;

            using (BibliotecaEntities1 db = new BibliotecaEntities1())
            {
                var lista = from admin in db.Administradores
                            where admin.Usuario == txtUsuario.Text
                            && admin.Contraseña == txtContraseña.Text
                            select admin;
              
                   
                
                if (lista.Count() > 0)
                {
                    frmPrincipal f = new frmPrincipal();
                    string usu = txtUsuario.Text;
                    f.lblUsuario.Text = usu;
                    frmPrincipal.alquiler.txtUsuario.Text = txtUsuario.Text;
                    f.ShowDialog();

                    this.Hide();

                }
                else
                {
                    txtUsuario.Text = "";
                    txtContraseña.Text = "";

                    MessageBox.Show("Usuario o contraseña incorrecto", "Notificacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }


            }

        }
    }
}

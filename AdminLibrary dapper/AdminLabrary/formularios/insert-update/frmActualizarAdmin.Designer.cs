namespace AdminLabrary.formularios.insert_update
{
    partial class frmActualizarAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label contraseñaLabel;
            System.Windows.Forms.Label lectorLabel;
            System.Windows.Forms.Label usuarioLabel;
            this.administradoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtLecID = new System.Windows.Forms.TextBox();
            this.txtLecNombre = new System.Windows.Forms.TextBox();
            this.contraseñaTextBox = new System.Windows.Forms.TextBox();
            this.usuarioTextBox = new System.Windows.Forms.TextBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            contraseñaLabel = new System.Windows.Forms.Label();
            lectorLabel = new System.Windows.Forms.Label();
            usuarioLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.administradoresBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // administradoresBindingSource
            // 
            this.administradoresBindingSource.DataSource = typeof(AdminLabrary.entidades.Administradores);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(488, 13);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(99, 23);
            this.btnBuscar.TabIndex = 29;
            this.btnBuscar.Text = "Seleccionar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtLecID
            // 
            this.txtLecID.Enabled = false;
            this.txtLecID.Location = new System.Drawing.Point(400, 13);
            this.txtLecID.Margin = new System.Windows.Forms.Padding(4);
            this.txtLecID.Name = "txtLecID";
            this.txtLecID.Size = new System.Drawing.Size(60, 20);
            this.txtLecID.TabIndex = 28;
            // 
            // txtLecNombre
            // 
            this.txtLecNombre.Enabled = false;
            this.txtLecNombre.Location = new System.Drawing.Point(173, 13);
            this.txtLecNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtLecNombre.Name = "txtLecNombre";
            this.txtLecNombre.Size = new System.Drawing.Size(219, 20);
            this.txtLecNombre.TabIndex = 27;
            // 
            // contraseñaLabel
            // 
            contraseñaLabel.AutoSize = true;
            contraseñaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            contraseñaLabel.Location = new System.Drawing.Point(29, 117);
            contraseñaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            contraseñaLabel.Name = "contraseñaLabel";
            contraseñaLabel.Size = new System.Drawing.Size(80, 16);
            contraseñaLabel.TabIndex = 25;
            contraseñaLabel.Text = "Contraseña:";
            // 
            // contraseñaTextBox
            // 
            this.contraseñaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.administradoresBindingSource, "Contraseña", true));
            this.contraseñaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contraseñaTextBox.Location = new System.Drawing.Point(173, 109);
            this.contraseñaTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.contraseñaTextBox.Name = "contraseñaTextBox";
            this.contraseñaTextBox.Size = new System.Drawing.Size(219, 22);
            this.contraseñaTextBox.TabIndex = 26;
            // 
            // lectorLabel
            // 
            lectorLabel.AutoSize = true;
            lectorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lectorLabel.Location = new System.Drawing.Point(29, 19);
            lectorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lectorLabel.Name = "lectorLabel";
            lectorLabel.Size = new System.Drawing.Size(44, 16);
            lectorLabel.TabIndex = 22;
            lectorLabel.Text = "lector:";
            // 
            // usuarioLabel
            // 
            usuarioLabel.AutoSize = true;
            usuarioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            usuarioLabel.Location = new System.Drawing.Point(29, 65);
            usuarioLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            usuarioLabel.Name = "usuarioLabel";
            usuarioLabel.Size = new System.Drawing.Size(58, 16);
            usuarioLabel.TabIndex = 23;
            usuarioLabel.Text = "Usuario:";
            // 
            // usuarioTextBox
            // 
            this.usuarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.administradoresBindingSource, "Usuario", true));
            this.usuarioTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuarioTextBox.Location = new System.Drawing.Point(173, 61);
            this.usuarioTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.usuarioTextBox.Name = "usuarioTextBox";
            this.usuarioTextBox.Size = new System.Drawing.Size(219, 22);
            this.usuarioTextBox.TabIndex = 24;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Location = new System.Drawing.Point(32, 206);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(104, 38);
            this.btnActualizar.TabIndex = 30;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // frmActualizarAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 450);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtLecID);
            this.Controls.Add(this.txtLecNombre);
            this.Controls.Add(contraseñaLabel);
            this.Controls.Add(this.contraseñaTextBox);
            this.Controls.Add(lectorLabel);
            this.Controls.Add(usuarioLabel);
            this.Controls.Add(this.usuarioTextBox);
            this.Name = "frmActualizarAdmin";
            this.Text = "frmActualizarAdmin";
            this.Load += new System.EventHandler(this.frmActualizarAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.administradoresBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource administradoresBindingSource;
        private System.Windows.Forms.Button btnBuscar;
        public System.Windows.Forms.TextBox txtLecID;
        public System.Windows.Forms.TextBox txtLecNombre;
        private System.Windows.Forms.TextBox contraseñaTextBox;
        private System.Windows.Forms.TextBox usuarioTextBox;
        public System.Windows.Forms.Button btnActualizar;
    }
}
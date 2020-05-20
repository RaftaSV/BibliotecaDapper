namespace AdminLabrary.formularios.insert_update
{
    partial class frmInsertarAdministrador
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
            System.Windows.Forms.Label lectorLabel;
            System.Windows.Forms.Label usuarioLabel;
            System.Windows.Forms.Label contraseñaLabel;
            this.btnGuardar = new System.Windows.Forms.Button();
            this.usuarioTextBox = new System.Windows.Forms.TextBox();
            this.contraseñaTextBox = new System.Windows.Forms.TextBox();
            this.txtLecNombre = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lectorTextBox = new System.Windows.Forms.TextBox();
            this.administradoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            lectorLabel = new System.Windows.Forms.Label();
            usuarioLabel = new System.Windows.Forms.Label();
            contraseñaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.administradoresBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lectorLabel
            // 
            lectorLabel.AutoSize = true;
            lectorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lectorLabel.Location = new System.Drawing.Point(57, 34);
            lectorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lectorLabel.Name = "lectorLabel";
            lectorLabel.Size = new System.Drawing.Size(44, 16);
            lectorLabel.TabIndex = 13;
            lectorLabel.Text = "lector:";
            // 
            // usuarioLabel
            // 
            usuarioLabel.AutoSize = true;
            usuarioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            usuarioLabel.Location = new System.Drawing.Point(57, 80);
            usuarioLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            usuarioLabel.Name = "usuarioLabel";
            usuarioLabel.Size = new System.Drawing.Size(58, 16);
            usuarioLabel.TabIndex = 15;
            usuarioLabel.Text = "Usuario:";
            // 
            // contraseñaLabel
            // 
            contraseñaLabel.AutoSize = true;
            contraseñaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            contraseñaLabel.Location = new System.Drawing.Point(57, 132);
            contraseñaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            contraseñaLabel.Name = "contraseñaLabel";
            contraseñaLabel.Size = new System.Drawing.Size(80, 16);
            contraseñaLabel.TabIndex = 17;
            contraseñaLabel.Text = "Contraseña:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(49, 272);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(104, 38);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // usuarioTextBox
            // 
            this.usuarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.administradoresBindingSource, "Usuario", true));
            this.usuarioTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuarioTextBox.Location = new System.Drawing.Point(201, 76);
            this.usuarioTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.usuarioTextBox.Name = "usuarioTextBox";
            this.usuarioTextBox.Size = new System.Drawing.Size(219, 22);
            this.usuarioTextBox.TabIndex = 16;
            // 
            // contraseñaTextBox
            // 
            this.contraseñaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.administradoresBindingSource, "Contraseña", true));
            this.contraseñaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contraseñaTextBox.Location = new System.Drawing.Point(201, 124);
            this.contraseñaTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.contraseñaTextBox.Name = "contraseñaTextBox";
            this.contraseñaTextBox.Size = new System.Drawing.Size(219, 22);
            this.contraseñaTextBox.TabIndex = 18;
            // 
            // txtLecNombre
            // 
            this.txtLecNombre.Enabled = false;
            this.txtLecNombre.Location = new System.Drawing.Point(201, 28);
            this.txtLecNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtLecNombre.Name = "txtLecNombre";
            this.txtLecNombre.Size = new System.Drawing.Size(219, 22);
            this.txtLecNombre.TabIndex = 19;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(516, 28);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(99, 23);
            this.btnBuscar.TabIndex = 21;
            this.btnBuscar.Text = "Seleccionar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lectorTextBox
            // 
            this.lectorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.administradoresBindingSource, "lector", true));
            this.lectorTextBox.Enabled = false;
            this.lectorTextBox.Location = new System.Drawing.Point(427, 28);
            this.lectorTextBox.Name = "lectorTextBox";
            this.lectorTextBox.Size = new System.Drawing.Size(61, 22);
            this.lectorTextBox.TabIndex = 22;
            this.lectorTextBox.TextChanged += new System.EventHandler(this.lectorTextBox_TextChanged);
            // 
            // administradoresBindingSource
            // 
            this.administradoresBindingSource.DataSource = typeof(AdminLabrary.entidades.Administradores);
            // 
            // frmInsertarAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 352);
            this.Controls.Add(this.lectorTextBox);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtLecNombre);
            this.Controls.Add(contraseñaLabel);
            this.Controls.Add(this.contraseñaTextBox);
            this.Controls.Add(lectorLabel);
            this.Controls.Add(usuarioLabel);
            this.Controls.Add(this.usuarioTextBox);
            this.Controls.Add(this.btnGuardar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmInsertarAdministrador";
            this.Load += new System.EventHandler(this.frmInsertarAdministrador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.administradoresBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.BindingSource administradoresBindingSource;
        private System.Windows.Forms.TextBox usuarioTextBox;
        private System.Windows.Forms.TextBox contraseñaTextBox;
        public System.Windows.Forms.TextBox txtLecNombre;
        private System.Windows.Forms.Button btnBuscar;
        public System.Windows.Forms.TextBox lectorTextBox;
    }
}
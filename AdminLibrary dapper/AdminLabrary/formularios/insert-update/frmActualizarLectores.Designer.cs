namespace AdminLabrary.formularios.insert_update
{
    partial class frmActualizarLectores
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
            System.Windows.Forms.Label apellidosLabel;
            System.Windows.Forms.Label nombresLabel;
            this.lectoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnEditar = new System.Windows.Forms.Button();
            this.apellidosTextBox = new System.Windows.Forms.TextBox();
            this.nombresTextBox = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            apellidosLabel = new System.Windows.Forms.Label();
            nombresLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lectoresBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lectoresBindingSource
            // 
            this.lectoresBindingSource.DataSource = typeof(AdminLabrary.entidades.Lectores);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(55, 242);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(112, 35);
            this.btnEditar.TabIndex = 5;
            this.btnEditar.Text = "Actualizar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // apellidosLabel
            // 
            apellidosLabel.AutoSize = true;
            apellidosLabel.Location = new System.Drawing.Point(51, 122);
            apellidosLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            apellidosLabel.Name = "apellidosLabel";
            apellidosLabel.Size = new System.Drawing.Size(77, 20);
            apellidosLabel.TabIndex = 7;
            apellidosLabel.Text = "Apellidos:";
            // 
            // apellidosTextBox
            // 
            this.apellidosTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lectoresBindingSource, "Apellidos", true));
            this.apellidosTextBox.Location = new System.Drawing.Point(153, 119);
            this.apellidosTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.apellidosTextBox.Name = "apellidosTextBox";
            this.apellidosTextBox.Size = new System.Drawing.Size(220, 26);
            this.apellidosTextBox.TabIndex = 8;
            // 
            // nombresLabel
            // 
            nombresLabel.AutoSize = true;
            nombresLabel.Location = new System.Drawing.Point(51, 26);
            nombresLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            nombresLabel.Name = "nombresLabel";
            nombresLabel.Size = new System.Drawing.Size(77, 20);
            nombresLabel.TabIndex = 9;
            nombresLabel.Text = "Nombres:";
            // 
            // nombresTextBox
            // 
            this.nombresTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lectoresBindingSource, "Nombres", true));
            this.nombresTextBox.Location = new System.Drawing.Point(153, 24);
            this.nombresTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.nombresTextBox.Name = "nombresTextBox";
            this.nombresTextBox.Size = new System.Drawing.Size(220, 26);
            this.nombresTextBox.TabIndex = 6;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(274, 242);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(112, 35);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // frmActualizarLectores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 325);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(apellidosLabel);
            this.Controls.Add(this.apellidosTextBox);
            this.Controls.Add(nombresLabel);
            this.Controls.Add(this.nombresTextBox);
            this.Controls.Add(this.btnEditar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmActualizarLectores";
            this.Text = "frmActualizarLectores";
            this.Load += new System.EventHandler(this.frmActualizarLectores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lectoresBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource lectoresBindingSource;
        private System.Windows.Forms.TextBox apellidosTextBox;
        private System.Windows.Forms.TextBox nombresTextBox;
        public System.Windows.Forms.Button btnEliminar;
        public System.Windows.Forms.Button btnEditar;
    }
}
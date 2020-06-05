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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmActualizarLectores));
            this.btnEditar = new System.Windows.Forms.Button();
            this.apellidosTextBox = new System.Windows.Forms.TextBox();
            this.nombresTextBox = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lectoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            apellidosLabel = new System.Windows.Forms.Label();
            nombresLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lectoresBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // apellidosLabel
            // 
            apellidosLabel.AutoSize = true;
            apellidosLabel.Location = new System.Drawing.Point(34, 197);
            apellidosLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            apellidosLabel.Name = "apellidosLabel";
            apellidosLabel.Size = new System.Drawing.Size(77, 20);
            apellidosLabel.TabIndex = 7;
            apellidosLabel.Text = "Apellidos:";
            // 
            // nombresLabel
            // 
            nombresLabel.AutoSize = true;
            nombresLabel.Location = new System.Drawing.Point(34, 161);
            nombresLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            nombresLabel.Name = "nombresLabel";
            nombresLabel.Size = new System.Drawing.Size(77, 20);
            nombresLabel.TabIndex = 9;
            nombresLabel.Text = "Nombres:";
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.Teal;
            this.btnEditar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEditar.BackgroundImage")));
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Teal;
            this.btnEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(38, 242);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(327, 28);
            this.btnEditar.TabIndex = 5;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // apellidosTextBox
            // 
            this.apellidosTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lectoresBindingSource, "Apellidos", true));
            this.apellidosTextBox.Location = new System.Drawing.Point(136, 194);
            this.apellidosTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.apellidosTextBox.Name = "apellidosTextBox";
            this.apellidosTextBox.Size = new System.Drawing.Size(220, 26);
            this.apellidosTextBox.TabIndex = 8;
            // 
            // nombresTextBox
            // 
            this.nombresTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lectoresBindingSource, "Nombres", true));
            this.nombresTextBox.Location = new System.Drawing.Point(136, 159);
            this.nombresTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.nombresTextBox.Name = "nombresTextBox";
            this.nombresTextBox.Size = new System.Drawing.Size(220, 26);
            this.nombresTextBox.TabIndex = 6;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Teal;
            this.btnEliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEliminar.BackgroundImage")));
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Teal;
            this.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(38, 274);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(327, 27);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lectoresBindingSource
            // 
            this.lectoresBindingSource.DataSource = typeof(AdminLabrary.entidades.Lectores);
            // 
            // frmActualizarLectores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(422, 341);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(apellidosLabel);
            this.Controls.Add(this.apellidosTextBox);
            this.Controls.Add(nombresLabel);
            this.Controls.Add(this.nombresTextBox);
            this.Controls.Add(this.btnEditar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmActualizarLectores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
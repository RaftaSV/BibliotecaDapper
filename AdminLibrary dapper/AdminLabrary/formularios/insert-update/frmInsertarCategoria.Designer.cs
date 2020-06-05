namespace AdminLabrary.formularios.insert_update
{
    partial class frmInsertarCategoria
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
            System.Windows.Forms.Label categoriaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInsertarCategoria));
            this.categoriaTextBox = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.categoriasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            categoriaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // categoriaLabel
            // 
            categoriaLabel.AutoSize = true;
            categoriaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            categoriaLabel.Location = new System.Drawing.Point(43, 93);
            categoriaLabel.Name = "categoriaLabel";
            categoriaLabel.Size = new System.Drawing.Size(82, 20);
            categoriaLabel.TabIndex = 1;
            categoriaLabel.Text = "Categoria:";
            // 
            // categoriaTextBox
            // 
            this.categoriaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.categoriasBindingSource, "Categoria", true));
            this.categoriaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoriaTextBox.Location = new System.Drawing.Point(145, 87);
            this.categoriaTextBox.Name = "categoriaTextBox";
            this.categoriaTextBox.Size = new System.Drawing.Size(182, 26);
            this.categoriaTextBox.TabIndex = 2;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Teal;
            this.btnGuardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGuardar.BackgroundImage")));
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(47, 140);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(280, 23);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // categoriasBindingSource
            // 
            this.categoriasBindingSource.DataSource = typeof(AdminLabrary.entidades.Categorias);
            // 
            // frmInsertarCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(387, 175);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(categoriaLabel);
            this.Controls.Add(this.categoriaTextBox);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "frmInsertarCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NUEVA CATEGORIA";
            this.Load += new System.EventHandler(this.frmInsertarCategoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.categoriasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource categoriasBindingSource;
        private System.Windows.Forms.TextBox categoriaTextBox;
        private System.Windows.Forms.Button btnGuardar;
    }
}
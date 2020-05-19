namespace AdminLabrary.formularios.insert_update
{
    partial class frmActualizarEditorial
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
            System.Windows.Forms.Label direccionLabel;
            System.Windows.Forms.Label editorialLabel;
            System.Windows.Forms.Label fundadaLabel;
            this.editorialesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.direccionTextBox = new System.Windows.Forms.TextBox();
            this.editorialTextBox = new System.Windows.Forms.TextBox();
            this.fundadaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.btnActualizareditorial = new System.Windows.Forms.Button();
            direccionLabel = new System.Windows.Forms.Label();
            editorialLabel = new System.Windows.Forms.Label();
            fundadaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.editorialesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // editorialesBindingSource
            // 
            this.editorialesBindingSource.DataSource = typeof(AdminLabrary.entidades.Editoriales);
            // 
            // direccionLabel
            // 
            direccionLabel.AutoSize = true;
            direccionLabel.Location = new System.Drawing.Point(58, 52);
            direccionLabel.Name = "direccionLabel";
            direccionLabel.Size = new System.Drawing.Size(55, 13);
            direccionLabel.TabIndex = 1;
            direccionLabel.Text = "Direccion:";
            // 
            // direccionTextBox
            // 
            this.direccionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.editorialesBindingSource, "Direccion", true));
            this.direccionTextBox.Location = new System.Drawing.Point(119, 49);
            this.direccionTextBox.Name = "direccionTextBox";
            this.direccionTextBox.Size = new System.Drawing.Size(200, 20);
            this.direccionTextBox.TabIndex = 2;
            // 
            // editorialLabel
            // 
            editorialLabel.AutoSize = true;
            editorialLabel.Location = new System.Drawing.Point(58, 78);
            editorialLabel.Name = "editorialLabel";
            editorialLabel.Size = new System.Drawing.Size(47, 13);
            editorialLabel.TabIndex = 3;
            editorialLabel.Text = "Editorial:";
            // 
            // editorialTextBox
            // 
            this.editorialTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.editorialesBindingSource, "Editorial", true));
            this.editorialTextBox.Location = new System.Drawing.Point(119, 75);
            this.editorialTextBox.Name = "editorialTextBox";
            this.editorialTextBox.Size = new System.Drawing.Size(200, 20);
            this.editorialTextBox.TabIndex = 4;
            // 
            // fundadaLabel
            // 
            fundadaLabel.AutoSize = true;
            fundadaLabel.Location = new System.Drawing.Point(58, 105);
            fundadaLabel.Name = "fundadaLabel";
            fundadaLabel.Size = new System.Drawing.Size(52, 13);
            fundadaLabel.TabIndex = 5;
            fundadaLabel.Text = "Fundada:";
            // 
            // fundadaDateTimePicker
            // 
            this.fundadaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.editorialesBindingSource, "Fundada", true));
            this.fundadaDateTimePicker.Location = new System.Drawing.Point(119, 101);
            this.fundadaDateTimePicker.Name = "fundadaDateTimePicker";
            this.fundadaDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fundadaDateTimePicker.TabIndex = 6;
            // 
            // btnActualizareditorial
            // 
            this.btnActualizareditorial.Location = new System.Drawing.Point(61, 152);
            this.btnActualizareditorial.Name = "btnActualizareditorial";
            this.btnActualizareditorial.Size = new System.Drawing.Size(258, 23);
            this.btnActualizareditorial.TabIndex = 7;
            this.btnActualizareditorial.Text = "Actualizar";
            this.btnActualizareditorial.UseVisualStyleBackColor = true;
            this.btnActualizareditorial.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmActualizarEditorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 288);
            this.Controls.Add(this.btnActualizareditorial);
            this.Controls.Add(direccionLabel);
            this.Controls.Add(this.direccionTextBox);
            this.Controls.Add(editorialLabel);
            this.Controls.Add(this.editorialTextBox);
            this.Controls.Add(fundadaLabel);
            this.Controls.Add(this.fundadaDateTimePicker);
            this.Name = "frmActualizarEditorial";
            this.Text = "frmActualizarEditorial";
            this.Load += new System.EventHandler(this.FrmActualizarEditorial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.editorialesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource editorialesBindingSource;
        private System.Windows.Forms.TextBox direccionTextBox;
        private System.Windows.Forms.TextBox editorialTextBox;
        private System.Windows.Forms.DateTimePicker fundadaDateTimePicker;
        private System.Windows.Forms.Button btnActualizareditorial;
    }
}
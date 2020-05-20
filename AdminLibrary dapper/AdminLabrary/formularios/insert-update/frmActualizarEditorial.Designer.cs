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
            this.btnActualizareditorial = new System.Windows.Forms.Button();
            this.direccionTextBox = new System.Windows.Forms.TextBox();
            this.editorialTextBox = new System.Windows.Forms.TextBox();
            this.fundadaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.editorialesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            direccionLabel = new System.Windows.Forms.Label();
            editorialLabel = new System.Windows.Forms.Label();
            fundadaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.editorialesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // direccionLabel
            // 
            direccionLabel.AutoSize = true;
            direccionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            direccionLabel.Location = new System.Drawing.Point(19, 79);
            direccionLabel.Name = "direccionLabel";
            direccionLabel.Size = new System.Drawing.Size(79, 20);
            direccionLabel.TabIndex = 8;
            direccionLabel.Text = "Direccion:";
            // 
            // editorialLabel
            // 
            editorialLabel.AutoSize = true;
            editorialLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            editorialLabel.Location = new System.Drawing.Point(19, 48);
            editorialLabel.Name = "editorialLabel";
            editorialLabel.Size = new System.Drawing.Size(70, 20);
            editorialLabel.TabIndex = 11;
            editorialLabel.Text = "Editorial:";
            // 
            // fundadaLabel
            // 
            fundadaLabel.AutoSize = true;
            fundadaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fundadaLabel.Location = new System.Drawing.Point(19, 109);
            fundadaLabel.Name = "fundadaLabel";
            fundadaLabel.Size = new System.Drawing.Size(77, 20);
            fundadaLabel.TabIndex = 13;
            fundadaLabel.Text = "Fundada:";
            // 
            // btnActualizareditorial
            // 
            this.btnActualizareditorial.Location = new System.Drawing.Point(47, 201);
            this.btnActualizareditorial.Name = "btnActualizareditorial";
            this.btnActualizareditorial.Size = new System.Drawing.Size(132, 30);
            this.btnActualizareditorial.TabIndex = 7;
            this.btnActualizareditorial.Text = "Actualizar";
            this.btnActualizareditorial.UseVisualStyleBackColor = true;
            this.btnActualizareditorial.Click += new System.EventHandler(this.button1_Click);
            // 
            // direccionTextBox
            // 
            this.direccionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.editorialesBindingSource, "Direccion", true));
            this.direccionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.direccionTextBox.Location = new System.Drawing.Point(121, 76);
            this.direccionTextBox.Name = "direccionTextBox";
            this.direccionTextBox.Size = new System.Drawing.Size(200, 26);
            this.direccionTextBox.TabIndex = 10;
            // 
            // editorialTextBox
            // 
            this.editorialTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.editorialesBindingSource, "Editorial", true));
            this.editorialTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editorialTextBox.Location = new System.Drawing.Point(121, 42);
            this.editorialTextBox.Name = "editorialTextBox";
            this.editorialTextBox.Size = new System.Drawing.Size(200, 26);
            this.editorialTextBox.TabIndex = 9;
            // 
            // fundadaDateTimePicker
            // 
            this.fundadaDateTimePicker.CustomFormat = "yyyy - MM - dd";
            this.fundadaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.editorialesBindingSource, "Fundada", true));
            this.fundadaDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fundadaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fundadaDateTimePicker.Location = new System.Drawing.Point(121, 109);
            this.fundadaDateTimePicker.Name = "fundadaDateTimePicker";
            this.fundadaDateTimePicker.Size = new System.Drawing.Size(200, 26);
            this.fundadaDateTimePicker.TabIndex = 12;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(251, 201);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(132, 30);
            this.btnEliminar.TabIndex = 14;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // editorialesBindingSource
            // 
            this.editorialesBindingSource.DataSource = typeof(AdminLabrary.entidades.Editoriales);
            // 
            // frmActualizarEditorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 288);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(direccionLabel);
            this.Controls.Add(this.direccionTextBox);
            this.Controls.Add(editorialLabel);
            this.Controls.Add(this.editorialTextBox);
            this.Controls.Add(fundadaLabel);
            this.Controls.Add(this.fundadaDateTimePicker);
            this.Controls.Add(this.btnActualizareditorial);
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
        public System.Windows.Forms.Button btnActualizareditorial;
        public System.Windows.Forms.Button btnEliminar;
    }
}
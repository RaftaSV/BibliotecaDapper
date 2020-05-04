namespace AdminLabrary.formularios.insert_update
{
    partial class frmInsertarEditorial
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
            this.btnGuardar = new System.Windows.Forms.Button();
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
            direccionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            direccionLabel.Location = new System.Drawing.Point(3, 43);
            direccionLabel.Name = "direccionLabel";
            direccionLabel.Size = new System.Drawing.Size(79, 20);
            direccionLabel.TabIndex = 1;
            direccionLabel.Text = "Direccion:";
            // 
            // direccionTextBox
            // 
            this.direccionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.editorialesBindingSource, "Direccion", true));
            this.direccionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.direccionTextBox.Location = new System.Drawing.Point(105, 40);
            this.direccionTextBox.Name = "direccionTextBox";
            this.direccionTextBox.Size = new System.Drawing.Size(200, 26);
            this.direccionTextBox.TabIndex = 2;
            // 
            // editorialLabel
            // 
            editorialLabel.AutoSize = true;
            editorialLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            editorialLabel.Location = new System.Drawing.Point(3, 12);
            editorialLabel.Name = "editorialLabel";
            editorialLabel.Size = new System.Drawing.Size(70, 20);
            editorialLabel.TabIndex = 3;
            editorialLabel.Text = "Editorial:";
            // 
            // editorialTextBox
            // 
            this.editorialTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.editorialesBindingSource, "Editorial", true));
            this.editorialTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editorialTextBox.Location = new System.Drawing.Point(105, 6);
            this.editorialTextBox.Name = "editorialTextBox";
            this.editorialTextBox.Size = new System.Drawing.Size(200, 26);
            this.editorialTextBox.TabIndex = 1;
            // 
            // fundadaLabel
            // 
            fundadaLabel.AutoSize = true;
            fundadaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fundadaLabel.Location = new System.Drawing.Point(3, 73);
            fundadaLabel.Name = "fundadaLabel";
            fundadaLabel.Size = new System.Drawing.Size(77, 20);
            fundadaLabel.TabIndex = 5;
            fundadaLabel.Text = "Fundada:";
            // 
            // fundadaDateTimePicker
            // 
            this.fundadaDateTimePicker.CustomFormat = "yyyy - MM - dd";
            this.fundadaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.editorialesBindingSource, "Fundada", true));
            this.fundadaDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fundadaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fundadaDateTimePicker.Location = new System.Drawing.Point(105, 73);
            this.fundadaDateTimePicker.Name = "fundadaDateTimePicker";
            this.fundadaDateTimePicker.Size = new System.Drawing.Size(200, 26);
            this.fundadaDateTimePicker.TabIndex = 3;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(12, 189);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // frmInsertarEditorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 248);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(direccionLabel);
            this.Controls.Add(this.direccionTextBox);
            this.Controls.Add(editorialLabel);
            this.Controls.Add(this.editorialTextBox);
            this.Controls.Add(fundadaLabel);
            this.Controls.Add(this.fundadaDateTimePicker);
            this.Name = "frmInsertarEditorial";
            this.Text = "frmInsertarEditorial";
            this.Load += new System.EventHandler(this.frmInsertarEditorial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.editorialesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource editorialesBindingSource;
        private System.Windows.Forms.TextBox direccionTextBox;
        private System.Windows.Forms.TextBox editorialTextBox;
        private System.Windows.Forms.DateTimePicker fundadaDateTimePicker;
        private System.Windows.Forms.Button btnGuardar;
    }
}
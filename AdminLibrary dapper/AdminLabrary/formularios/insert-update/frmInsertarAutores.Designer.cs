﻿namespace AdminLabrary.formularios.insert_update
{
    partial class frmInsertarAutores
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
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label fecha_nacimientoLabel;
            System.Windows.Forms.Label nacionalidadLabel;
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.fecha_nacimientoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.nacionalidadTextBox = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.autoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            nombreLabel = new System.Windows.Forms.Label();
            fecha_nacimientoLabel = new System.Windows.Forms.Label();
            nacionalidadLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.autoresBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.CausesValidation = false;
            nombreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nombreLabel.Location = new System.Drawing.Point(27, 140);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(69, 20);
            nombreLabel.TabIndex = 5;
            nombreLabel.Text = "Nombre:";
            // 
            // fecha_nacimientoLabel
            // 
            fecha_nacimientoLabel.AutoSize = true;
            fecha_nacimientoLabel.CausesValidation = false;
            fecha_nacimientoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fecha_nacimientoLabel.Location = new System.Drawing.Point(27, 175);
            fecha_nacimientoLabel.Name = "fecha_nacimientoLabel";
            fecha_nacimientoLabel.Size = new System.Drawing.Size(134, 20);
            fecha_nacimientoLabel.TabIndex = 7;
            fecha_nacimientoLabel.Text = "fecha nacimiento:";
            // 
            // nacionalidadLabel
            // 
            nacionalidadLabel.AutoSize = true;
            nacionalidadLabel.CausesValidation = false;
            nacionalidadLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nacionalidadLabel.Location = new System.Drawing.Point(27, 211);
            nacionalidadLabel.Name = "nacionalidadLabel";
            nacionalidadLabel.Size = new System.Drawing.Size(104, 20);
            nacionalidadLabel.TabIndex = 0;
            nacionalidadLabel.Text = "Nacionalidad:";
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.autoresBindingSource, "Nombre", true));
            this.nombreTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreTextBox.Location = new System.Drawing.Point(167, 134);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(200, 26);
            this.nombreTextBox.TabIndex = 0;
            // 
            // fecha_nacimientoDateTimePicker
            // 
            this.fecha_nacimientoDateTimePicker.CustomFormat = "yyyy - MM - dd";
            this.fecha_nacimientoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.autoresBindingSource, "fecha_nacimiento", true));
            this.fecha_nacimientoDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecha_nacimientoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fecha_nacimientoDateTimePicker.Location = new System.Drawing.Point(167, 170);
            this.fecha_nacimientoDateTimePicker.Name = "fecha_nacimientoDateTimePicker";
            this.fecha_nacimientoDateTimePicker.Size = new System.Drawing.Size(200, 26);
            this.fecha_nacimientoDateTimePicker.TabIndex = 2;
            // 
            // nacionalidadTextBox
            // 
            this.nacionalidadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.autoresBindingSource, "Nacionalidad", true));
            this.nacionalidadTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nacionalidadTextBox.Location = new System.Drawing.Point(167, 205);
            this.nacionalidadTextBox.Name = "nacionalidadTextBox";
            this.nacionalidadTextBox.Size = new System.Drawing.Size(200, 26);
            this.nacionalidadTextBox.TabIndex = 3;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Teal;
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnGuardar.CausesValidation = false;
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(31, 246);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(336, 24);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // autoresBindingSource
            // 
            this.autoresBindingSource.DataSource = typeof(AdminLabrary.entidades.Autores);
            // 
            // frmInsertarAutores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(426, 282);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(nacionalidadLabel);
            this.Controls.Add(this.nacionalidadTextBox);
            this.Controls.Add(fecha_nacimientoLabel);
            this.Controls.Add(this.fecha_nacimientoDateTimePicker);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "frmInsertarAutores";
            this.Text = "NUEVO AUTOR";
            ((System.ComponentModel.ISupportInitialize)(this.autoresBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource autoresBindingSource;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.DateTimePicker fecha_nacimientoDateTimePicker;
        private System.Windows.Forms.TextBox nacionalidadTextBox;
        private System.Windows.Forms.Button btnGuardar;
    }
}
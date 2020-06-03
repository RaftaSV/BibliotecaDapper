﻿namespace AdminLabrary.formularios
{
    partial class frmAlquileres
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.alquileresDataGridView = new System.Windows.Forms.DataGridView();
            this.btnRecibir = new System.Windows.Forms.Button();
            this.btnHistorial = new System.Windows.Forms.Button();
            this.idalquilerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idLectorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.lectoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idlibroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.librosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.entregadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.administradoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fechasalidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaprevistadeentregaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alquileresPendientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.alquileresDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lectoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.librosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.administradoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alquileresPendientesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNuevo
            // 
            this.btnNuevo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnNuevo.BackColor = System.Drawing.Color.Teal;
            this.btnNuevo.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNuevo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.Color.White;
            this.btnNuevo.Location = new System.Drawing.Point(48, 102);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(110, 23);
            this.btnNuevo.TabIndex = 2;
            this.btnNuevo.Text = "Nuevo alquiler";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // alquileresDataGridView
            // 
            this.alquileresDataGridView.AllowUserToAddRows = false;
            this.alquileresDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.alquileresDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.alquileresDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.alquileresDataGridView.AutoGenerateColumns = false;
            this.alquileresDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.alquileresDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.alquileresDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.alquileresDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.alquileresDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.alquileresDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.alquileresDataGridView.ColumnHeadersHeight = 40;
            this.alquileresDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.alquileresDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idalquilerDataGridViewTextBoxColumn,
            this.idLectorDataGridViewTextBoxColumn,
            this.idlibroDataGridViewTextBoxColumn,
            this.entregadoDataGridViewTextBoxColumn,
            this.fechasalidaDataGridViewTextBoxColumn,
            this.fechaprevistadeentregaDataGridViewTextBoxColumn});
            this.alquileresDataGridView.DataSource = this.alquileresPendientesBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.alquileresDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.alquileresDataGridView.GridColor = System.Drawing.Color.Gainsboro;
            this.alquileresDataGridView.Location = new System.Drawing.Point(12, 140);
            this.alquileresDataGridView.Name = "alquileresDataGridView";
            this.alquileresDataGridView.ReadOnly = true;
            this.alquileresDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.alquileresDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.alquileresDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.alquileresDataGridView.Size = new System.Drawing.Size(912, 409);
            this.alquileresDataGridView.TabIndex = 1;
            this.alquileresDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.alquileresDataGridView_CellClick);
            this.alquileresDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.alquileresDataGridView_CellContentClick);
            // 
            // btnRecibir
            // 
            this.btnRecibir.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnRecibir.BackColor = System.Drawing.Color.Teal;
            this.btnRecibir.Enabled = false;
            this.btnRecibir.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnRecibir.FlatAppearance.BorderSize = 0;
            this.btnRecibir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnRecibir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnRecibir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRecibir.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecibir.ForeColor = System.Drawing.Color.White;
            this.btnRecibir.Location = new System.Drawing.Point(285, 102);
            this.btnRecibir.Name = "btnRecibir";
            this.btnRecibir.Size = new System.Drawing.Size(110, 23);
            this.btnRecibir.TabIndex = 3;
            this.btnRecibir.Text = "Recibir libro";
            this.btnRecibir.UseVisualStyleBackColor = false;
            this.btnRecibir.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnHistorial
            // 
            this.btnHistorial.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnHistorial.BackColor = System.Drawing.Color.Teal;
            this.btnHistorial.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnHistorial.FlatAppearance.BorderSize = 0;
            this.btnHistorial.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnHistorial.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnHistorial.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHistorial.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistorial.ForeColor = System.Drawing.Color.White;
            this.btnHistorial.Location = new System.Drawing.Point(471, 102);
            this.btnHistorial.Name = "btnHistorial";
            this.btnHistorial.Size = new System.Drawing.Size(145, 23);
            this.btnHistorial.TabIndex = 4;
            this.btnHistorial.Text = "Alquileres finalizados";
            this.btnHistorial.UseVisualStyleBackColor = false;
            this.btnHistorial.Click += new System.EventHandler(this.button2_Click);
            // 
            // idalquilerDataGridViewTextBoxColumn
            // 
            this.idalquilerDataGridViewTextBoxColumn.DataPropertyName = "Id_alquiler";
            this.idalquilerDataGridViewTextBoxColumn.HeaderText = "Id_alquiler";
            this.idalquilerDataGridViewTextBoxColumn.Name = "idalquilerDataGridViewTextBoxColumn";
            this.idalquilerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idLectorDataGridViewTextBoxColumn
            // 
            this.idLectorDataGridViewTextBoxColumn.DataPropertyName = "Id_Lector";
            this.idLectorDataGridViewTextBoxColumn.DataSource = this.lectoresBindingSource;
            this.idLectorDataGridViewTextBoxColumn.DisplayMember = "Nombres";
            this.idLectorDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.idLectorDataGridViewTextBoxColumn.HeaderText = "Lector";
            this.idLectorDataGridViewTextBoxColumn.Name = "idLectorDataGridViewTextBoxColumn";
            this.idLectorDataGridViewTextBoxColumn.ReadOnly = true;
            this.idLectorDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idLectorDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idLectorDataGridViewTextBoxColumn.ValueMember = "Id_Lector";
            // 
            // lectoresBindingSource
            // 
            this.lectoresBindingSource.DataSource = typeof(AdminLabrary.entidades.Lectores);
            // 
            // idlibroDataGridViewTextBoxColumn
            // 
            this.idlibroDataGridViewTextBoxColumn.DataPropertyName = "Id_libro";
            this.idlibroDataGridViewTextBoxColumn.DataSource = this.librosBindingSource;
            this.idlibroDataGridViewTextBoxColumn.DisplayMember = "Nombre";
            this.idlibroDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.idlibroDataGridViewTextBoxColumn.HeaderText = "Libro";
            this.idlibroDataGridViewTextBoxColumn.Name = "idlibroDataGridViewTextBoxColumn";
            this.idlibroDataGridViewTextBoxColumn.ReadOnly = true;
            this.idlibroDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idlibroDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idlibroDataGridViewTextBoxColumn.ValueMember = "Id_libro";
            // 
            // librosBindingSource
            // 
            this.librosBindingSource.DataSource = typeof(AdminLabrary.entidades.Libros);
            // 
            // entregadoDataGridViewTextBoxColumn
            // 
            this.entregadoDataGridViewTextBoxColumn.DataPropertyName = "Entregado";
            this.entregadoDataGridViewTextBoxColumn.DataSource = this.administradoresBindingSource;
            this.entregadoDataGridViewTextBoxColumn.DisplayMember = "Usuario";
            this.entregadoDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.entregadoDataGridViewTextBoxColumn.HeaderText = "Entregado";
            this.entregadoDataGridViewTextBoxColumn.Name = "entregadoDataGridViewTextBoxColumn";
            this.entregadoDataGridViewTextBoxColumn.ReadOnly = true;
            this.entregadoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.entregadoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.entregadoDataGridViewTextBoxColumn.ValueMember = "Id_Admin";
            // 
            // administradoresBindingSource
            // 
            this.administradoresBindingSource.DataSource = typeof(AdminLabrary.entidades.Administradores);
            // 
            // fechasalidaDataGridViewTextBoxColumn
            // 
            this.fechasalidaDataGridViewTextBoxColumn.DataPropertyName = "fecha_salida";
            this.fechasalidaDataGridViewTextBoxColumn.HeaderText = "fecha_salida";
            this.fechasalidaDataGridViewTextBoxColumn.Name = "fechasalidaDataGridViewTextBoxColumn";
            this.fechasalidaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaprevistadeentregaDataGridViewTextBoxColumn
            // 
            this.fechaprevistadeentregaDataGridViewTextBoxColumn.DataPropertyName = "fecha_prevista_de_entrega";
            this.fechaprevistadeentregaDataGridViewTextBoxColumn.HeaderText = "fecha_prevista_de_entrega";
            this.fechaprevistadeentregaDataGridViewTextBoxColumn.Name = "fechaprevistadeentregaDataGridViewTextBoxColumn";
            this.fechaprevistadeentregaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // alquileresPendientesBindingSource
            // 
            this.alquileresPendientesBindingSource.DataSource = typeof(AdminLabrary.entidades.AlquileresPendientes);
            // 
            // frmAlquileres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(952, 551);
            this.Controls.Add(this.btnHistorial);
            this.Controls.Add(this.btnRecibir);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.alquileresDataGridView);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "frmAlquileres";
            this.Text = "Alquileres";
            this.Load += new System.EventHandler(this.frmAlquileres_Load);
            ((System.ComponentModel.ISupportInitialize)(this.alquileresDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lectoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.librosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.administradoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alquileresPendientesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.DataGridView alquileresDataGridView;
        private System.Windows.Forms.BindingSource alquileresPendientesBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idalquilerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn idLectorDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource lectoresBindingSource;
        private System.Windows.Forms.DataGridViewComboBoxColumn idlibroDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource librosBindingSource;
        private System.Windows.Forms.DataGridViewComboBoxColumn entregadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource administradoresBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechasalidaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaprevistadeentregaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnRecibir;
        private System.Windows.Forms.Button btnHistorial;
    }
}
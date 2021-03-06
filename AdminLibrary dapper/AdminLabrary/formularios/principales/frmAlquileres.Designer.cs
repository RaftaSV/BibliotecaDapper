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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAlquileres));
            this.alquileresDataGridView = new System.Windows.Forms.DataGridView();
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
            this.btnNuevo = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnRecibir = new System.Windows.Forms.Button();
            this.btnHistorial = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.alquileresDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lectoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.librosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.administradoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alquileresPendientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // alquileresDataGridView
            // 
            this.alquileresDataGridView.AllowUserToAddRows = false;
            this.alquileresDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.alquileresDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.alquileresDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.alquileresDataGridView.AutoGenerateColumns = false;
            this.alquileresDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.alquileresDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.alquileresDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.alquileresDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.alquileresDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.alquileresDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
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
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.alquileresDataGridView.DefaultCellStyle = dataGridViewCellStyle7;
            this.alquileresDataGridView.GridColor = System.Drawing.Color.Gainsboro;
            this.alquileresDataGridView.Location = new System.Drawing.Point(6, 238);
            this.alquileresDataGridView.Name = "alquileresDataGridView";
            this.alquileresDataGridView.ReadOnly = true;
            this.alquileresDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.alquileresDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.alquileresDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.alquileresDataGridView.Size = new System.Drawing.Size(912, 367);
            this.alquileresDataGridView.TabIndex = 1;
            this.alquileresDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.alquileresDataGridView_CellClick_1);
            this.alquileresDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.alquileresDataGridView_CellContentClick);
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
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.Teal;
            this.btnNuevo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNuevo.BackgroundImage")));
            this.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNuevo.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNuevo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.Color.White;
            this.btnNuevo.Location = new System.Drawing.Point(481, 8);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(128, 33);
            this.btnNuevo.TabIndex = 2;
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(21, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(151, 143);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(261, 60);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(570, 66);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // btnRecibir
            // 
            this.btnRecibir.BackColor = System.Drawing.Color.Teal;
            this.btnRecibir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRecibir.BackgroundImage")));
            this.btnRecibir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRecibir.Enabled = false;
            this.btnRecibir.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnRecibir.FlatAppearance.BorderSize = 0;
            this.btnRecibir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnRecibir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnRecibir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRecibir.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecibir.ForeColor = System.Drawing.Color.White;
            this.btnRecibir.Location = new System.Drawing.Point(615, 8);
            this.btnRecibir.Name = "btnRecibir";
            this.btnRecibir.Size = new System.Drawing.Size(128, 33);
            this.btnRecibir.TabIndex = 5;
            this.btnRecibir.UseVisualStyleBackColor = false;
            this.btnRecibir.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnHistorial
            // 
            this.btnHistorial.BackColor = System.Drawing.Color.Teal;
            this.btnHistorial.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHistorial.BackgroundImage")));
            this.btnHistorial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHistorial.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnHistorial.FlatAppearance.BorderSize = 0;
            this.btnHistorial.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnHistorial.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnHistorial.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHistorial.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistorial.ForeColor = System.Drawing.Color.White;
            this.btnHistorial.Location = new System.Drawing.Point(749, 8);
            this.btnHistorial.Name = "btnHistorial";
            this.btnHistorial.Size = new System.Drawing.Size(140, 33);
            this.btnHistorial.TabIndex = 6;
            this.btnHistorial.UseVisualStyleBackColor = false;
            this.btnHistorial.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnHistorial);
            this.panel1.Controls.Add(this.btnRecibir);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnNuevo);
            this.panel1.Location = new System.Drawing.Point(12, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(906, 186);
            this.panel1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightCyan;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.button1.Location = new System.Drawing.Point(261, 132);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(247, 33);
            this.button1.TabIndex = 7;
            this.button1.Text = "reporte prestamos pendientes de entrega";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_3);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightCyan;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.MenuText;
            this.button2.Location = new System.Drawing.Point(514, 132);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(317, 33);
            this.button2.TabIndex = 8;
            this.button2.Text = "reporte prestamos finalizados";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // frmAlquileres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(952, 551);
            this.Controls.Add(this.panel1);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
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
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnRecibir;
        private System.Windows.Forms.Button btnHistorial;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.DataGridView alquileresDataGridView;
        private System.Windows.Forms.Button button2;
    }
}
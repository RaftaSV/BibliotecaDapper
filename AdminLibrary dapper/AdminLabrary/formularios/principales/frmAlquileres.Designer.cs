namespace AdminLabrary.formularios
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
            this.fechadeentregaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recibidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.administradoresBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.alquileresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.alquileresDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lectoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.librosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.administradoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.administradoresBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alquileresBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // alquileresDataGridView
            // 
            this.alquileresDataGridView.AllowUserToAddRows = false;
            this.alquileresDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.alquileresDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.alquileresDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.alquileresDataGridView.AutoGenerateColumns = false;
            this.alquileresDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.alquileresDataGridView.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.alquileresDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.alquileresDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idalquilerDataGridViewTextBoxColumn,
            this.idLectorDataGridViewTextBoxColumn,
            this.idlibroDataGridViewTextBoxColumn,
            this.entregadoDataGridViewTextBoxColumn,
            this.fechasalidaDataGridViewTextBoxColumn,
            this.fechaprevistadeentregaDataGridViewTextBoxColumn,
            this.fechadeentregaDataGridViewTextBoxColumn,
            this.recibidoDataGridViewTextBoxColumn});
            this.alquileresDataGridView.DataSource = this.alquileresBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.alquileresDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.alquileresDataGridView.GridColor = System.Drawing.Color.Lime;
            this.alquileresDataGridView.Location = new System.Drawing.Point(12, 140);
            this.alquileresDataGridView.Name = "alquileresDataGridView";
            this.alquileresDataGridView.ReadOnly = true;
            this.alquileresDataGridView.Size = new System.Drawing.Size(912, 409);
            this.alquileresDataGridView.TabIndex = 1;
            this.alquileresDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.alquileresDataGridView_CellContentClick);
            // 
            // idalquilerDataGridViewTextBoxColumn
            // 
            this.idalquilerDataGridViewTextBoxColumn.DataPropertyName = "Id_alquiler";
            this.idalquilerDataGridViewTextBoxColumn.HeaderText = "ID alquiler";
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
            this.entregadoDataGridViewTextBoxColumn.HeaderText = "Libro entregado por";
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
            this.fechasalidaDataGridViewTextBoxColumn.HeaderText = "fecha de salida";
            this.fechasalidaDataGridViewTextBoxColumn.Name = "fechasalidaDataGridViewTextBoxColumn";
            this.fechasalidaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaprevistadeentregaDataGridViewTextBoxColumn
            // 
            this.fechaprevistadeentregaDataGridViewTextBoxColumn.DataPropertyName = "fecha_prevista_de_entrega";
            this.fechaprevistadeentregaDataGridViewTextBoxColumn.HeaderText = "Fecha prevista de entrega";
            this.fechaprevistadeentregaDataGridViewTextBoxColumn.Name = "fechaprevistadeentregaDataGridViewTextBoxColumn";
            this.fechaprevistadeentregaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechadeentregaDataGridViewTextBoxColumn
            // 
            this.fechadeentregaDataGridViewTextBoxColumn.DataPropertyName = "fecha_de_entrega";
            this.fechadeentregaDataGridViewTextBoxColumn.HeaderText = "Fecha de entrega";
            this.fechadeentregaDataGridViewTextBoxColumn.Name = "fechadeentregaDataGridViewTextBoxColumn";
            this.fechadeentregaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // recibidoDataGridViewTextBoxColumn
            // 
            this.recibidoDataGridViewTextBoxColumn.DataPropertyName = "Recibido";
            this.recibidoDataGridViewTextBoxColumn.DataSource = this.administradoresBindingSource1;
            this.recibidoDataGridViewTextBoxColumn.DisplayMember = "Usuario";
            this.recibidoDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.recibidoDataGridViewTextBoxColumn.HeaderText = "Libro recibido por";
            this.recibidoDataGridViewTextBoxColumn.Name = "recibidoDataGridViewTextBoxColumn";
            this.recibidoDataGridViewTextBoxColumn.ReadOnly = true;
            this.recibidoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.recibidoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.recibidoDataGridViewTextBoxColumn.ValueMember = "Id_Admin";
            // 
            // administradoresBindingSource1
            // 
            this.administradoresBindingSource1.DataSource = typeof(AdminLabrary.entidades.Administradores);
            // 
            // alquileresBindingSource
            // 
            this.alquileresBindingSource.DataSource = typeof(AdminLabrary.entidades.Alquileres);
            // 
            // frmAlquileres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(952, 551);
            this.Controls.Add(this.alquileresDataGridView);
            this.Name = "frmAlquileres";
            this.Text = "frmAlquileres";
            this.Load += new System.EventHandler(this.frmAlquileres_Load);
            ((System.ComponentModel.ISupportInitialize)(this.alquileresDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lectoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.librosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.administradoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.administradoresBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alquileresBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource alquileresBindingSource;
        private System.Windows.Forms.DataGridView alquileresDataGridView;
        private System.Windows.Forms.BindingSource lectoresBindingSource;
        private System.Windows.Forms.BindingSource librosBindingSource;
        private System.Windows.Forms.BindingSource administradoresBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idalquilerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn idLectorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn idlibroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn entregadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechasalidaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaprevistadeentregaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechadeentregaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn recibidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource administradoresBindingSource1;
    }
}
namespace AdminLabrary.formularios.principales
{
    partial class frmAutor
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
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.administradoresDataGridView = new System.Windows.Forms.DataGridView();
            this.idautorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechanacimientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nacionalidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.administradoresDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoresBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.Teal;
            this.btnNuevo.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatAppearance.CheckedBackColor = System.Drawing.Color.Teal;
            this.btnNuevo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNuevo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.Color.White;
            this.btnNuevo.Location = new System.Drawing.Point(12, 57);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(130, 41);
            this.btnNuevo.TabIndex = 4;
            this.btnNuevo.Text = "Nuevo autor";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Teal;
            this.btnEliminar.Enabled = false;
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Teal;
            this.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(566, 57);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(130, 36);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.Teal;
            this.btnEditar.Enabled = false;
            this.btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Teal;
            this.btnEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(288, 57);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(130, 36);
            this.btnEditar.TabIndex = 6;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // administradoresDataGridView
            // 
            this.administradoresDataGridView.AllowUserToAddRows = false;
            this.administradoresDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.administradoresDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.administradoresDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.administradoresDataGridView.AutoGenerateColumns = false;
            this.administradoresDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.administradoresDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.administradoresDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.administradoresDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.administradoresDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.administradoresDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.administradoresDataGridView.ColumnHeadersHeight = 40;
            this.administradoresDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idautorDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.fechanacimientoDataGridViewTextBoxColumn,
            this.nacionalidadDataGridViewTextBoxColumn,
            this.estadoDataGridViewTextBoxColumn});
            this.administradoresDataGridView.DataSource = this.autoresBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.administradoresDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.administradoresDataGridView.GridColor = System.Drawing.Color.Gainsboro;
            this.administradoresDataGridView.Location = new System.Drawing.Point(12, 130);
            this.administradoresDataGridView.Name = "administradoresDataGridView";
            this.administradoresDataGridView.ReadOnly = true;
            this.administradoresDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.administradoresDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.administradoresDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.administradoresDataGridView.Size = new System.Drawing.Size(912, 409);
            this.administradoresDataGridView.TabIndex = 8;
            this.administradoresDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.autoresDataGridView_CellClick);
            // 
            // idautorDataGridViewTextBoxColumn
            // 
            this.idautorDataGridViewTextBoxColumn.DataPropertyName = "Id_autor";
            this.idautorDataGridViewTextBoxColumn.FillWeight = 40F;
            this.idautorDataGridViewTextBoxColumn.HeaderText = "Id_autor";
            this.idautorDataGridViewTextBoxColumn.Name = "idautorDataGridViewTextBoxColumn";
            this.idautorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.FillWeight = 120F;
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechanacimientoDataGridViewTextBoxColumn
            // 
            this.fechanacimientoDataGridViewTextBoxColumn.DataPropertyName = "fecha_nacimiento";
            this.fechanacimientoDataGridViewTextBoxColumn.HeaderText = "fecha_nacimiento";
            this.fechanacimientoDataGridViewTextBoxColumn.Name = "fechanacimientoDataGridViewTextBoxColumn";
            this.fechanacimientoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nacionalidadDataGridViewTextBoxColumn
            // 
            this.nacionalidadDataGridViewTextBoxColumn.DataPropertyName = "Nacionalidad";
            this.nacionalidadDataGridViewTextBoxColumn.HeaderText = "Nacionalidad";
            this.nacionalidadDataGridViewTextBoxColumn.Name = "nacionalidadDataGridViewTextBoxColumn";
            this.nacionalidadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            this.estadoDataGridViewTextBoxColumn.DataPropertyName = "estado";
            this.estadoDataGridViewTextBoxColumn.HeaderText = "estado";
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            this.estadoDataGridViewTextBoxColumn.ReadOnly = true;
            this.estadoDataGridViewTextBoxColumn.Visible = false;
            // 
            // autoresBindingSource
            // 
            this.autoresBindingSource.DataSource = typeof(AdminLabrary.entidades.Autores);
            // 
            // frmAutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(952, 551);
            this.Controls.Add(this.administradoresDataGridView);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNuevo);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "frmAutor";
            this.Text = "AdminLabrary-autor";
            this.Load += new System.EventHandler(this.FpAutor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.administradoresDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoresBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource autoresBindingSource;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.DataGridView administradoresDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn idautorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechanacimientoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nacionalidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
    }
}
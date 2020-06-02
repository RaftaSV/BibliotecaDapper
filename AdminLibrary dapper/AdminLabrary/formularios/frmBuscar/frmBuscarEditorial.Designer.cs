namespace AdminLabrary.formularios.frmBuscar
{
    partial class frmBuscarEditorial
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
            this.dtgEditoriales = new System.Windows.Forms.DataGridView();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.idEditorialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editorialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fundadaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editorialesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dtgEditoriales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editorialesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgEditoriales
            // 
            this.dtgEditoriales.AllowUserToAddRows = false;
            this.dtgEditoriales.AllowUserToDeleteRows = false;
            this.dtgEditoriales.AutoGenerateColumns = false;
            this.dtgEditoriales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgEditoriales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgEditoriales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idEditorialDataGridViewTextBoxColumn,
            this.editorialDataGridViewTextBoxColumn,
            this.fundadaDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn});
            this.dtgEditoriales.DataSource = this.editorialesBindingSource;
            this.dtgEditoriales.Location = new System.Drawing.Point(3, 100);
            this.dtgEditoriales.Name = "dtgEditoriales";
            this.dtgEditoriales.ReadOnly = true;
            this.dtgEditoriales.Size = new System.Drawing.Size(816, 347);
            this.dtgEditoriales.TabIndex = 7;
            this.dtgEditoriales.DoubleClick += new System.EventHandler(this.dtgEditoriales_DoubleClick);
            this.dtgEditoriales.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtgEditoriales_KeyDown);
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.Color.LightSkyBlue;
            this.txtBuscar.Location = new System.Drawing.Point(606, 74);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(213, 20);
            this.txtBuscar.TabIndex = 6;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // idEditorialDataGridViewTextBoxColumn
            // 
            this.idEditorialDataGridViewTextBoxColumn.DataPropertyName = "Id_Editorial";
            this.idEditorialDataGridViewTextBoxColumn.HeaderText = "Id_Editorial";
            this.idEditorialDataGridViewTextBoxColumn.Name = "idEditorialDataGridViewTextBoxColumn";
            this.idEditorialDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // editorialDataGridViewTextBoxColumn
            // 
            this.editorialDataGridViewTextBoxColumn.DataPropertyName = "Editorial";
            this.editorialDataGridViewTextBoxColumn.HeaderText = "Editorial";
            this.editorialDataGridViewTextBoxColumn.Name = "editorialDataGridViewTextBoxColumn";
            this.editorialDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fundadaDataGridViewTextBoxColumn
            // 
            this.fundadaDataGridViewTextBoxColumn.DataPropertyName = "Fundada";
            this.fundadaDataGridViewTextBoxColumn.HeaderText = "Fundada";
            this.fundadaDataGridViewTextBoxColumn.Name = "fundadaDataGridViewTextBoxColumn";
            this.fundadaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            this.direccionDataGridViewTextBoxColumn.DataPropertyName = "Direccion";
            this.direccionDataGridViewTextBoxColumn.HeaderText = "Direccion";
            this.direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            this.direccionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // editorialesBindingSource
            // 
            this.editorialesBindingSource.DataSource = typeof(AdminLabrary.entidades.Editoriales);
            // 
            // frmBuscarEditorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(831, 459);
            this.Controls.Add(this.dtgEditoriales);
            this.Controls.Add(this.txtBuscar);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "frmBuscarEditorial";
            this.Text = "frmEditorial";
            this.Load += new System.EventHandler(this.frmBuscarEditorial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgEditoriales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editorialesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgEditoriales;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEditorialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn editorialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fundadaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource editorialesBindingSource;
    }
}
namespace AdminLabrary.formularios.frmBuscar
{
    partial class frmBuscarLector
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
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.dgvLectores = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLectores)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(3, 74);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(213, 20);
            this.txtBuscar.TabIndex = 2;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // dgvLectores
            // 
            this.dgvLectores.AllowUserToAddRows = false;
            this.dgvLectores.AllowUserToDeleteRows = false;
            this.dgvLectores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLectores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLectores.Location = new System.Drawing.Point(3, 138);
            this.dgvLectores.Name = "dgvLectores";
            this.dgvLectores.ReadOnly = true;
            this.dgvLectores.Size = new System.Drawing.Size(816, 222);
            this.dgvLectores.TabIndex = 3;
            this.dgvLectores.DoubleClick += new System.EventHandler(this.dgvLectores_DoubleClick);
            this.dgvLectores.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvLectores_KeyDown);
            // 
            // frmBuscarLector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 450);
            this.Controls.Add(this.dgvLectores);
            this.Controls.Add(this.txtBuscar);
            this.Name = "frmBuscarLector";
            this.Text = "frmBuscarLector";
            this.Load += new System.EventHandler(this.frmBuscarLector_Load);
            this.DoubleClick += new System.EventHandler(this.frmBuscarLector_DoubleClick);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLectores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.DataGridView dgvLectores;
    }
}
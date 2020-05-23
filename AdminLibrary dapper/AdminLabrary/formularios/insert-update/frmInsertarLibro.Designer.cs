namespace AdminLabrary.formularios.insert_update
{
    partial class frmInsertarLibro
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
            System.Windows.Forms.Label añoLabel;
            System.Windows.Forms.Label cantidadLabel;
            System.Windows.Forms.Label id_autorLabel;
            System.Windows.Forms.Label id_categoriaLabel;
            System.Windows.Forms.Label id_EditorialLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label numero_edicionLabel;
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.txtEditorial = new System.Windows.Forms.TextBox();
            this.btnAutor = new System.Windows.Forms.Button();
            this.btnEditorial = new System.Windows.Forms.Button();
            this.añoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.librosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cantidadTextBox = new System.Windows.Forms.TextBox();
            this.id_autorTextBox = new System.Windows.Forms.TextBox();
            this.id_categoriaComboBox = new System.Windows.Forms.ComboBox();
            this.categoriasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.id_EditorialTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.numero_edicionTextBox = new System.Windows.Forms.TextBox();
            añoLabel = new System.Windows.Forms.Label();
            cantidadLabel = new System.Windows.Forms.Label();
            id_autorLabel = new System.Windows.Forms.Label();
            id_categoriaLabel = new System.Windows.Forms.Label();
            id_EditorialLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            numero_edicionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.librosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // añoLabel
            // 
            añoLabel.AutoSize = true;
            añoLabel.Location = new System.Drawing.Point(86, 58);
            añoLabel.Name = "añoLabel";
            añoLabel.Size = new System.Drawing.Size(35, 16);
            añoLabel.TabIndex = 21;
            añoLabel.Text = "Año:";
            // 
            // cantidadLabel
            // 
            cantidadLabel.AutoSize = true;
            cantidadLabel.Location = new System.Drawing.Point(70, 96);
            cantidadLabel.Name = "cantidadLabel";
            cantidadLabel.Size = new System.Drawing.Size(63, 16);
            cantidadLabel.TabIndex = 23;
            cantidadLabel.Text = "cantidad:";
            // 
            // id_autorLabel
            // 
            id_autorLabel.AutoSize = true;
            id_autorLabel.Location = new System.Drawing.Point(78, 136);
            id_autorLabel.Name = "id_autorLabel";
            id_autorLabel.Size = new System.Drawing.Size(55, 16);
            id_autorLabel.TabIndex = 25;
            id_autorLabel.Text = "Id autor:";
            // 
            // id_categoriaLabel
            // 
            id_categoriaLabel.AutoSize = true;
            id_categoriaLabel.Location = new System.Drawing.Point(51, 176);
            id_categoriaLabel.Name = "id_categoriaLabel";
            id_categoriaLabel.Size = new System.Drawing.Size(82, 16);
            id_categoriaLabel.TabIndex = 27;
            id_categoriaLabel.Text = "Id categoria:";
            // 
            // id_EditorialLabel
            // 
            id_EditorialLabel.AutoSize = true;
            id_EditorialLabel.Location = new System.Drawing.Point(59, 217);
            id_EditorialLabel.Name = "id_EditorialLabel";
            id_EditorialLabel.Size = new System.Drawing.Size(74, 16);
            id_EditorialLabel.TabIndex = 29;
            id_EditorialLabel.Text = "Id Editorial:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(73, 19);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(60, 16);
            nombreLabel.TabIndex = 31;
            nombreLabel.Text = "Nombre:";
            // 
            // numero_edicionLabel
            // 
            numero_edicionLabel.AutoSize = true;
            numero_edicionLabel.Location = new System.Drawing.Point(27, 258);
            numero_edicionLabel.Name = "numero_edicionLabel";
            numero_edicionLabel.Size = new System.Drawing.Size(106, 16);
            numero_edicionLabel.TabIndex = 33;
            numero_edicionLabel.Text = "Numero edicion:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(62, 346);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(74, 44);
            this.btnGuardar.TabIndex = 14;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtAutor
            // 
            this.txtAutor.Enabled = false;
            this.txtAutor.Location = new System.Drawing.Point(150, 137);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(236, 22);
            this.txtAutor.TabIndex = 17;
            // 
            // txtEditorial
            // 
            this.txtEditorial.Enabled = false;
            this.txtEditorial.Location = new System.Drawing.Point(150, 216);
            this.txtEditorial.Name = "txtEditorial";
            this.txtEditorial.Size = new System.Drawing.Size(236, 22);
            this.txtEditorial.TabIndex = 18;
            // 
            // btnAutor
            // 
            this.btnAutor.Location = new System.Drawing.Point(421, 136);
            this.btnAutor.Name = "btnAutor";
            this.btnAutor.Size = new System.Drawing.Size(75, 24);
            this.btnAutor.TabIndex = 4;
            this.btnAutor.Text = "Elegir";
            this.btnAutor.UseVisualStyleBackColor = true;
            this.btnAutor.Click += new System.EventHandler(this.btnAutor_Click);
            // 
            // btnEditorial
            // 
            this.btnEditorial.Location = new System.Drawing.Point(421, 215);
            this.btnEditorial.Name = "btnEditorial";
            this.btnEditorial.Size = new System.Drawing.Size(75, 24);
            this.btnEditorial.TabIndex = 6;
            this.btnEditorial.Text = "Elegir";
            this.btnEditorial.UseVisualStyleBackColor = true;
            this.btnEditorial.Click += new System.EventHandler(this.btnEditorial_Click);
            // 
            // añoDateTimePicker
            // 
            this.añoDateTimePicker.CustomFormat = "yyyy -  MM - dd";
            this.añoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.librosBindingSource, "Año", true));
            this.añoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.añoDateTimePicker.Location = new System.Drawing.Point(150, 53);
            this.añoDateTimePicker.Name = "añoDateTimePicker";
            this.añoDateTimePicker.Size = new System.Drawing.Size(236, 22);
            this.añoDateTimePicker.TabIndex = 2;
            // 
            // librosBindingSource
            // 
            this.librosBindingSource.DataSource = typeof(AdminLabrary.entidades.Libros);
            // 
            // cantidadTextBox
            // 
            this.cantidadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.librosBindingSource, "cantidad", true));
            this.cantidadTextBox.Location = new System.Drawing.Point(150, 93);
            this.cantidadTextBox.Name = "cantidadTextBox";
            this.cantidadTextBox.Size = new System.Drawing.Size(236, 22);
            this.cantidadTextBox.TabIndex = 3;
            // 
            // id_autorTextBox
            // 
            this.id_autorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.librosBindingSource, "Id_autor", true));
            this.id_autorTextBox.Enabled = false;
            this.id_autorTextBox.Location = new System.Drawing.Point(392, 137);
            this.id_autorTextBox.Name = "id_autorTextBox";
            this.id_autorTextBox.Size = new System.Drawing.Size(23, 22);
            this.id_autorTextBox.TabIndex = 26;
            // 
            // id_categoriaComboBox
            // 
            this.id_categoriaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.librosBindingSource, "Id_categoria", true));
            this.id_categoriaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.librosBindingSource, "Id_categoria", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.id_categoriaComboBox.DataSource = this.categoriasBindingSource;
            this.id_categoriaComboBox.DisplayMember = "Categoria";
            this.id_categoriaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.id_categoriaComboBox.FormattingEnabled = true;
            this.id_categoriaComboBox.Location = new System.Drawing.Point(150, 176);
            this.id_categoriaComboBox.Name = "id_categoriaComboBox";
            this.id_categoriaComboBox.Size = new System.Drawing.Size(236, 24);
            this.id_categoriaComboBox.TabIndex = 5;
            this.id_categoriaComboBox.ValueMember = "Id_categoria";
        
            // 
            // categoriasBindingSource
            // 
            this.categoriasBindingSource.DataSource = typeof(AdminLabrary.entidades.Categorias);
            // 
            // id_EditorialTextBox
            // 
            this.id_EditorialTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.librosBindingSource, "Id_Editorial", true));
            this.id_EditorialTextBox.Enabled = false;
            this.id_EditorialTextBox.Location = new System.Drawing.Point(392, 217);
            this.id_EditorialTextBox.Name = "id_EditorialTextBox";
            this.id_EditorialTextBox.Size = new System.Drawing.Size(23, 22);
            this.id_EditorialTextBox.TabIndex = 30;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.librosBindingSource, "Nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(150, 16);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(236, 22);
            this.nombreTextBox.TabIndex = 1;
            // 
            // numero_edicionTextBox
            // 
            this.numero_edicionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.librosBindingSource, "Numero_edicion", true));
            this.numero_edicionTextBox.Location = new System.Drawing.Point(150, 255);
            this.numero_edicionTextBox.Name = "numero_edicionTextBox";
            this.numero_edicionTextBox.Size = new System.Drawing.Size(236, 22);
            this.numero_edicionTextBox.TabIndex = 7;
            // 
            // frmInsertarLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 402);
            this.Controls.Add(añoLabel);
            this.Controls.Add(this.añoDateTimePicker);
            this.Controls.Add(cantidadLabel);
            this.Controls.Add(this.cantidadTextBox);
            this.Controls.Add(id_autorLabel);
            this.Controls.Add(this.id_autorTextBox);
            this.Controls.Add(id_categoriaLabel);
            this.Controls.Add(this.id_categoriaComboBox);
            this.Controls.Add(id_EditorialLabel);
            this.Controls.Add(this.id_EditorialTextBox);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(numero_edicionLabel);
            this.Controls.Add(this.numero_edicionTextBox);
            this.Controls.Add(this.btnEditorial);
            this.Controls.Add(this.btnAutor);
            this.Controls.Add(this.txtEditorial);
            this.Controls.Add(this.txtAutor);
            this.Controls.Add(this.btnGuardar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmInsertarLibro";
            this.Text = "frmInsertarLibro";
            this.Load += new System.EventHandler(this.frmInsertarLibro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.librosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource categoriasBindingSource;
        private System.Windows.Forms.Button btnGuardar;
        public System.Windows.Forms.TextBox txtAutor;
        public System.Windows.Forms.TextBox txtEditorial;
        private System.Windows.Forms.Button btnAutor;
        private System.Windows.Forms.Button btnEditorial;
        private System.Windows.Forms.BindingSource librosBindingSource;
        private System.Windows.Forms.DateTimePicker añoDateTimePicker;
        private System.Windows.Forms.TextBox cantidadTextBox;
        public System.Windows.Forms.TextBox id_autorTextBox;
        private System.Windows.Forms.ComboBox id_categoriaComboBox;
        public System.Windows.Forms.TextBox id_EditorialTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox numero_edicionTextBox;
    }
}
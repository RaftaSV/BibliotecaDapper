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
            this.librosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cantidadTextBox = new System.Windows.Forms.TextBox();
            this.id_autorComboBox = new System.Windows.Forms.ComboBox();
            this.autoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.id_categoriaComboBox = new System.Windows.Forms.ComboBox();
            this.categoriasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.id_EditorialComboBox = new System.Windows.Forms.ComboBox();
            this.editorialesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.numero_edicionTextBox = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.añoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            añoLabel = new System.Windows.Forms.Label();
            cantidadLabel = new System.Windows.Forms.Label();
            id_autorLabel = new System.Windows.Forms.Label();
            id_categoriaLabel = new System.Windows.Forms.Label();
            id_EditorialLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            numero_edicionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.librosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editorialesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // añoLabel
            // 
            añoLabel.AutoSize = true;
            añoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            añoLabel.Location = new System.Drawing.Point(41, 100);
            añoLabel.Name = "añoLabel";
            añoLabel.Size = new System.Drawing.Size(35, 16);
            añoLabel.TabIndex = 1;
            añoLabel.Text = "Año:";
            // 
            // cantidadLabel
            // 
            cantidadLabel.AutoSize = true;
            cantidadLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cantidadLabel.Location = new System.Drawing.Point(41, 63);
            cantidadLabel.Name = "cantidadLabel";
            cantidadLabel.Size = new System.Drawing.Size(63, 16);
            cantidadLabel.TabIndex = 3;
            cantidadLabel.Text = "cantidad:";
            // 
            // id_autorLabel
            // 
            id_autorLabel.AutoSize = true;
            id_autorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            id_autorLabel.Location = new System.Drawing.Point(41, 142);
            id_autorLabel.Name = "id_autorLabel";
            id_autorLabel.Size = new System.Drawing.Size(42, 16);
            id_autorLabel.TabIndex = 5;
            id_autorLabel.Text = "Autor:";
            // 
            // id_categoriaLabel
            // 
            id_categoriaLabel.AutoSize = true;
            id_categoriaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            id_categoriaLabel.Location = new System.Drawing.Point(41, 183);
            id_categoriaLabel.Name = "id_categoriaLabel";
            id_categoriaLabel.Size = new System.Drawing.Size(68, 16);
            id_categoriaLabel.TabIndex = 7;
            id_categoriaLabel.Text = "categoria:";
            // 
            // id_EditorialLabel
            // 
            id_EditorialLabel.AutoSize = true;
            id_EditorialLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            id_EditorialLabel.Location = new System.Drawing.Point(41, 222);
            id_EditorialLabel.Name = "id_EditorialLabel";
            id_EditorialLabel.Size = new System.Drawing.Size(60, 16);
            id_EditorialLabel.TabIndex = 9;
            id_EditorialLabel.Text = "Editorial:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nombreLabel.Location = new System.Drawing.Point(41, 22);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(60, 16);
            nombreLabel.TabIndex = 11;
            nombreLabel.Text = "Nombre:";
            // 
            // numero_edicionLabel
            // 
            numero_edicionLabel.AutoSize = true;
            numero_edicionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            numero_edicionLabel.Location = new System.Drawing.Point(41, 261);
            numero_edicionLabel.Name = "numero_edicionLabel";
            numero_edicionLabel.Size = new System.Drawing.Size(106, 16);
            numero_edicionLabel.TabIndex = 13;
            numero_edicionLabel.Text = "Numero edicion:";
            // 
            // librosBindingSource
            // 
            this.librosBindingSource.DataSource = typeof(AdminLabrary.entidades.Libros);
            // 
            // cantidadTextBox
            // 
            this.cantidadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.librosBindingSource, "cantidad", true));
            this.cantidadTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cantidadTextBox.Location = new System.Drawing.Point(160, 60);
            this.cantidadTextBox.Name = "cantidadTextBox";
            this.cantidadTextBox.Size = new System.Drawing.Size(191, 22);
            this.cantidadTextBox.TabIndex = 2;
            // 
            // id_autorComboBox
            // 
            this.id_autorComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.librosBindingSource, "Id_autor", true));
            this.id_autorComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.librosBindingSource, "Id_autor", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.id_autorComboBox.DataSource = this.autoresBindingSource;
            this.id_autorComboBox.DisplayMember = "Nombre";
            this.id_autorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.id_autorComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_autorComboBox.FormattingEnabled = true;
            this.id_autorComboBox.Location = new System.Drawing.Point(160, 139);
            this.id_autorComboBox.Name = "id_autorComboBox";
            this.id_autorComboBox.Size = new System.Drawing.Size(191, 24);
            this.id_autorComboBox.TabIndex = 4;
            this.id_autorComboBox.ValueMember = "Id_autor";
            // 
            // autoresBindingSource
            // 
            this.autoresBindingSource.DataSource = typeof(AdminLabrary.entidades.Autores);
            // 
            // id_categoriaComboBox
            // 
            this.id_categoriaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.librosBindingSource, "Id_categoria", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.id_categoriaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.librosBindingSource, "Id_categoria", true));
            this.id_categoriaComboBox.DataSource = this.categoriasBindingSource;
            this.id_categoriaComboBox.DisplayMember = "Categoria";
            this.id_categoriaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.id_categoriaComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_categoriaComboBox.FormattingEnabled = true;
            this.id_categoriaComboBox.Location = new System.Drawing.Point(160, 180);
            this.id_categoriaComboBox.Name = "id_categoriaComboBox";
            this.id_categoriaComboBox.Size = new System.Drawing.Size(191, 24);
            this.id_categoriaComboBox.TabIndex = 5;
            this.id_categoriaComboBox.ValueMember = "Id_categoria";
            // 
            // categoriasBindingSource
            // 
            this.categoriasBindingSource.DataSource = typeof(AdminLabrary.entidades.Categorias);
            // 
            // id_EditorialComboBox
            // 
            this.id_EditorialComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.librosBindingSource, "Id_Editorial", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.id_EditorialComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.librosBindingSource, "Id_Editorial", true));
            this.id_EditorialComboBox.DataSource = this.editorialesBindingSource;
            this.id_EditorialComboBox.DisplayMember = "Editorial";
            this.id_EditorialComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.id_EditorialComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_EditorialComboBox.FormattingEnabled = true;
            this.id_EditorialComboBox.Location = new System.Drawing.Point(160, 219);
            this.id_EditorialComboBox.Name = "id_EditorialComboBox";
            this.id_EditorialComboBox.Size = new System.Drawing.Size(191, 24);
            this.id_EditorialComboBox.TabIndex = 6;
            this.id_EditorialComboBox.ValueMember = "Id_Editorial";
            // 
            // editorialesBindingSource
            // 
            this.editorialesBindingSource.DataSource = typeof(AdminLabrary.entidades.Editoriales);
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.librosBindingSource, "Nombre", true));
            this.nombreTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreTextBox.Location = new System.Drawing.Point(160, 19);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(191, 22);
            this.nombreTextBox.TabIndex = 1;
            // 
            // numero_edicionTextBox
            // 
            this.numero_edicionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.librosBindingSource, "Numero_edicion", true));
            this.numero_edicionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numero_edicionTextBox.Location = new System.Drawing.Point(160, 258);
            this.numero_edicionTextBox.Name = "numero_edicionTextBox";
            this.numero_edicionTextBox.Size = new System.Drawing.Size(191, 22);
            this.numero_edicionTextBox.TabIndex = 7;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(44, 330);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(108, 36);
            this.btnGuardar.TabIndex = 14;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // añoDateTimePicker
            // 
            this.añoDateTimePicker.CustomFormat = "yyyy- MM - dd";
            this.añoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.librosBindingSource, "Año", true));
            this.añoDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.añoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.añoDateTimePicker.Location = new System.Drawing.Point(160, 100);
            this.añoDateTimePicker.Name = "añoDateTimePicker";
            this.añoDateTimePicker.Size = new System.Drawing.Size(191, 22);
            this.añoDateTimePicker.TabIndex = 15;
            // 
            // frmInsertarLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 411);
            this.Controls.Add(this.añoDateTimePicker);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(añoLabel);
            this.Controls.Add(cantidadLabel);
            this.Controls.Add(this.cantidadTextBox);
            this.Controls.Add(id_autorLabel);
            this.Controls.Add(this.id_autorComboBox);
            this.Controls.Add(id_categoriaLabel);
            this.Controls.Add(this.id_categoriaComboBox);
            this.Controls.Add(id_EditorialLabel);
            this.Controls.Add(this.id_EditorialComboBox);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(numero_edicionLabel);
            this.Controls.Add(this.numero_edicionTextBox);
            this.Name = "frmInsertarLibro";
            this.Text = "frmInsertarLibro";
            this.Load += new System.EventHandler(this.frmInsertarLibro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.librosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editorialesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource librosBindingSource;
        private System.Windows.Forms.TextBox cantidadTextBox;
        private System.Windows.Forms.ComboBox id_autorComboBox;
        private System.Windows.Forms.ComboBox id_categoriaComboBox;
        private System.Windows.Forms.ComboBox id_EditorialComboBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox numero_edicionTextBox;
        private System.Windows.Forms.BindingSource autoresBindingSource;
        private System.Windows.Forms.BindingSource categoriasBindingSource;
        private System.Windows.Forms.BindingSource editorialesBindingSource;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DateTimePicker añoDateTimePicker;
    }
}
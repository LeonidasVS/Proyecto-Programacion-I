namespace CapaVista
{
    partial class MantenimientoMetodoPago
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MantenimientoMetodoPago));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbInactivos = new System.Windows.Forms.RadioButton();
            this.rdbActivos = new System.Windows.Forms.RadioButton();
            this.gbxEstado = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.filtrarPorNombre = new System.Windows.Forms.TextBox();
            this.Bordes = new System.Windows.Forms.PictureBox();
            this.TablaMetodoPago = new System.Windows.Forms.DataGridView();
            this.idMetodoPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FormaDePago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.AñadirProducto = new System.Windows.Forms.Button();
            this.Regresar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.gbxEstado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Bordes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TablaMetodoPago)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbInactivos);
            this.groupBox1.Controls.Add(this.rdbActivos);
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(564, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(122, 97);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtrar Por Estado";
            // 
            // rdbInactivos
            // 
            this.rdbInactivos.AutoSize = true;
            this.rdbInactivos.Location = new System.Drawing.Point(17, 62);
            this.rdbInactivos.Name = "rdbInactivos";
            this.rdbInactivos.Size = new System.Drawing.Size(74, 20);
            this.rdbInactivos.TabIndex = 34;
            this.rdbInactivos.Text = "Inactivos";
            this.rdbInactivos.UseVisualStyleBackColor = true;
            this.rdbInactivos.CheckedChanged += new System.EventHandler(this.rdbInactivos_CheckedChanged);
            // 
            // rdbActivos
            // 
            this.rdbActivos.AutoSize = true;
            this.rdbActivos.Checked = true;
            this.rdbActivos.Location = new System.Drawing.Point(17, 32);
            this.rdbActivos.Name = "rdbActivos";
            this.rdbActivos.Size = new System.Drawing.Size(64, 20);
            this.rdbActivos.TabIndex = 33;
            this.rdbActivos.TabStop = true;
            this.rdbActivos.Text = "Activos";
            this.rdbActivos.UseVisualStyleBackColor = true;
            this.rdbActivos.CheckedChanged += new System.EventHandler(this.rdbActivos_CheckedChanged);
            // 
            // gbxEstado
            // 
            this.gbxEstado.Controls.Add(this.label2);
            this.gbxEstado.Controls.Add(this.filtrarPorNombre);
            this.gbxEstado.Controls.Add(this.Bordes);
            this.gbxEstado.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxEstado.ForeColor = System.Drawing.Color.White;
            this.gbxEstado.Location = new System.Drawing.Point(23, 39);
            this.gbxEstado.Name = "gbxEstado";
            this.gbxEstado.Size = new System.Drawing.Size(518, 97);
            this.gbxEstado.TabIndex = 37;
            this.gbxEstado.TabStop = false;
            this.gbxEstado.Text = "Filtrar Por Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(231, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 31;
            this.label2.Text = "Nombre";
            // 
            // filtrarPorNombre
            // 
            this.filtrarPorNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.filtrarPorNombre.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filtrarPorNombre.Location = new System.Drawing.Point(121, 51);
            this.filtrarPorNombre.Name = "filtrarPorNombre";
            this.filtrarPorNombre.Size = new System.Drawing.Size(272, 13);
            this.filtrarPorNombre.TabIndex = 0;
            this.filtrarPorNombre.TextChanged += new System.EventHandler(this.filtrarPorNombre_TextChanged);
            // 
            // Bordes
            // 
            this.Bordes.Image = global::CapaVista.Properties.Resources.texbox;
            this.Bordes.Location = new System.Drawing.Point(111, 42);
            this.Bordes.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Bordes.Name = "Bordes";
            this.Bordes.Size = new System.Drawing.Size(292, 31);
            this.Bordes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Bordes.TabIndex = 28;
            this.Bordes.TabStop = false;
            // 
            // TablaMetodoPago
            // 
            this.TablaMetodoPago.BackgroundColor = System.Drawing.Color.White;
            this.TablaMetodoPago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaMetodoPago.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idMetodoPago,
            this.FormaDePago,
            this.Estado,
            this.Editar,
            this.Eliminar});
            this.TablaMetodoPago.Location = new System.Drawing.Point(21, 159);
            this.TablaMetodoPago.Name = "TablaMetodoPago";
            this.TablaMetodoPago.Size = new System.Drawing.Size(673, 196);
            this.TablaMetodoPago.TabIndex = 40;
            this.TablaMetodoPago.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TablaMetodoPago_CellClick);
            // 
            // idMetodoPago
            // 
            this.idMetodoPago.DataPropertyName = "idMetodoPago";
            this.idMetodoPago.HeaderText = "Codigo";
            this.idMetodoPago.Name = "idMetodoPago";
            this.idMetodoPago.ReadOnly = true;
            this.idMetodoPago.Width = 50;
            // 
            // FormaDePago
            // 
            this.FormaDePago.DataPropertyName = "FormaDePago";
            this.FormaDePago.HeaderText = "Forma De Pago";
            this.FormaDePago.Name = "FormaDePago";
            this.FormaDePago.ReadOnly = true;
            this.FormaDePago.Width = 230;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "Estado";
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // Editar
            // 
            this.Editar.HeaderText = "Editar";
            this.Editar.Image = global::CapaVista.Properties.Resources.edit;
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            this.Editar.Width = 125;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "ELiminar";
            this.Eliminar.Image = global::CapaVista.Properties.Resources.delete1;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Width = 125;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Editar";
            this.dataGridViewImageColumn1.Image = global::CapaVista.Properties.Resources.edit;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Width = 125;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "ELiminar";
            this.dataGridViewImageColumn2.Image = global::CapaVista.Properties.Resources.delete1;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            this.dataGridViewImageColumn2.Width = 125;
            // 
            // AñadirProducto
            // 
            this.AñadirProducto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AñadirProducto.BackgroundImage")));
            this.AñadirProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AñadirProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AñadirProducto.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.AñadirProducto.FlatAppearance.BorderSize = 0;
            this.AñadirProducto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray;
            this.AñadirProducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.AñadirProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AñadirProducto.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AñadirProducto.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AñadirProducto.Image = ((System.Drawing.Image)(resources.GetObject("AñadirProducto.Image")));
            this.AñadirProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AñadirProducto.Location = new System.Drawing.Point(317, 376);
            this.AñadirProducto.Name = "AñadirProducto";
            this.AñadirProducto.Size = new System.Drawing.Size(85, 53);
            this.AñadirProducto.TabIndex = 41;
            this.AñadirProducto.Text = "Añadir";
            this.AñadirProducto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AñadirProducto.UseVisualStyleBackColor = false;
            this.AñadirProducto.Click += new System.EventHandler(this.AñadirProducto_Click);
            // 
            // Regresar
            // 
            this.Regresar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Regresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Regresar.FlatAppearance.BorderSize = 0;
            this.Regresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray;
            this.Regresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.Regresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Regresar.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Regresar.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Regresar.Image = ((System.Drawing.Image)(resources.GetObject("Regresar.Image")));
            this.Regresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Regresar.Location = new System.Drawing.Point(0, 0);
            this.Regresar.Name = "Regresar";
            this.Regresar.Size = new System.Drawing.Size(35, 33);
            this.Regresar.TabIndex = 39;
            this.Regresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Regresar.UseVisualStyleBackColor = false;
            this.Regresar.Click += new System.EventHandler(this.Regresar_Click);
            // 
            // MantenimientoMetodoPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(708, 441);
            this.Controls.Add(this.AñadirProducto);
            this.Controls.Add(this.TablaMetodoPago);
            this.Controls.Add(this.Regresar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbxEstado);
            this.Name = "MantenimientoMetodoPago";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Store AS | Admón Metodo de Pago";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbxEstado.ResumeLayout(false);
            this.gbxEstado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Bordes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TablaMetodoPago)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbInactivos;
        private System.Windows.Forms.RadioButton rdbActivos;
        private System.Windows.Forms.GroupBox gbxEstado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox filtrarPorNombre;
        private System.Windows.Forms.PictureBox Bordes;
        private System.Windows.Forms.Button Regresar;
        private System.Windows.Forms.DataGridView TablaMetodoPago;
        private System.Windows.Forms.Button AñadirProducto;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMetodoPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn FormaDePago;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Estado;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
    }
}
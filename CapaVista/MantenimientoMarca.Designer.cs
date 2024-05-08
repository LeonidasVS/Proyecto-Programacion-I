namespace CapaVista
{
    partial class MantenimientoMarca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MantenimientoMarca));
            this.TablaMarcas = new System.Windows.Forms.DataGridView();
            this.idMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.AñadirProducto = new System.Windows.Forms.Button();
            this.Regresar = new System.Windows.Forms.Button();
            this.gbxEstado = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.filtrarPorNombre = new System.Windows.Forms.TextBox();
            this.Bordes = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbInactivos = new System.Windows.Forms.RadioButton();
            this.rdbActivos = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.TablaMarcas)).BeginInit();
            this.gbxEstado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Bordes)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TablaMarcas
            // 
            this.TablaMarcas.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.TablaMarcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaMarcas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idMarca,
            this.Nombre,
            this.Descripcion,
            this.Estado,
            this.Editar,
            this.Eliminar});
            this.TablaMarcas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TablaMarcas.Location = new System.Drawing.Point(41, 143);
            this.TablaMarcas.Name = "TablaMarcas";
            this.TablaMarcas.ReadOnly = true;
            this.TablaMarcas.Size = new System.Drawing.Size(763, 234);
            this.TablaMarcas.TabIndex = 15;
            this.TablaMarcas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TablaMarcas_CellClick);
            // 
            // idMarca
            // 
            this.idMarca.DataPropertyName = "idMarca";
            this.idMarca.HeaderText = "Codigo";
            this.idMarca.Name = "idMarca";
            this.idMarca.ReadOnly = true;
            this.idMarca.Width = 50;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 200;
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 250;
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
            this.Editar.Image = ((System.Drawing.Image)(resources.GetObject("Editar.Image")));
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            this.Editar.Width = 60;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Image = ((System.Drawing.Image)(resources.GetObject("Eliminar.Image")));
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Width = 60;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Editar";
            this.dataGridViewImageColumn1.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn1.Image")));
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 60;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "Eliminar";
            this.dataGridViewImageColumn2.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn2.Image")));
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Width = 60;
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
            this.AñadirProducto.Location = new System.Drawing.Point(373, 394);
            this.AñadirProducto.Name = "AñadirProducto";
            this.AñadirProducto.Size = new System.Drawing.Size(85, 53);
            this.AñadirProducto.TabIndex = 14;
            this.AñadirProducto.Text = "Añadir";
            this.AñadirProducto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AñadirProducto.UseVisualStyleBackColor = false;
            this.AñadirProducto.Click += new System.EventHandler(this.AñadirMarca_Click);
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
            this.Regresar.Location = new System.Drawing.Point(0, 1);
            this.Regresar.Name = "Regresar";
            this.Regresar.Size = new System.Drawing.Size(35, 33);
            this.Regresar.TabIndex = 12;
            this.Regresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Regresar.UseVisualStyleBackColor = false;
            this.Regresar.Click += new System.EventHandler(this.Regresar_Click);
            // 
            // gbxEstado
            // 
            this.gbxEstado.Controls.Add(this.label2);
            this.gbxEstado.Controls.Add(this.filtrarPorNombre);
            this.gbxEstado.Controls.Add(this.Bordes);
            this.gbxEstado.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxEstado.ForeColor = System.Drawing.Color.White;
            this.gbxEstado.Location = new System.Drawing.Point(51, 19);
            this.gbxEstado.Name = "gbxEstado";
            this.gbxEstado.Size = new System.Drawing.Size(593, 97);
            this.gbxEstado.TabIndex = 35;
            this.gbxEstado.TabStop = false;
            this.gbxEstado.Text = "Filtrar Por Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(259, 21);
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
            this.filtrarPorNombre.Location = new System.Drawing.Point(114, 51);
            this.filtrarPorNombre.Name = "filtrarPorNombre";
            this.filtrarPorNombre.Size = new System.Drawing.Size(351, 13);
            this.filtrarPorNombre.TabIndex = 0;
            this.filtrarPorNombre.TextChanged += new System.EventHandler(this.filtrarPorNombre_TextChanged);
            // 
            // Bordes
            // 
            this.Bordes.Image = global::CapaVista.Properties.Resources.texbox;
            this.Bordes.Location = new System.Drawing.Point(104, 42);
            this.Bordes.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Bordes.Name = "Bordes";
            this.Bordes.Size = new System.Drawing.Size(371, 31);
            this.Bordes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Bordes.TabIndex = 28;
            this.Bordes.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbInactivos);
            this.groupBox1.Controls.Add(this.rdbActivos);
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(662, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(121, 97);
            this.groupBox1.TabIndex = 36;
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
            // MantenimientoMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(833, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbxEstado);
            this.Controls.Add(this.TablaMarcas);
            this.Controls.Add(this.AñadirProducto);
            this.Controls.Add(this.Regresar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MantenimientoMarca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Store AS | Admón Marca";
            ((System.ComponentModel.ISupportInitialize)(this.TablaMarcas)).EndInit();
            this.gbxEstado.ResumeLayout(false);
            this.gbxEstado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Bordes)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Regresar;
        private System.Windows.Forms.Button AñadirProducto;
        private System.Windows.Forms.DataGridView TablaMarcas;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Estado;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.GroupBox gbxEstado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox filtrarPorNombre;
        private System.Windows.Forms.PictureBox Bordes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbInactivos;
        private System.Windows.Forms.RadioButton rdbActivos;
    }
}
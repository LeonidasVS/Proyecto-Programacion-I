namespace CapaVista
{
    partial class MantenimientoProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MantenimientoProducto));
            this.Filtro = new System.Windows.Forms.GroupBox();
            this.TablaProductos = new System.Windows.Forms.DataGridView();
            this.idProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Exitencias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.idMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Regresar = new System.Windows.Forms.Button();
            this.AñadirProducto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TablaProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // Filtro
            // 
            this.Filtro.Location = new System.Drawing.Point(73, 24);
            this.Filtro.Name = "Filtro";
            this.Filtro.Size = new System.Drawing.Size(673, 75);
            this.Filtro.TabIndex = 0;
            this.Filtro.TabStop = false;
            this.Filtro.Text = "Filtrar Producto";
            // 
            // TablaProductos
            // 
            this.TablaProductos.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.TablaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProducto,
            this.Nombre,
            this.Descripcion,
            this.Exitencias,
            this.Precio,
            this.Estado,
            this.idMarca,
            this.idCategoria,
            this.Marca,
            this.Categoria,
            this.Editar,
            this.Eliminar});
            this.TablaProductos.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.TablaProductos.Location = new System.Drawing.Point(16, 122);
            this.TablaProductos.Name = "TablaProductos";
            this.TablaProductos.Size = new System.Drawing.Size(778, 284);
            this.TablaProductos.TabIndex = 1;
            this.TablaProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TablaProductos_CellClick);
            // 
            // idProducto
            // 
            this.idProducto.DataPropertyName = "idProducto";
            this.idProducto.HeaderText = "Codigo";
            this.idProducto.Name = "idProducto";
            this.idProducto.ReadOnly = true;
            this.idProducto.Width = 60;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Producto";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 160;
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Visible = false;
            // 
            // Exitencias
            // 
            this.Exitencias.DataPropertyName = "Stock";
            this.Exitencias.HeaderText = "Existencias";
            this.Exitencias.Name = "Exitencias";
            this.Exitencias.ReadOnly = true;
            this.Exitencias.Width = 75;
            // 
            // Precio
            // 
            this.Precio.DataPropertyName = "Precio";
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            this.Precio.Width = 75;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "Estado";
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // idMarca
            // 
            this.idMarca.DataPropertyName = "idMarca";
            this.idMarca.HeaderText = "idMarca";
            this.idMarca.Name = "idMarca";
            this.idMarca.ReadOnly = true;
            this.idMarca.Width = 50;
            // 
            // idCategoria
            // 
            this.idCategoria.DataPropertyName = "idCategoria";
            this.idCategoria.HeaderText = "idCategoria";
            this.idCategoria.Name = "idCategoria";
            this.idCategoria.ReadOnly = true;
            this.idCategoria.Width = 63;
            // 
            // Marca
            // 
            this.Marca.DataPropertyName = "Marca";
            this.Marca.HeaderText = "Marca";
            this.Marca.Name = "Marca";
            this.Marca.Visible = false;
            // 
            // Categoria
            // 
            this.Categoria.DataPropertyName = "Categoria";
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.Name = "Categoria";
            this.Categoria.Visible = false;
            // 
            // Editar
            // 
            this.Editar.HeaderText = "Editar";
            this.Editar.Image = ((System.Drawing.Image)(resources.GetObject("Editar.Image")));
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            this.Editar.Width = 75;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Image = ((System.Drawing.Image)(resources.GetObject("Eliminar.Image")));
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Width = 75;
            // 
            // Regresar
            // 
            this.Regresar.BackColor = System.Drawing.Color.Transparent;
            this.Regresar.FlatAppearance.BorderSize = 0;
            this.Regresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue;
            this.Regresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue;
            this.Regresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Regresar.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Regresar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Regresar.Image = ((System.Drawing.Image)(resources.GetObject("Regresar.Image")));
            this.Regresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Regresar.Location = new System.Drawing.Point(1, -1);
            this.Regresar.Name = "Regresar";
            this.Regresar.Size = new System.Drawing.Size(33, 38);
            this.Regresar.TabIndex = 12;
            this.Regresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Regresar.UseMnemonic = false;
            this.Regresar.UseVisualStyleBackColor = false;
            this.Regresar.Click += new System.EventHandler(this.Regresar_Click_1);
            // 
            // AñadirProducto
            // 
            this.AñadirProducto.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.AñadirProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AñadirProducto.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AñadirProducto.ForeColor = System.Drawing.SystemColors.Info;
            this.AñadirProducto.Image = ((System.Drawing.Image)(resources.GetObject("AñadirProducto.Image")));
            this.AñadirProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AñadirProducto.Location = new System.Drawing.Point(376, 447);
            this.AñadirProducto.Name = "AñadirProducto";
            this.AñadirProducto.Size = new System.Drawing.Size(88, 37);
            this.AñadirProducto.TabIndex = 13;
            this.AñadirProducto.Text = "Añadir";
            this.AñadirProducto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AñadirProducto.UseVisualStyleBackColor = false;
            this.AñadirProducto.Click += new System.EventHandler(this.AñadirProducto_Click);
            // 
            // MantenimientoProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(808, 506);
            this.Controls.Add(this.Regresar);
            this.Controls.Add(this.AñadirProducto);
            this.Controls.Add(this.TablaProductos);
            this.Controls.Add(this.Filtro);
            this.Name = "MantenimientoProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MantenimientoProducto";
            ((System.ComponentModel.ISupportInitialize)(this.TablaProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Filtro;
        private System.Windows.Forms.DataGridView TablaProductos;
        private System.Windows.Forms.Button Regresar;
        private System.Windows.Forms.Button AñadirProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Exitencias;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
    }
}
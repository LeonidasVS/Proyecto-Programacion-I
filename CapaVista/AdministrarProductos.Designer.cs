namespace CapaVista
{
    partial class AdministrarProductos
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
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvMostrarProductos = new System.Windows.Forms.DataGridView();
            this.productoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.idProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.existenciasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioUnitarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.Location = new System.Drawing.Point(14, 13);
            this.GroupBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.GroupBox1.Size = new System.Drawing.Size(878, 104);
            this.GroupBox1.TabIndex = 0;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Filtrar Productos";
            // 
            // dgvMostrarProductos
            // 
            this.dgvMostrarProductos.AutoGenerateColumns = false;
            this.dgvMostrarProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostrarProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProductoDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.existenciasDataGridViewTextBoxColumn,
            this.precioUnitarioDataGridViewTextBoxColumn,
            this.activoDataGridViewCheckBoxColumn});
            this.dgvMostrarProductos.DataSource = this.productoBindingSource1;
            this.dgvMostrarProductos.Location = new System.Drawing.Point(14, 141);
            this.dgvMostrarProductos.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dgvMostrarProductos.Name = "dgvMostrarProductos";
            this.dgvMostrarProductos.RowHeadersWidth = 62;
            this.dgvMostrarProductos.RowTemplate.Height = 28;
            this.dgvMostrarProductos.Size = new System.Drawing.Size(878, 430);
            this.dgvMostrarProductos.TabIndex = 1;
            // 
            // productoBindingSource1
            // 
            this.productoBindingSource1.DataSource = typeof(CapaEntidades.Producto);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(14, 602);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(204, 37);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.Location = new System.Drawing.Point(688, 602);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(204, 37);
            this.btnRegresar.TabIndex = 3;
            this.btnRegresar.Text = "Atras";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // idProductoDataGridViewTextBoxColumn
            // 
            this.idProductoDataGridViewTextBoxColumn.DataPropertyName = "IdProducto";
            this.idProductoDataGridViewTextBoxColumn.HeaderText = "Codigo";
            this.idProductoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idProductoDataGridViewTextBoxColumn.Name = "idProductoDataGridViewTextBoxColumn";
            this.idProductoDataGridViewTextBoxColumn.Width = 150;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.Width = 150;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.Width = 204;
            // 
            // existenciasDataGridViewTextBoxColumn
            // 
            this.existenciasDataGridViewTextBoxColumn.DataPropertyName = "Existencias";
            this.existenciasDataGridViewTextBoxColumn.HeaderText = "Existencias";
            this.existenciasDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.existenciasDataGridViewTextBoxColumn.Name = "existenciasDataGridViewTextBoxColumn";
            this.existenciasDataGridViewTextBoxColumn.Width = 150;
            // 
            // precioUnitarioDataGridViewTextBoxColumn
            // 
            this.precioUnitarioDataGridViewTextBoxColumn.DataPropertyName = "PrecioUnitario";
            this.precioUnitarioDataGridViewTextBoxColumn.HeaderText = "Precio Unitario";
            this.precioUnitarioDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.precioUnitarioDataGridViewTextBoxColumn.Name = "precioUnitarioDataGridViewTextBoxColumn";
            this.precioUnitarioDataGridViewTextBoxColumn.Width = 160;
            // 
            // activoDataGridViewCheckBoxColumn
            // 
            this.activoDataGridViewCheckBoxColumn.DataPropertyName = "Activo";
            this.activoDataGridViewCheckBoxColumn.HeaderText = "Activo";
            this.activoDataGridViewCheckBoxColumn.MinimumWidth = 8;
            this.activoDataGridViewCheckBoxColumn.Name = "activoDataGridViewCheckBoxColumn";
            this.activoDataGridViewCheckBoxColumn.Visible = false;
            this.activoDataGridViewCheckBoxColumn.Width = 150;
            // 
            // AdministrarProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 658);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvMostrarProductos);
            this.Controls.Add(this.GroupBox1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "AdministrarProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tienda AS | Aministrar Productos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBox1;
        private System.Windows.Forms.DataGridView dgvMostrarProductos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.BindingSource productoBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn existenciasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioUnitarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn activoDataGridViewCheckBoxColumn;
    }
}
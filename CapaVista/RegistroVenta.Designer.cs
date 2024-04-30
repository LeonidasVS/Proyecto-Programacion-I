namespace CapaVista
{
    partial class RegistroVenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroVenta));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbNombre = new System.Windows.Forms.ComboBox();
            this.ProductoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbIdProducto = new System.Windows.Forms.TextBox();
            this.cmbCantidad = new System.Windows.Forms.TextBox();
            this.cmbExistencias = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.dgvRegistroVenta = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.cmbTotal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbMetodoPago = new System.Windows.Forms.ComboBox();
            this.DetalleVentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MetodoPagoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.VentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ProductoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistroVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetalleVentaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MetodoPagoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VentaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo Producto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(97, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cantidad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(542, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(527, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Existencias:";
            // 
            // cmbNombre
            // 
            this.cmbNombre.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbNombre.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbNombre.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ProductoBindingSource, "Nombre", true));
            this.cmbNombre.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.ProductoBindingSource, "idProducto", true));
            this.cmbNombre.DataSource = this.ProductoBindingSource;
            this.cmbNombre.DisplayMember = "Nombre";
            this.cmbNombre.FormattingEnabled = true;
            this.cmbNombre.Location = new System.Drawing.Point(615, 66);
            this.cmbNombre.Name = "cmbNombre";
            this.cmbNombre.Size = new System.Drawing.Size(218, 21);
            this.cmbNombre.TabIndex = 4;
            this.cmbNombre.ValueMember = "idProducto";
            // 
            // ProductoBindingSource
            // 
            this.ProductoBindingSource.DataSource = typeof(CapaEntidades.Producto);
            // 
            // cmbIdProducto
            // 
            this.cmbIdProducto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ProductoBindingSource, "idProducto", true));
            this.cmbIdProducto.Location = new System.Drawing.Point(176, 67);
            this.cmbIdProducto.Name = "cmbIdProducto";
            this.cmbIdProducto.Size = new System.Drawing.Size(218, 20);
            this.cmbIdProducto.TabIndex = 6;
            this.cmbIdProducto.TextChanged += new System.EventHandler(this.txtCodigoProducto_TextChanged);
            // 
            // cmbCantidad
            // 
            this.cmbCantidad.Location = new System.Drawing.Point(176, 129);
            this.cmbCantidad.Name = "cmbCantidad";
            this.cmbCantidad.Size = new System.Drawing.Size(218, 20);
            this.cmbCantidad.TabIndex = 7;
            // 
            // cmbExistencias
            // 
            this.cmbExistencias.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ProductoBindingSource, "Stock", true));
            this.cmbExistencias.Location = new System.Drawing.Point(615, 129);
            this.cmbExistencias.Name = "cmbExistencias";
            this.cmbExistencias.Size = new System.Drawing.Size(218, 20);
            this.cmbExistencias.TabIndex = 8;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(757, 179);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 9;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // dgvRegistroVenta
            // 
            this.dgvRegistroVenta.AllowUserToAddRows = false;
            this.dgvRegistroVenta.BackgroundColor = System.Drawing.Color.PowderBlue;
            this.dgvRegistroVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegistroVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.Marca,
            this.Cantidad,
            this.Precio,
            this.SubTotal});
            this.dgvRegistroVenta.Location = new System.Drawing.Point(71, 237);
            this.dgvRegistroVenta.Name = "dgvRegistroVenta";
            this.dgvRegistroVenta.Size = new System.Drawing.Size(762, 179);
            this.dgvRegistroVenta.TabIndex = 10;
            this.dgvRegistroVenta.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvRegistroVenta_CellFormatting);
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "Codigo";
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Marca
            // 
            this.Marca.DataPropertyName = "Marca";
            this.Marca.HeaderText = "Marca";
            this.Marca.Name = "Marca";
            this.Marca.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.DataPropertyName = "Cantidad";
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.DataPropertyName = "Precio";
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            // 
            // SubTotal
            // 
            this.SubTotal.DataPropertyName = "SubTotal";
            this.SubTotal.HeaderText = "SubTotal";
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.ReadOnly = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(758, 509);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnProcesar
            // 
            this.btnProcesar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcesar.Location = new System.Drawing.Point(71, 509);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(75, 23);
            this.btnProcesar.TabIndex = 12;
            this.btnProcesar.Text = "Procesar";
            this.btnProcesar.UseVisualStyleBackColor = true;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // cmbTotal
            // 
            this.cmbTotal.Location = new System.Drawing.Point(176, 455);
            this.cmbTotal.Name = "cmbTotal";
            this.cmbTotal.Size = new System.Drawing.Size(218, 20);
            this.cmbTotal.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(72, 456);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Total a Pagar:";
            // 
            // cmbMetodoPago
            // 
            this.cmbMetodoPago.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.DetalleVentaBindingSource, "idMetodoPago", true));
            this.cmbMetodoPago.DataSource = this.MetodoPagoBindingSource;
            this.cmbMetodoPago.DisplayMember = "FormaPago";
            this.cmbMetodoPago.FormattingEnabled = true;
            this.cmbMetodoPago.Location = new System.Drawing.Point(615, 454);
            this.cmbMetodoPago.Name = "cmbMetodoPago";
            this.cmbMetodoPago.Size = new System.Drawing.Size(218, 21);
            this.cmbMetodoPago.TabIndex = 16;
            this.cmbMetodoPago.ValueMember = "idMetodoPago";
            // 
            // DetalleVentaBindingSource
            // 
            this.DetalleVentaBindingSource.DataSource = typeof(CapaEntidades.DetalleVenta);
            // 
            // MetodoPagoBindingSource
            // 
            this.MetodoPagoBindingSource.DataSource = typeof(CapaEntidades.MetodoPago);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(491, 455);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Metodo de Pago:";
            // 
            // VentaBindingSource
            // 
            this.VentaBindingSource.DataSource = typeof(CapaEntidades.Venta);
            // 
            // RegistroVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(933, 554);
            this.Controls.Add(this.cmbMetodoPago);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbTotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnProcesar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.dgvRegistroVenta);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.cmbExistencias);
            this.Controls.Add(this.cmbCantidad);
            this.Controls.Add(this.cmbIdProducto);
            this.Controls.Add(this.cmbNombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegistroVenta";
            this.Text = "Tienda AS | Registro Venta";
            ((System.ComponentModel.ISupportInitialize)(this.ProductoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistroVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetalleVentaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MetodoPagoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VentaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbNombre;
        private System.Windows.Forms.TextBox cmbIdProducto;
        private System.Windows.Forms.TextBox cmbCantidad;
        private System.Windows.Forms.TextBox cmbExistencias;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.DataGridView dgvRegistroVenta;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnProcesar;
        private System.Windows.Forms.TextBox cmbTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbMetodoPago;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.BindingSource ProductoBindingSource;
        private System.Windows.Forms.BindingSource VentaBindingSource;
        private System.Windows.Forms.BindingSource MetodoPagoBindingSource;
        private System.Windows.Forms.BindingSource DetalleVentaBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
    }
}
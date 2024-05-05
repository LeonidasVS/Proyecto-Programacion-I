namespace CapaVista
{
    partial class Store_AS
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Ventas = new System.Windows.Forms.ToolStripMenuItem();
            this.realizarVentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Producto = new System.Windows.Forms.ToolStripMenuItem();
            this.AdmonProducto = new System.Windows.Forms.ToolStripMenuItem();
            this.RegistroVentas = new System.Windows.Forms.ToolStripMenuItem();
            this.verRegistroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Mas = new System.Windows.Forms.ToolStripMenuItem();
            this.añadirMarcasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.añadirCategoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.pictureBox1.Image = global::CapaVista.Properties.Resources.Inicio2;
            this.pictureBox1.Location = new System.Drawing.Point(0, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(819, 484);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(593, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Atención al Cliente  |  2525-0365";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.SteelBlue;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(339, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 4;
            // 
            // menuStrip1
            // 
            this.menuStrip1.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.menuStrip1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Ventas,
            this.Producto,
            this.RegistroVentas,
            this.Mas});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(819, 25);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Ventas
            // 
            this.Ventas.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.Ventas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.realizarVentaToolStripMenuItem});
            this.Ventas.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ventas.ForeColor = System.Drawing.Color.White;
            this.Ventas.Name = "Ventas";
            this.Ventas.Size = new System.Drawing.Size(61, 21);
            this.Ventas.Text = "Ventas";
            // 
            // realizarVentaToolStripMenuItem
            // 
            this.realizarVentaToolStripMenuItem.Name = "realizarVentaToolStripMenuItem";
            this.realizarVentaToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.realizarVentaToolStripMenuItem.Text = "- Realizar Venta";
            this.realizarVentaToolStripMenuItem.Click += new System.EventHandler(this.realizarVentaToolStripMenuItem_Click);
            // 
            // Producto
            // 
            this.Producto.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.Producto.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AdmonProducto});
            this.Producto.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Producto.ForeColor = System.Drawing.Color.White;
            this.Producto.Name = "Producto";
            this.Producto.Size = new System.Drawing.Size(76, 21);
            this.Producto.Text = "Producto";
            // 
            // AdmonProducto
            // 
            this.AdmonProducto.Name = "AdmonProducto";
            this.AdmonProducto.Size = new System.Drawing.Size(190, 22);
            this.AdmonProducto.Text = "- Admón Producto";
            this.AdmonProducto.Click += new System.EventHandler(this.AdmonProducto_Click_1);
            // 
            // RegistroVentas
            // 
            this.RegistroVentas.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.RegistroVentas.BackColor = System.Drawing.Color.DarkSlateGray;
            this.RegistroVentas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verRegistroToolStripMenuItem});
            this.RegistroVentas.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegistroVentas.ForeColor = System.Drawing.Color.White;
            this.RegistroVentas.Name = "RegistroVentas";
            this.RegistroVentas.Size = new System.Drawing.Size(116, 21);
            this.RegistroVentas.Text = "Registro Ventas";
            // 
            // verRegistroToolStripMenuItem
            // 
            this.verRegistroToolStripMenuItem.Name = "verRegistroToolStripMenuItem";
            this.verRegistroToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.verRegistroToolStripMenuItem.Text = "- Listado de Ventas";
            this.verRegistroToolStripMenuItem.Click += new System.EventHandler(this.verRegistroToolStripMenuItem_Click);
            // 
            // Mas
            // 
            this.Mas.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.Mas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.añadirMarcasToolStripMenuItem,
            this.añadirCategoriasToolStripMenuItem});
            this.Mas.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.Mas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Mas.Name = "Mas";
            this.Mas.Size = new System.Drawing.Size(45, 21);
            this.Mas.Text = "Más";
            // 
            // añadirMarcasToolStripMenuItem
            // 
            this.añadirMarcasToolStripMenuItem.Name = "añadirMarcasToolStripMenuItem";
            this.añadirMarcasToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.añadirMarcasToolStripMenuItem.Text = "- Admón Marcas";
            this.añadirMarcasToolStripMenuItem.Click += new System.EventHandler(this.MarcasToolStripMenuItem_Click);
            // 
            // añadirCategoriasToolStripMenuItem
            // 
            this.añadirCategoriasToolStripMenuItem.Name = "añadirCategoriasToolStripMenuItem";
            this.añadirCategoriasToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.añadirCategoriasToolStripMenuItem.Text = "- Admón Categorias";
            this.añadirCategoriasToolStripMenuItem.Click += new System.EventHandler(this.CategoriasToolStripMenuItem_Click);
            // 
            // Store_AS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(819, 511);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Store_AS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Store AS | Inicio";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Ventas;
        private System.Windows.Forms.ToolStripMenuItem realizarVentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Producto;
        private System.Windows.Forms.ToolStripMenuItem AdmonProducto;
        private System.Windows.Forms.ToolStripMenuItem RegistroVentas;
        private System.Windows.Forms.ToolStripMenuItem verRegistroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Mas;
        private System.Windows.Forms.ToolStripMenuItem añadirMarcasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem añadirCategoriasToolStripMenuItem;
    }
}


namespace CapaVista
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tsmVentas = new System.Windows.Forms.ToolStripMenuItem();
            this.realizarVentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmProductos = new System.Windows.Forms.ToolStripMenuItem();
            this.AdministrarProductos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmDetalleVenta = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmMas = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarMarcasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminitrarCategoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarMetodosDePagoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 24);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(668, 407);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 24);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(906, 636);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // tsmVentas
            // 
            this.tsmVentas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.realizarVentaToolStripMenuItem});
            this.tsmVentas.Name = "tsmVentas";
            this.tsmVentas.Size = new System.Drawing.Size(53, 22);
            this.tsmVentas.Text = "Ventas";
            // 
            // realizarVentaToolStripMenuItem
            // 
            this.realizarVentaToolStripMenuItem.Name = "realizarVentaToolStripMenuItem";
            this.realizarVentaToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.realizarVentaToolStripMenuItem.Text = "Realizar Venta";
            this.realizarVentaToolStripMenuItem.Click += new System.EventHandler(this.realizarVentaToolStripMenuItem_Click);
            // 
            // tsmProductos
            // 
            this.tsmProductos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AdministrarProductos});
            this.tsmProductos.Name = "tsmProductos";
            this.tsmProductos.Size = new System.Drawing.Size(73, 22);
            this.tsmProductos.Text = "Productos";
            // 
            // AdministrarProductos
            // 
            this.AdministrarProductos.Name = "AdministrarProductos";
            this.AdministrarProductos.Size = new System.Drawing.Size(193, 22);
            this.AdministrarProductos.Text = "Administrar Productos";
            this.AdministrarProductos.Click += new System.EventHandler(this.administrarProductosToolStripMenuItem_Click);
            // 
            // tsmDetalleVenta
            // 
            this.tsmDetalleVenta.Name = "tsmDetalleVenta";
            this.tsmDetalleVenta.Size = new System.Drawing.Size(87, 22);
            this.tsmDetalleVenta.Text = "Detalle Venta";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmVentas,
            this.tsmProductos,
            this.tsmDetalleVenta,
            this.tsmMas});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(906, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmMas
            // 
            this.tsmMas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administrarMarcasToolStripMenuItem,
            this.adminitrarCategoriasToolStripMenuItem,
            this.administrarMetodosDePagoToolStripMenuItem});
            this.tsmMas.Name = "tsmMas";
            this.tsmMas.Size = new System.Drawing.Size(44, 22);
            this.tsmMas.Text = "MAS";
            // 
            // administrarMarcasToolStripMenuItem
            // 
            this.administrarMarcasToolStripMenuItem.Name = "administrarMarcasToolStripMenuItem";
            this.administrarMarcasToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.administrarMarcasToolStripMenuItem.Text = "Administrar marcas";
            this.administrarMarcasToolStripMenuItem.Click += new System.EventHandler(this.administrarMarcasToolStripMenuItem_Click);
            // 
            // adminitrarCategoriasToolStripMenuItem
            // 
            this.adminitrarCategoriasToolStripMenuItem.Name = "adminitrarCategoriasToolStripMenuItem";
            this.adminitrarCategoriasToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.adminitrarCategoriasToolStripMenuItem.Text = "Adminitrar categorias";
            this.adminitrarCategoriasToolStripMenuItem.Click += new System.EventHandler(this.adminitrarCategoriasToolStripMenuItem_Click);
            // 
            // administrarMetodosDePagoToolStripMenuItem
            // 
            this.administrarMetodosDePagoToolStripMenuItem.Name = "administrarMetodosDePagoToolStripMenuItem";
            this.administrarMetodosDePagoToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.administrarMetodosDePagoToolStripMenuItem.Text = "Administrar metodos de Pago";
            this.administrarMetodosDePagoToolStripMenuItem.Click += new System.EventHandler(this.administrarMetodosDePagoToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 658);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tienda AS  | Principal";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolStripMenuItem tsmVentas;
        private System.Windows.Forms.ToolStripMenuItem realizarVentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmProductos;
        private System.Windows.Forms.ToolStripMenuItem AdministrarProductos;
        private System.Windows.Forms.ToolStripMenuItem tsmDetalleVenta;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmMas;
        private System.Windows.Forms.ToolStripMenuItem administrarMarcasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminitrarCategoriasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrarMetodosDePagoToolStripMenuItem;
    }
}


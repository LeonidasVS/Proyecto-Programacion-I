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
            this.Filtro = new System.Windows.Forms.GroupBox();
            this.TablaProductos = new System.Windows.Forms.DataGridView();
            this.AgregarProducto = new System.Windows.Forms.Button();
            this.Regresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TablaProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // Filtro
            // 
            this.Filtro.Location = new System.Drawing.Point(13, 13);
            this.Filtro.Name = "Filtro";
            this.Filtro.Size = new System.Drawing.Size(775, 71);
            this.Filtro.TabIndex = 0;
            this.Filtro.TabStop = false;
            this.Filtro.Text = "Filtrar Producto";
            // 
            // TablaProductos
            // 
            this.TablaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaProductos.Location = new System.Drawing.Point(12, 106);
            this.TablaProductos.Name = "TablaProductos";
            this.TablaProductos.Size = new System.Drawing.Size(776, 284);
            this.TablaProductos.TabIndex = 1;
            // 
            // AgregarProducto
            // 
            this.AgregarProducto.Location = new System.Drawing.Point(12, 464);
            this.AgregarProducto.Name = "AgregarProducto";
            this.AgregarProducto.Size = new System.Drawing.Size(75, 23);
            this.AgregarProducto.TabIndex = 2;
            this.AgregarProducto.Text = "Agregar";
            this.AgregarProducto.UseVisualStyleBackColor = true;
            this.AgregarProducto.Click += new System.EventHandler(this.AgregarProducto_Click);
            // 
            // Regresar
            // 
            this.Regresar.Location = new System.Drawing.Point(713, 464);
            this.Regresar.Name = "Regresar";
            this.Regresar.Size = new System.Drawing.Size(75, 23);
            this.Regresar.TabIndex = 3;
            this.Regresar.Text = "Regresar";
            this.Regresar.UseVisualStyleBackColor = true;
            this.Regresar.Click += new System.EventHandler(this.Regresar_Click);
            // 
            // MantenimientoProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 499);
            this.Controls.Add(this.Regresar);
            this.Controls.Add(this.AgregarProducto);
            this.Controls.Add(this.TablaProductos);
            this.Controls.Add(this.Filtro);
            this.Name = "MantenimientoProducto";
            this.Text = "MantenimientoProducto";
            ((System.ComponentModel.ISupportInitialize)(this.TablaProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Filtro;
        private System.Windows.Forms.DataGridView TablaProductos;
        private System.Windows.Forms.Button AgregarProducto;
        private System.Windows.Forms.Button Regresar;
    }
}
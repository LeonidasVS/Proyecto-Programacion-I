namespace CapaVista
{
    partial class Registro_Producto
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ProductoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DescripcionProducto = new System.Windows.Forms.TextBox();
            this.Stock = new System.Windows.Forms.TextBox();
            this.PrecioUni = new System.Windows.Forms.TextBox();
            this.Activo = new System.Windows.Forms.CheckBox();
            this.GuardarProducto = new System.Windows.Forms.Button();
            this.Salir2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxMarca = new System.Windows.Forms.ComboBox();
            this.marcaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbxCategoria = new System.Windows.Forms.ComboBox();
            this.categoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ProductoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de Producto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 328);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Precio Unitario:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Existencias:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(97, 122);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Descripcion:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(120, 388);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Estado:";
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ProductoBindingSource, "Nombre", true));
            this.textBox1.Location = new System.Drawing.Point(168, 58);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(572, 20);
            this.textBox1.TabIndex = 5;
            // 
            // ProductoBindingSource
            // 
            this.ProductoBindingSource.DataSource = typeof(Capa_Entidades.Producto);
            // 
            // DescripcionProducto
            // 
            this.DescripcionProducto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ProductoBindingSource, "Descripcion", true));
            this.DescripcionProducto.Location = new System.Drawing.Point(166, 122);
            this.DescripcionProducto.Multiline = true;
            this.DescripcionProducto.Name = "DescripcionProducto";
            this.DescripcionProducto.Size = new System.Drawing.Size(572, 105);
            this.DescripcionProducto.TabIndex = 6;
            // 
            // Stock
            // 
            this.Stock.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ProductoBindingSource, "Stock", true));
            this.Stock.Location = new System.Drawing.Point(168, 262);
            this.Stock.Name = "Stock";
            this.Stock.Size = new System.Drawing.Size(223, 20);
            this.Stock.TabIndex = 7;
            // 
            // PrecioUni
            // 
            this.PrecioUni.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ProductoBindingSource, "Precio", true));
            this.PrecioUni.Location = new System.Drawing.Point(166, 328);
            this.PrecioUni.Name = "PrecioUni";
            this.PrecioUni.Size = new System.Drawing.Size(223, 20);
            this.PrecioUni.TabIndex = 8;
            // 
            // Activo
            // 
            this.Activo.AutoSize = true;
            this.Activo.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.ProductoBindingSource, "Estado", true));
            this.Activo.Location = new System.Drawing.Point(166, 388);
            this.Activo.Name = "Activo";
            this.Activo.Size = new System.Drawing.Size(56, 17);
            this.Activo.TabIndex = 9;
            this.Activo.Text = "Activo";
            this.Activo.UseVisualStyleBackColor = true;
            // 
            // GuardarProducto
            // 
            this.GuardarProducto.Location = new System.Drawing.Point(13, 464);
            this.GuardarProducto.Name = "GuardarProducto";
            this.GuardarProducto.Size = new System.Drawing.Size(108, 23);
            this.GuardarProducto.TabIndex = 10;
            this.GuardarProducto.Text = "Ingresar";
            this.GuardarProducto.UseVisualStyleBackColor = true;
            this.GuardarProducto.Click += new System.EventHandler(this.GuardarProducto_Click);
            // 
            // Salir2
            // 
            this.Salir2.Location = new System.Drawing.Point(682, 464);
            this.Salir2.Name = "Salir2";
            this.Salir2.Size = new System.Drawing.Size(106, 23);
            this.Salir2.TabIndex = 11;
            this.Salir2.Text = "Regresar";
            this.Salir2.UseVisualStyleBackColor = true;
            this.Salir2.Click += new System.EventHandler(this.Salir2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(544, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Marca";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(529, 331);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Categoria";
            // 
            // cbxMarca
            // 
            this.cbxMarca.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.ProductoBindingSource, "idMarca", true));
            this.cbxMarca.DataSource = this.marcaBindingSource;
            this.cbxMarca.DisplayMember = "Nombre";
            this.cbxMarca.FormattingEnabled = true;
            this.cbxMarca.Location = new System.Drawing.Point(587, 257);
            this.cbxMarca.Name = "cbxMarca";
            this.cbxMarca.Size = new System.Drawing.Size(151, 21);
            this.cbxMarca.TabIndex = 18;
            this.cbxMarca.ValueMember = "idMarca";
            // 
            // marcaBindingSource
            // 
            this.marcaBindingSource.DataSource = typeof(Capa_Entidades.Marca);
            // 
            // cbxCategoria
            // 
            this.cbxCategoria.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.ProductoBindingSource, "idCategoria", true));
            this.cbxCategoria.DataSource = this.categoriaBindingSource;
            this.cbxCategoria.DisplayMember = "Nombre";
            this.cbxCategoria.FormattingEnabled = true;
            this.cbxCategoria.Location = new System.Drawing.Point(587, 331);
            this.cbxCategoria.Name = "cbxCategoria";
            this.cbxCategoria.Size = new System.Drawing.Size(151, 21);
            this.cbxCategoria.TabIndex = 19;
            this.cbxCategoria.ValueMember = "idCategoria";
            // 
            // categoriaBindingSource
            // 
            this.categoriaBindingSource.DataSource = typeof(Capa_Entidades.Categoria);
            // 
            // Registro_Producto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 499);
            this.Controls.Add(this.cbxCategoria);
            this.Controls.Add(this.cbxMarca);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Salir2);
            this.Controls.Add(this.GuardarProducto);
            this.Controls.Add(this.Activo);
            this.Controls.Add(this.PrecioUni);
            this.Controls.Add(this.Stock);
            this.Controls.Add(this.DescripcionProducto);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Registro_Producto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro_Producto";
            ((System.ComponentModel.ISupportInitialize)(this.ProductoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox DescripcionProducto;
        private System.Windows.Forms.TextBox Stock;
        private System.Windows.Forms.TextBox PrecioUni;
        private System.Windows.Forms.CheckBox Activo;
        private System.Windows.Forms.Button GuardarProducto;
        private System.Windows.Forms.Button Salir2;
        private System.Windows.Forms.BindingSource ProductoBindingSource;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbxMarca;
        private System.Windows.Forms.ComboBox cbxCategoria;
        private System.Windows.Forms.BindingSource marcaBindingSource;
        private System.Windows.Forms.BindingSource categoriaBindingSource;
    }
}
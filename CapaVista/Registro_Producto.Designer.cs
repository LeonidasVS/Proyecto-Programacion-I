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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro_Producto));
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
            this.Regresar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxMarca = new System.Windows.Forms.ComboBox();
            this.marcaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbxCategoria = new System.Windows.Forms.ComboBox();
            this.categoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Titulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ProductoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(51, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Producto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(13, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Precio Unitario:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(423, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Existencias:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(304, 284);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(85, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Descripcion:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(69, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Estado:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ProductoBindingSource, "Nombre", true));
            this.textBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBox1.Location = new System.Drawing.Point(125, 97);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(194, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ProductoBindingSource
            // 
            this.ProductoBindingSource.DataSource = typeof(Capa_Entidades.Producto);
            // 
            // DescripcionProducto
            // 
            this.DescripcionProducto.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.DescripcionProducto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ProductoBindingSource, "Descripcion", true));
            this.DescripcionProducto.ForeColor = System.Drawing.SystemColors.ControlText;
            this.DescripcionProducto.Location = new System.Drawing.Point(36, 313);
            this.DescripcionProducto.Multiline = true;
            this.DescripcionProducto.Name = "DescripcionProducto";
            this.DescripcionProducto.Size = new System.Drawing.Size(646, 103);
            this.DescripcionProducto.TabIndex = 6;
            this.DescripcionProducto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Stock
            // 
            this.Stock.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Stock.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ProductoBindingSource, "Stock", true));
            this.Stock.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Stock.Location = new System.Drawing.Point(507, 94);
            this.Stock.Name = "Stock";
            this.Stock.Size = new System.Drawing.Size(161, 20);
            this.Stock.TabIndex = 7;
            // 
            // PrecioUni
            // 
            this.PrecioUni.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.PrecioUni.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ProductoBindingSource, "Precio", true));
            this.PrecioUni.ForeColor = System.Drawing.SystemColors.ControlText;
            this.PrecioUni.Location = new System.Drawing.Point(139, 165);
            this.PrecioUni.Name = "PrecioUni";
            this.PrecioUni.Size = new System.Drawing.Size(180, 20);
            this.PrecioUni.TabIndex = 8;
            // 
            // Activo
            // 
            this.Activo.AutoSize = true;
            this.Activo.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.ProductoBindingSource, "Estado", true));
            this.Activo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Activo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Activo.Location = new System.Drawing.Point(125, 231);
            this.Activo.Name = "Activo";
            this.Activo.Size = new System.Drawing.Size(63, 19);
            this.Activo.TabIndex = 9;
            this.Activo.Text = "Activo";
            this.Activo.UseVisualStyleBackColor = true;
            // 
            // GuardarProducto
            // 
            this.GuardarProducto.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.GuardarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GuardarProducto.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuardarProducto.ForeColor = System.Drawing.SystemColors.Info;
            this.GuardarProducto.Image = ((System.Drawing.Image)(resources.GetObject("GuardarProducto.Image")));
            this.GuardarProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GuardarProducto.Location = new System.Drawing.Point(302, 480);
            this.GuardarProducto.Name = "GuardarProducto";
            this.GuardarProducto.Size = new System.Drawing.Size(96, 37);
            this.GuardarProducto.TabIndex = 10;
            this.GuardarProducto.Text = "Guardar";
            this.GuardarProducto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.GuardarProducto.UseVisualStyleBackColor = false;
            this.GuardarProducto.Click += new System.EventHandler(this.GuardarProducto_Click);
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
            this.Regresar.Location = new System.Drawing.Point(0, -1);
            this.Regresar.Name = "Regresar";
            this.Regresar.Size = new System.Drawing.Size(35, 33);
            this.Regresar.TabIndex = 11;
            this.Regresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Regresar.UseVisualStyleBackColor = false;
            this.Regresar.Click += new System.EventHandler(this.Regresar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(455, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Marca:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(432, 228);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Categoria:";
            // 
            // cbxMarca
            // 
            this.cbxMarca.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbxMarca.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxMarca.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.cbxMarca.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.ProductoBindingSource, "idMarca", true));
            this.cbxMarca.DataSource = this.marcaBindingSource;
            this.cbxMarca.DisplayMember = "Nombre";
            this.cbxMarca.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cbxMarca.FormattingEnabled = true;
            this.cbxMarca.Location = new System.Drawing.Point(507, 160);
            this.cbxMarca.Name = "cbxMarca";
            this.cbxMarca.Size = new System.Drawing.Size(161, 21);
            this.cbxMarca.TabIndex = 18;
            this.cbxMarca.ValueMember = "idMarca";
            // 
            // marcaBindingSource
            // 
            this.marcaBindingSource.DataSource = typeof(Capa_Entidades.Marca);
            // 
            // cbxCategoria
            // 
            this.cbxCategoria.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.cbxCategoria.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.ProductoBindingSource, "idCategoria", true));
            this.cbxCategoria.DataSource = this.categoriaBindingSource;
            this.cbxCategoria.DisplayMember = "Nombre";
            this.cbxCategoria.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cbxCategoria.FormattingEnabled = true;
            this.cbxCategoria.Location = new System.Drawing.Point(507, 226);
            this.cbxCategoria.Name = "cbxCategoria";
            this.cbxCategoria.Size = new System.Drawing.Size(161, 21);
            this.cbxCategoria.TabIndex = 19;
            this.cbxCategoria.ValueMember = "idCategoria";
            // 
            // categoriaBindingSource
            // 
            this.categoriaBindingSource.DataSource = typeof(Capa_Entidades.Categoria);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.textBox2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBox2.Location = new System.Drawing.Point(123, 165);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(17, 20);
            this.textBox2.TabIndex = 20;
            this.textBox2.Text = "$";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Titulo.Location = new System.Drawing.Point(227, 24);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(273, 25);
            this.Titulo.TabIndex = 21;
            this.Titulo.Text = "Departamento de Registros";
            // 
            // Registro_Producto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(717, 554);
            this.Controls.Add(this.Titulo);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.cbxCategoria);
            this.Controls.Add(this.cbxMarca);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Regresar);
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
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Registro_Producto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tienda AS | Agregar Productos";
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
        private System.Windows.Forms.Button Regresar;
        private System.Windows.Forms.BindingSource ProductoBindingSource;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbxMarca;
        private System.Windows.Forms.ComboBox cbxCategoria;
        private System.Windows.Forms.BindingSource marcaBindingSource;
        private System.Windows.Forms.BindingSource categoriaBindingSource;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label Titulo;
    }
}
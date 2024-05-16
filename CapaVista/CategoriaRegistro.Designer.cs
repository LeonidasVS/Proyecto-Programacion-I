namespace CapaVista
{
    partial class CategoriaRegistro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoriaRegistro));
            this.Titulo = new System.Windows.Forms.Label();
            this.NombreCategoria = new System.Windows.Forms.TextBox();
            this.cateBinding = new System.Windows.Forms.BindingSource(this.components);
            this.Descripcion = new System.Windows.Forms.TextBox();
            this.checkCategoria = new System.Windows.Forms.CheckBox();
            this.GuardarProducto = new System.Windows.Forms.Button();
            this.Regresar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Habilitar = new System.Windows.Forms.Button();
            this.Bordes = new System.Windows.Forms.PictureBox();
            this.Bordes2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.cateBinding)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bordes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bordes2)).BeginInit();
            this.SuspendLayout();
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Titulo.Location = new System.Drawing.Point(139, 16);
            this.Titulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(232, 25);
            this.Titulo.TabIndex = 0;
            this.Titulo.Text = "Registro de Categorias";
            // 
            // NombreCategoria
            // 
            this.NombreCategoria.BackColor = System.Drawing.Color.White;
            this.NombreCategoria.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NombreCategoria.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cateBinding, "Nombre", true));
            this.NombreCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreCategoria.Location = new System.Drawing.Point(133, 115);
            this.NombreCategoria.Margin = new System.Windows.Forms.Padding(4);
            this.NombreCategoria.Name = "NombreCategoria";
            this.NombreCategoria.Size = new System.Drawing.Size(237, 15);
            this.NombreCategoria.TabIndex = 1;
            this.NombreCategoria.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cateBinding
            // 
            this.cateBinding.DataSource = typeof(Capa_Entidades.Categoria);
            // 
            // Descripcion
            // 
            this.Descripcion.BackColor = System.Drawing.Color.White;
            this.Descripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Descripcion.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cateBinding, "Descripcion", true));
            this.Descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Descripcion.Location = new System.Drawing.Point(44, 219);
            this.Descripcion.Margin = new System.Windows.Forms.Padding(4);
            this.Descripcion.Multiline = true;
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Size = new System.Drawing.Size(427, 73);
            this.Descripcion.TabIndex = 2;
            this.Descripcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // checkCategoria
            // 
            this.checkCategoria.AutoSize = true;
            this.checkCategoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkCategoria.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.cateBinding, "Estado", true));
            this.checkCategoria.Location = new System.Drawing.Point(221, 390);
            this.checkCategoria.Margin = new System.Windows.Forms.Padding(4);
            this.checkCategoria.Name = "checkCategoria";
            this.checkCategoria.Size = new System.Drawing.Size(69, 20);
            this.checkCategoria.TabIndex = 3;
            this.checkCategoria.Text = "Activo";
            this.checkCategoria.UseVisualStyleBackColor = true;
            // 
            // GuardarProducto
            // 
            this.GuardarProducto.BackgroundImage = global::CapaVista.Properties.Resources.button_7284348_1280;
            this.GuardarProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GuardarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GuardarProducto.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.GuardarProducto.FlatAppearance.BorderSize = 0;
            this.GuardarProducto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray;
            this.GuardarProducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.GuardarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GuardarProducto.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuardarProducto.ForeColor = System.Drawing.SystemColors.ControlText;
            this.GuardarProducto.Image = ((System.Drawing.Image)(resources.GetObject("GuardarProducto.Image")));
            this.GuardarProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GuardarProducto.Location = new System.Drawing.Point(208, 435);
            this.GuardarProducto.Margin = new System.Windows.Forms.Padding(4);
            this.GuardarProducto.Name = "GuardarProducto";
            this.GuardarProducto.Size = new System.Drawing.Size(91, 59);
            this.GuardarProducto.TabIndex = 11;
            this.GuardarProducto.Text = "Guardar";
            this.GuardarProducto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.GuardarProducto.UseVisualStyleBackColor = false;
            this.GuardarProducto.Click += new System.EventHandler(this.GuardarCategoria_Click);
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
            this.Regresar.Location = new System.Drawing.Point(1, 2);
            this.Regresar.Margin = new System.Windows.Forms.Padding(4);
            this.Regresar.Name = "Regresar";
            this.Regresar.Size = new System.Drawing.Size(37, 39);
            this.Regresar.TabIndex = 12;
            this.Regresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Regresar.UseVisualStyleBackColor = false;
            this.Regresar.Click += new System.EventHandler(this.Regresar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(210, 83);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Categoria: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(203, 183);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Descripcion:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(228, 361);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Estado";
            // 
            // Habilitar
            // 
            this.Habilitar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Habilitar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Habilitar.FlatAppearance.BorderSize = 0;
            this.Habilitar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray;
            this.Habilitar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.Habilitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Habilitar.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Habilitar.Image = ((System.Drawing.Image)(resources.GetObject("Habilitar.Image")));
            this.Habilitar.Location = new System.Drawing.Point(386, 97);
            this.Habilitar.Name = "Habilitar";
            this.Habilitar.Size = new System.Drawing.Size(35, 53);
            this.Habilitar.TabIndex = 26;
            this.Habilitar.UseVisualStyleBackColor = false;
            this.Habilitar.Click += new System.EventHandler(this.Habilitar_Click);
            // 
            // Bordes
            // 
            this.Bordes.Image = global::CapaVista.Properties.Resources.texbox;
            this.Bordes.Location = new System.Drawing.Point(125, 107);
            this.Bordes.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Bordes.Name = "Bordes";
            this.Bordes.Size = new System.Drawing.Size(253, 31);
            this.Bordes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Bordes.TabIndex = 27;
            this.Bordes.TabStop = false;
            // 
            // Bordes2
            // 
            this.Bordes2.Image = global::CapaVista.Properties.Resources.texbox;
            this.Bordes2.Location = new System.Drawing.Point(30, 205);
            this.Bordes2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Bordes2.Name = "Bordes2";
            this.Bordes2.Size = new System.Drawing.Size(456, 100);
            this.Bordes2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Bordes2.TabIndex = 28;
            this.Bordes2.TabStop = false;
            // 
            // CategoriaRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(509, 516);
            this.Controls.Add(this.NombreCategoria);
            this.Controls.Add(this.Bordes);
            this.Controls.Add(this.Habilitar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Regresar);
            this.Controls.Add(this.GuardarProducto);
            this.Controls.Add(this.checkCategoria);
            this.Controls.Add(this.Descripcion);
            this.Controls.Add(this.Titulo);
            this.Controls.Add(this.Bordes2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CategoriaRegistro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Store AS | Registro Categorias";
            ((System.ComponentModel.ISupportInitialize)(this.cateBinding)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bordes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bordes2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.TextBox NombreCategoria;
        private System.Windows.Forms.TextBox Descripcion;
        private System.Windows.Forms.CheckBox checkCategoria;
        private System.Windows.Forms.Button GuardarProducto;
        private System.Windows.Forms.Button Regresar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource cateBinding;
        private System.Windows.Forms.Button Habilitar;
        private System.Windows.Forms.PictureBox Bordes;
        private System.Windows.Forms.PictureBox Bordes2;
    }
}
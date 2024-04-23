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
            this.label1 = new System.Windows.Forms.Label();
            this.NombreCategoria = new System.Windows.Forms.TextBox();
            this.cateBinding = new System.Windows.Forms.BindingSource(this.components);
            this.Descripcion = new System.Windows.Forms.TextBox();
            this.checkCategoria = new System.Windows.Forms.CheckBox();
            this.GuardarProducto = new System.Windows.Forms.Button();
            this.Regresar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cateBinding)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(218, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registro de Categorias";
            // 
            // NombreCategoria
            // 
            this.NombreCategoria.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.NombreCategoria.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cateBinding, "Nombre", true));
            this.NombreCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreCategoria.Location = new System.Drawing.Point(203, 136);
            this.NombreCategoria.Margin = new System.Windows.Forms.Padding(4);
            this.NombreCategoria.Name = "NombreCategoria";
            this.NombreCategoria.Size = new System.Drawing.Size(253, 22);
            this.NombreCategoria.TabIndex = 1;
            // 
            // cateBinding
            // 
            this.cateBinding.DataSource = typeof(Capa_Entidades.Categoria);
            // 
            // Descripcion
            // 
            this.Descripcion.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Descripcion.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cateBinding, "Descripcion", true));
            this.Descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Descripcion.Location = new System.Drawing.Point(48, 242);
            this.Descripcion.Margin = new System.Windows.Forms.Padding(4);
            this.Descripcion.Multiline = true;
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Size = new System.Drawing.Size(558, 89);
            this.Descripcion.TabIndex = 2;
            // 
            // checkCategoria
            // 
            this.checkCategoria.AutoSize = true;
            this.checkCategoria.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.cateBinding, "Estado", true));
            this.checkCategoria.Location = new System.Drawing.Point(289, 412);
            this.checkCategoria.Margin = new System.Windows.Forms.Padding(4);
            this.checkCategoria.Name = "checkCategoria";
            this.checkCategoria.Size = new System.Drawing.Size(69, 20);
            this.checkCategoria.TabIndex = 3;
            this.checkCategoria.Text = "Activo";
            this.checkCategoria.UseVisualStyleBackColor = true;
            // 
            // GuardarProducto
            // 
            this.GuardarProducto.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.GuardarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GuardarProducto.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuardarProducto.ForeColor = System.Drawing.SystemColors.Info;
            this.GuardarProducto.Image = ((System.Drawing.Image)(resources.GetObject("GuardarProducto.Image")));
            this.GuardarProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GuardarProducto.Location = new System.Drawing.Point(271, 481);
            this.GuardarProducto.Margin = new System.Windows.Forms.Padding(4);
            this.GuardarProducto.Name = "GuardarProducto";
            this.GuardarProducto.Size = new System.Drawing.Size(100, 41);
            this.GuardarProducto.TabIndex = 11;
            this.GuardarProducto.Text = "Guardar";
            this.GuardarProducto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.GuardarProducto.UseVisualStyleBackColor = false;
            this.GuardarProducto.Click += new System.EventHandler(this.GuardarProducto_Click);
            // 
            // Regresar
            // 
            this.Regresar.FlatAppearance.BorderSize = 0;
            this.Regresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Regresar.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Regresar.ForeColor = System.Drawing.Color.CadetBlue;
            this.Regresar.Image = ((System.Drawing.Image)(resources.GetObject("Regresar.Image")));
            this.Regresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Regresar.Location = new System.Drawing.Point(1, 2);
            this.Regresar.Margin = new System.Windows.Forms.Padding(4);
            this.Regresar.Name = "Regresar";
            this.Regresar.Size = new System.Drawing.Size(58, 39);
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
            this.label2.Location = new System.Drawing.Point(287, 107);
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
            this.label3.Location = new System.Drawing.Point(278, 209);
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
            this.label4.Location = new System.Drawing.Point(294, 377);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Estado";
            // 
            // CategoriaRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(654, 554);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Regresar);
            this.Controls.Add(this.GuardarProducto);
            this.Controls.Add(this.checkCategoria);
            this.Controls.Add(this.Descripcion);
            this.Controls.Add(this.NombreCategoria);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CategoriaRegistro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CategoriaRegistro";
            ((System.ComponentModel.ISupportInitialize)(this.cateBinding)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NombreCategoria;
        private System.Windows.Forms.TextBox Descripcion;
        private System.Windows.Forms.CheckBox checkCategoria;
        private System.Windows.Forms.Button GuardarProducto;
        private System.Windows.Forms.Button Regresar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource cateBinding;
    }
}
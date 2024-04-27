namespace CapaVista
{
    partial class MarcaRegistro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MarcaRegistro));
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Regresar = new System.Windows.Forms.Button();
            this.checkMarca = new System.Windows.Forms.CheckBox();
            this.marcasBinding = new System.Windows.Forms.BindingSource(this.components);
            this.Descripcion = new System.Windows.Forms.TextBox();
            this.NombreMarca = new System.Windows.Forms.TextBox();
            this.Titulo = new System.Windows.Forms.Label();
            this.GuardarMarca = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.marcasBinding)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(195, 362);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 23;
            this.label4.Text = "Estado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(177, 190);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "Descripcion:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(198, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Marca:";
            // 
            // Regresar
            // 
            this.Regresar.FlatAppearance.BorderSize = 0;
            this.Regresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue;
            this.Regresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue;
            this.Regresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Regresar.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Regresar.Image = ((System.Drawing.Image)(resources.GetObject("Regresar.Image")));
            this.Regresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Regresar.Location = new System.Drawing.Point(1, 0);
            this.Regresar.Margin = new System.Windows.Forms.Padding(4);
            this.Regresar.Name = "Regresar";
            this.Regresar.Size = new System.Drawing.Size(37, 39);
            this.Regresar.TabIndex = 20;
            this.Regresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Regresar.UseVisualStyleBackColor = false;
            this.Regresar.Click += new System.EventHandler(this.Regresar_Click);
            // 
            // checkMarca
            // 
            this.checkMarca.AutoSize = true;
            this.checkMarca.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.marcasBinding, "Estado", true));
            this.checkMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkMarca.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkMarca.Location = new System.Drawing.Point(190, 386);
            this.checkMarca.Margin = new System.Windows.Forms.Padding(4);
            this.checkMarca.Name = "checkMarca";
            this.checkMarca.Size = new System.Drawing.Size(63, 19);
            this.checkMarca.TabIndex = 19;
            this.checkMarca.Text = "Activo";
            this.checkMarca.UseVisualStyleBackColor = true;
            // 
            // marcasBinding
            // 
            this.marcasBinding.DataSource = typeof(Capa_Entidades.Marca);
            // 
            // Descripcion
            // 
            this.Descripcion.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Descripcion.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.marcasBinding, "Descripcion", true));
            this.Descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Descripcion.Location = new System.Drawing.Point(32, 219);
            this.Descripcion.Margin = new System.Windows.Forms.Padding(4);
            this.Descripcion.Multiline = true;
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Size = new System.Drawing.Size(405, 89);
            this.Descripcion.TabIndex = 18;
            this.Descripcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NombreMarca
            // 
            this.NombreMarca.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.NombreMarca.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.marcasBinding, "Nombre", true));
            this.NombreMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreMarca.Location = new System.Drawing.Point(96, 120);
            this.NombreMarca.Margin = new System.Windows.Forms.Padding(4);
            this.NombreMarca.Name = "NombreMarca";
            this.NombreMarca.Size = new System.Drawing.Size(253, 22);
            this.NombreMarca.TabIndex = 17;
            this.NombreMarca.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Titulo.Location = new System.Drawing.Point(134, 25);
            this.Titulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(198, 25);
            this.Titulo.TabIndex = 16;
            this.Titulo.Text = "Registro de Marcas";
            // 
            // GuardarMarca
            // 
            this.GuardarMarca.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.GuardarMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GuardarMarca.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuardarMarca.ForeColor = System.Drawing.SystemColors.Info;
            this.GuardarMarca.Image = ((System.Drawing.Image)(resources.GetObject("GuardarMarca.Image")));
            this.GuardarMarca.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GuardarMarca.Location = new System.Drawing.Point(174, 455);
            this.GuardarMarca.Margin = new System.Windows.Forms.Padding(4);
            this.GuardarMarca.Name = "GuardarMarca";
            this.GuardarMarca.Size = new System.Drawing.Size(100, 41);
            this.GuardarMarca.TabIndex = 24;
            this.GuardarMarca.Text = "Guardar";
            this.GuardarMarca.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.GuardarMarca.UseVisualStyleBackColor = false;
            this.GuardarMarca.Click += new System.EventHandler(this.GuardarMarca_Click);
            // 
            // MarcaRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(473, 531);
            this.Controls.Add(this.GuardarMarca);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Regresar);
            this.Controls.Add(this.checkMarca);
            this.Controls.Add(this.Descripcion);
            this.Controls.Add(this.NombreMarca);
            this.Controls.Add(this.Titulo);
            this.Name = "MarcaRegistro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MarcaRegistro";
            ((System.ComponentModel.ISupportInitialize)(this.marcasBinding)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Regresar;
        private System.Windows.Forms.CheckBox checkMarca;
        private System.Windows.Forms.TextBox Descripcion;
        private System.Windows.Forms.TextBox NombreMarca;
        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.Button GuardarMarca;
        private System.Windows.Forms.BindingSource marcasBinding;
    }
}
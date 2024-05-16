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
            this.checkMarca = new System.Windows.Forms.CheckBox();
            this.marcasBinding = new System.Windows.Forms.BindingSource(this.components);
            this.Descripcion = new System.Windows.Forms.TextBox();
            this.NombreMarca = new System.Windows.Forms.TextBox();
            this.Titulo = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Habilitar = new System.Windows.Forms.Button();
            this.GuardarMarca = new System.Windows.Forms.Button();
            this.Regresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.marcasBinding)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(202, 336);
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
            this.label3.Location = new System.Drawing.Point(183, 186);
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
            this.label2.Location = new System.Drawing.Point(204, 90);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Marca:";
            // 
            // checkMarca
            // 
            this.checkMarca.AutoSize = true;
            this.checkMarca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkMarca.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.marcasBinding, "Estado", true));
            this.checkMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkMarca.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkMarca.Location = new System.Drawing.Point(197, 360);
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
            this.Descripcion.BackColor = System.Drawing.Color.White;
            this.Descripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Descripcion.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.marcasBinding, "Descripcion", true));
            this.Descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Descripcion.Location = new System.Drawing.Point(44, 221);
            this.Descripcion.Margin = new System.Windows.Forms.Padding(4);
            this.Descripcion.Multiline = true;
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Size = new System.Drawing.Size(382, 67);
            this.Descripcion.TabIndex = 18;
            this.Descripcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NombreMarca
            // 
            this.NombreMarca.BackColor = System.Drawing.Color.White;
            this.NombreMarca.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NombreMarca.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.marcasBinding, "Nombre", true));
            this.NombreMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreMarca.Location = new System.Drawing.Point(112, 121);
            this.NombreMarca.Margin = new System.Windows.Forms.Padding(4);
            this.NombreMarca.Name = "NombreMarca";
            this.NombreMarca.Size = new System.Drawing.Size(232, 15);
            this.NombreMarca.TabIndex = 17;
            this.NombreMarca.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Titulo.Location = new System.Drawing.Point(108, 27);
            this.Titulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(243, 27);
            this.Titulo.TabIndex = 16;
            this.Titulo.Text = "Registro de Marcas";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CapaVista.Properties.Resources.texbox;
            this.pictureBox2.Location = new System.Drawing.Point(106, 112);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(245, 33);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 27;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapaVista.Properties.Resources.texbox;
            this.pictureBox1.Location = new System.Drawing.Point(33, 210);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(405, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // Habilitar
            // 
            this.Habilitar.BackColor = System.Drawing.Color.SlateGray;
            this.Habilitar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Habilitar.FlatAppearance.BorderSize = 0;
            this.Habilitar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray;
            this.Habilitar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.Habilitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Habilitar.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Habilitar.Image = ((System.Drawing.Image)(resources.GetObject("Habilitar.Image")));
            this.Habilitar.Location = new System.Drawing.Point(356, 103);
            this.Habilitar.Name = "Habilitar";
            this.Habilitar.Size = new System.Drawing.Size(35, 53);
            this.Habilitar.TabIndex = 25;
            this.Habilitar.UseVisualStyleBackColor = false;
            this.Habilitar.Click += new System.EventHandler(this.habilitar_Click);
            // 
            // GuardarMarca
            // 
            this.GuardarMarca.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GuardarMarca.BackgroundImage")));
            this.GuardarMarca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GuardarMarca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GuardarMarca.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.GuardarMarca.FlatAppearance.BorderSize = 0;
            this.GuardarMarca.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray;
            this.GuardarMarca.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.GuardarMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GuardarMarca.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World);
            this.GuardarMarca.ForeColor = System.Drawing.SystemColors.ControlText;
            this.GuardarMarca.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GuardarMarca.Location = new System.Drawing.Point(180, 426);
            this.GuardarMarca.Margin = new System.Windows.Forms.Padding(4);
            this.GuardarMarca.Name = "GuardarMarca";
            this.GuardarMarca.Size = new System.Drawing.Size(97, 65);
            this.GuardarMarca.TabIndex = 24;
            this.GuardarMarca.Text = "Guardar";
            this.GuardarMarca.UseVisualStyleBackColor = false;
            this.GuardarMarca.Click += new System.EventHandler(this.GuardarMarca_Click);
            // 
            // Regresar
            // 
            this.Regresar.BackColor = System.Drawing.Color.SlateGray;
            this.Regresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Regresar.FlatAppearance.BorderSize = 0;
            this.Regresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray;
            this.Regresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.Regresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Regresar.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Regresar.ForeColor = System.Drawing.Color.DarkSlateGray;
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
            // MarcaRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(473, 506);
            this.Controls.Add(this.Descripcion);
            this.Controls.Add(this.NombreMarca);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Habilitar);
            this.Controls.Add(this.GuardarMarca);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Regresar);
            this.Controls.Add(this.checkMarca);
            this.Controls.Add(this.Titulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MarcaRegistro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Store AS | Registro de Marcas";
            ((System.ComponentModel.ISupportInitialize)(this.marcasBinding)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Button Habilitar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
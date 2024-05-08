namespace CapaVista
{
    partial class AgregarMetodoPago
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarMetodoPago));
            this.NombreMetodo = new System.Windows.Forms.TextBox();
            this.bindingMetodo = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkMetodo = new System.Windows.Forms.CheckBox();
            this.Titulo = new System.Windows.Forms.Label();
            this.Regresar = new System.Windows.Forms.Button();
            this.Habilitar = new System.Windows.Forms.Button();
            this.GuardarMetodo = new System.Windows.Forms.Button();
            this.Bordes = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingMetodo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bordes)).BeginInit();
            this.SuspendLayout();
            // 
            // NombreMetodo
            // 
            this.NombreMetodo.BackColor = System.Drawing.Color.White;
            this.NombreMetodo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NombreMetodo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingMetodo, "FormaDePago", true));
            this.NombreMetodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreMetodo.Location = new System.Drawing.Point(89, 95);
            this.NombreMetodo.Margin = new System.Windows.Forms.Padding(4);
            this.NombreMetodo.Multiline = true;
            this.NombreMetodo.Name = "NombreMetodo";
            this.NombreMetodo.Size = new System.Drawing.Size(237, 20);
            this.NombreMetodo.TabIndex = 28;
            this.NombreMetodo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bindingMetodo
            // 
            this.bindingMetodo.DataSource = typeof(Capa_Entidades.MetodoPago);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(172, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 29;
            this.label2.Text = "Metodo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(174, 159);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 33;
            this.label4.Text = "Estado";
            // 
            // checkMetodo
            // 
            this.checkMetodo.AutoSize = true;
            this.checkMetodo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkMetodo.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bindingMetodo, "Estado", true));
            this.checkMetodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.checkMetodo.ForeColor = System.Drawing.Color.White;
            this.checkMetodo.Location = new System.Drawing.Point(166, 181);
            this.checkMetodo.Margin = new System.Windows.Forms.Padding(4);
            this.checkMetodo.Name = "checkMetodo";
            this.checkMetodo.Size = new System.Drawing.Size(69, 20);
            this.checkMetodo.TabIndex = 31;
            this.checkMetodo.Text = "Activo";
            this.checkMetodo.UseVisualStyleBackColor = true;
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Titulo.Location = new System.Drawing.Point(54, 9);
            this.Titulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(296, 25);
            this.Titulo.TabIndex = 34;
            this.Titulo.Text = "Registro de Metodos de Pago";
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
            this.Regresar.Location = new System.Drawing.Point(0, 0);
            this.Regresar.Margin = new System.Windows.Forms.Padding(4);
            this.Regresar.Name = "Regresar";
            this.Regresar.Size = new System.Drawing.Size(37, 39);
            this.Regresar.TabIndex = 36;
            this.Regresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Regresar.UseVisualStyleBackColor = false;
            this.Regresar.Click += new System.EventHandler(this.Regresar_Click);
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
            this.Habilitar.Location = new System.Drawing.Point(339, 81);
            this.Habilitar.Name = "Habilitar";
            this.Habilitar.Size = new System.Drawing.Size(35, 53);
            this.Habilitar.TabIndex = 35;
            this.Habilitar.UseVisualStyleBackColor = false;
            this.Habilitar.Click += new System.EventHandler(this.Habilitar_Click);
            // 
            // GuardarMetodo
            // 
            this.GuardarMetodo.BackgroundImage = global::CapaVista.Properties.Resources.button_7284348_1280;
            this.GuardarMetodo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GuardarMetodo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GuardarMetodo.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.GuardarMetodo.FlatAppearance.BorderSize = 0;
            this.GuardarMetodo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray;
            this.GuardarMetodo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.GuardarMetodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GuardarMetodo.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuardarMetodo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.GuardarMetodo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GuardarMetodo.Location = new System.Drawing.Point(156, 232);
            this.GuardarMetodo.Margin = new System.Windows.Forms.Padding(4);
            this.GuardarMetodo.Name = "GuardarMetodo";
            this.GuardarMetodo.Size = new System.Drawing.Size(91, 59);
            this.GuardarMetodo.TabIndex = 32;
            this.GuardarMetodo.Text = "Guardar";
            this.GuardarMetodo.UseVisualStyleBackColor = false;
            this.GuardarMetodo.Click += new System.EventHandler(this.GuardarMetodo_Click);
            // 
            // Bordes
            // 
            this.Bordes.Image = global::CapaVista.Properties.Resources.texbox;
            this.Bordes.Location = new System.Drawing.Point(81, 90);
            this.Bordes.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Bordes.Name = "Bordes";
            this.Bordes.Size = new System.Drawing.Size(253, 31);
            this.Bordes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Bordes.TabIndex = 30;
            this.Bordes.TabStop = false;
            // 
            // AgregarMetodoPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(401, 301);
            this.Controls.Add(this.Regresar);
            this.Controls.Add(this.Habilitar);
            this.Controls.Add(this.Titulo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.GuardarMetodo);
            this.Controls.Add(this.checkMetodo);
            this.Controls.Add(this.NombreMetodo);
            this.Controls.Add(this.Bordes);
            this.Controls.Add(this.label2);
            this.Name = "AgregarMetodoPago";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Store AS | Agregar Metodo de Pago";
            ((System.ComponentModel.ISupportInitialize)(this.bindingMetodo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bordes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NombreMetodo;
        private System.Windows.Forms.PictureBox Bordes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button GuardarMetodo;
        private System.Windows.Forms.CheckBox checkMetodo;
        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.Button Habilitar;
        private System.Windows.Forms.BindingSource bindingMetodo;
        private System.Windows.Forms.Button Regresar;
    }
}
namespace CapaVista
{
    partial class MantenimientoCategorias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MantenimientoCategorias));
            this.label1 = new System.Windows.Forms.Label();
            this.Regresar = new System.Windows.Forms.Button();
            this.AñadirCategory = new System.Windows.Forms.Button();
            this.TablaCategorias = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.TablaCategorias)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(280, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "AÑADIR CATEGORIAS";
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
            this.Regresar.Location = new System.Drawing.Point(1, 0);
            this.Regresar.Name = "Regresar";
            this.Regresar.Size = new System.Drawing.Size(35, 33);
            this.Regresar.TabIndex = 12;
            this.Regresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Regresar.UseVisualStyleBackColor = false;
            this.Regresar.Click += new System.EventHandler(this.Regresar_Click);
            // 
            // AñadirCategory
            // 
            this.AñadirCategory.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.AñadirCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AñadirCategory.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AñadirCategory.ForeColor = System.Drawing.SystemColors.Info;
            this.AñadirCategory.Image = ((System.Drawing.Image)(resources.GetObject("AñadirCategory.Image")));
            this.AñadirCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AñadirCategory.Location = new System.Drawing.Point(359, 386);
            this.AñadirCategory.Name = "AñadirCategory";
            this.AñadirCategory.Size = new System.Drawing.Size(88, 37);
            this.AñadirCategory.TabIndex = 14;
            this.AñadirCategory.Text = "Añadir";
            this.AñadirCategory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AñadirCategory.UseVisualStyleBackColor = false;
            this.AñadirCategory.Click += new System.EventHandler(this.AñadirCategory_Click);
            // 
            // TablaCategorias
            // 
            this.TablaCategorias.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.TablaCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaCategorias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.Descripcion,
            this.Estado,
            this.Editar,
            this.Eliminar});
            this.TablaCategorias.Location = new System.Drawing.Point(40, 116);
            this.TablaCategorias.Name = "TablaCategorias";
            this.TablaCategorias.Size = new System.Drawing.Size(724, 224);
            this.TablaCategorias.TabIndex = 15;
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "idCategoria";
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 50;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 175;
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 250;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "Estado";
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Width = 75;
            // 
            // Editar
            // 
            this.Editar.HeaderText = "Editar";
            this.Editar.Image = ((System.Drawing.Image)(resources.GetObject("Editar.Image")));
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            this.Editar.Width = 65;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Image = ((System.Drawing.Image)(resources.GetObject("Eliminar.Image")));
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Width = 65;
            // 
            // MantenimientoCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TablaCategorias);
            this.Controls.Add(this.AñadirCategory);
            this.Controls.Add(this.Regresar);
            this.Controls.Add(this.label1);
            this.Name = "MantenimientoCategorias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MantenimientoCategorias";
            ((System.ComponentModel.ISupportInitialize)(this.TablaCategorias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Regresar;
        private System.Windows.Forms.Button AñadirCategory;
        private System.Windows.Forms.DataGridView TablaCategorias;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Estado;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
    }
}
using Capa_Entidades;
using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CapaVista
{
    public partial class CategoriaRegistro : Form
    {
        CategoriaLog categoriaLog;
        public CategoriaRegistro()
        {
            InitializeComponent();
            cateBinding.MoveLast();
            cateBinding.AddNew();
        }

        private void Regresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GuardarProducto_Click(object sender, EventArgs e)
        {
            GuardarCategoria();
        }

        private void GuardarCategoria()
        {
            try
            {
                categoriaLog = new CategoriaLog();

                if (string.IsNullOrEmpty(NombreCategoria.Text))
                {
                    MessageBox.Show("Se Requiere Nombre de la Categoria", "Tienda AS | Registro Producto",
                       MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    NombreCategoria.Focus();
                    NombreCategoria.BackColor = Color.Azure;
                    return;
                }
                if (string.IsNullOrEmpty(Descripcion.Text))
                {
                    MessageBox.Show("Se Requiere Descripcion de la Categoria", "Tienda AS | Registro Producto",
                       MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Descripcion.Focus();
                    Descripcion.BackColor = Color.Azure;
                    return;
                }
                if (!checkCategoria.Checked)
                {
                    var dialogo = MessageBox.Show("¿Deseas Dejar La Categoria Inactiva?", "Tienda AS | Registro Producto",
                       MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (dialogo != DialogResult.Yes)
                    {
                        MessageBox.Show("Selecciona el estado como ACTIVO", "Tienda  AS| Registro Productos",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }

                cateBinding.EndEdit();
                Categoria categoria;
                categoria = (Categoria)cateBinding.Current;
                int resultado= categoriaLog.GuardarCategoria(categoria);

                if (resultado > 0)
                {
                    MessageBox.Show("¡La categoria se añadió Exitosamente!", "Tienda AS | Registro Productos",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
                }
                else
                {
                    MessageBox.Show("Error! La Categoria no se guardo", "Tienda AS | Registro Productos",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message }", "Tienda AS | Registro Producto",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

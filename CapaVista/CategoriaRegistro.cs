using Capa_Entidades;
using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CapaVista
{
    public partial class CategoriaRegistro : Form
    {
        CategoriaLog categoriaLog;
        int _id = 0;
        public CategoriaRegistro(int id=0)
        {
            _id = id;
            InitializeComponent();
            cateBinding.MoveLast();
            cateBinding.AddNew();

            if (_id > 0)
            {
                this.Text = "Tienda Store_AS | Edicion de Categorias";
                GuardarProducto.Text = "Update";
                Titulo.Text = "Edicion de Categorias";
                NombreCategoria.Enabled = false;
                CargarDatosCategoria(_id);
            }
            else
            {
                Habilitar.Visible = false;
                cateBinding.MoveLast();
                cateBinding.AddNew();
            }
        }

        private void CargarDatosCategoria(int id)
        {
            categoriaLog = new CategoriaLog();
            cateBinding.DataSource = categoriaLog.ObtenerCategoriaPorId(id);
        }

        private void Regresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GuardarCategoria_Click(object sender, EventArgs e)
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
                    MessageBox.Show("Se Requiere Nombre de la Categoria", "Tienda AS | Registro Categoria",
                       MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    NombreCategoria.Focus();
                    NombreCategoria.BackColor = Color.Azure;
                    return;
                }
                if (string.IsNullOrEmpty(Descripcion.Text))
                {
                    MessageBox.Show("Se Requiere Descripcion de la Categoria", "Tienda AS | Registro Categoria",
                       MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Descripcion.Focus();
                    Descripcion.BackColor = Color.Azure;
                    return;
                }
                if (!checkCategoria.Checked)
                {
                    var dialogo = MessageBox.Show("¿Deseas Dejar La Categoria Inactiva?", "Tienda AS | Registro Categoria",
                       MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (dialogo != DialogResult.Yes)
                    {
                        MessageBox.Show("Selecciona el estado como ACTIVO", "Tienda  AS| Registro Categoria",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }

                int resultado;

                if (_id > 0)
                {
                    Categoria categorya;
                    categorya = (Categoria)cateBinding.Current;

                    resultado = categoriaLog.ActualizarCategoria(categorya, _id);

                    if (resultado > 0)
                    {
                        MessageBox.Show("¡ La Categoria se Actualizo Exitosamente !", "Tienda AS | Registro Productos",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error! La Categoria no se actualizo", "Tienda AS | Registro Productos",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    cateBinding.EndEdit();
                    Categoria categoria;
                    categoria = (Categoria)cateBinding.Current;
                    resultado = categoriaLog.GuardarCategoria(categoria);

                    if (resultado > 0)
                    {
                        MessageBox.Show("¡La Categoria se añadió Exitosamente!", "Tienda AS | Registro Categoria",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error! La Categoria no se guardo", "Tienda AS | Registro Categoria",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message }", "Tienda AS | Registro Categoria",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Habilitar_Click(object sender, EventArgs e)
        {
            NombreCategoria.Enabled = true;
        }
    }
}

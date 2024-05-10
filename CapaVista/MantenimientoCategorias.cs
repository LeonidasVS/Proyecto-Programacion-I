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

namespace CapaVista
{
    public partial class MantenimientoCategorias : Form
    {
        CategoriaLog category;
        public MantenimientoCategorias()
        {
            InitializeComponent();
            CargarCategorias();
        }

        private void CargarCategorias()
        {
            category = new CategoriaLog();
            string nombrecategoria = filtrarPorNombre.Text;
            DataGridViewColumn columna = TablaCategorias.Columns["Eliminar"];

            if (rdbActivos.Checked && filtrarPorNombre.Text.Length > 0)
            {
                columna.Visible = true;
                TablaCategorias.DataSource = category.LeerCategoriaPornombre(nombrecategoria);
            }
            else if (rdbInactivos.Checked && filtrarPorNombre.Text.Length > 0)
            {
                columna.Visible = false;
                TablaCategorias.DataSource = category.LeerCategoriaPornombre(nombrecategoria,true);
            }
            else if (rdbActivos.Checked)
            {
                columna.Visible = true;
                TablaCategorias.DataSource = category.ObtenerCategorias();
            }
            else if (rdbInactivos.Checked)
            {
                columna.Visible = false;
                TablaCategorias.DataSource = category.ObtenerCategorias(true);
            }
        }

        private void AñadirCategory_Click(object sender, EventArgs e)
        {
            CategoriaRegistro category = new CategoriaRegistro();
            category.ShowDialog();
            CargarCategorias();
        }

        private void Regresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TablaCategorias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    int id = int.Parse(TablaCategorias.Rows[e.RowIndex].Cells["idCategoria"].Value.ToString());

                    if (TablaCategorias.Columns[e.ColumnIndex].Name.Equals("Editar"))
                    {
                       CategoriaRegistro acceder = new CategoriaRegistro(id);
                        acceder.ShowDialog();
                        CargarCategorias();

                    }
                    else if (TablaCategorias.Columns[e.ColumnIndex].Name.Equals("Eliminar"))
                    {
                        var ValidarEliminar = MessageBox.Show("¿Deseas Eliminar La Categoria?", "Tienda AS | Precaución", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (ValidarEliminar == DialogResult.Yes)
                        {
                            category = new CategoriaLog();

                            int resultado = category.EliminarCategoria(id);

                            if (resultado > 0)
                            {
                                MessageBox.Show("Categoria Eliminada con Exito", "Tienda AS | Categorias",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                                CargarCategorias();
                            }
                            else
                            {
                                MessageBox.Show("La Categoria no se Elimino", "Tienda AS | Categoria",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error:{ex.Message} ");
            }
        }

        private void rdbActivos_CheckedChanged(object sender, EventArgs e)
        {
            CargarCategorias();
        }

        private void rdbInactivos_CheckedChanged(object sender, EventArgs e)
        {
            CargarCategorias();
        }

        private void filtrarPorNombre_TextChanged(object sender, EventArgs e)
        {
            CargarCategorias();
        }
    }
}

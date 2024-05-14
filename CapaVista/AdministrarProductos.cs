using CapaEntidades;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace CapaVista
{
    public partial class AdministrarProductos : Form
    {
        ProductoLOG _productoLOG;
        MarcaLOG _marcaLOG;
        CategoriaLOG _categoriaLOG;
        public AdministrarProductos()
        {
            InitializeComponent();
            CargarProductos();
            CargarMarcasYCategorias();
        }

        private void CargarMarcasYCategorias()
        {
            _categoriaLOG = new CategoriaLOG();
            _marcaLOG = new MarcaLOG();
            List<Marca> marcas = _marcaLOG.ObtenerMarca();
            marcas.Insert(0, new Marca { idMarca = 0, Nombre = "-- Sin selección --" });
            cmbMarcas.DataSource = marcas;
            List<Categoria> categorias = _categoriaLOG.ObtenerCategorias();
            categorias.Insert(0, new Categoria { idCategoria = 0, Nombre = "-- Sin selección --" });
            cmbCategorias.DataSource = categorias;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarProducto objAgregarProducto = new AgregarProducto();
            objAgregarProducto.ShowDialog();
            CargarProductos();
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            _marcaLOG = new MarcaLOG();
            if (e.RowIndex >= 0 && e.ColumnIndex == dgvMostrarProductos.Columns["IdMarca"].Index)
            {
                int idMarca = Convert.ToInt32(e.Value);
                string nombreMarca = _marcaLOG.mostrarNombreMarca(idMarca);
                e.Value = nombreMarca;
                e.FormattingApplied = true;
            }

            _categoriaLOG = new CategoriaLOG();
            if (e.RowIndex >= 0 && e.ColumnIndex == dgvMostrarProductos.Columns["IdCategoria"].Index)
            {
                int idCategoria = Convert.ToInt32(e.Value);
                string nombreCategoria = _categoriaLOG.ObtenerCategoriaPorId(idCategoria);
                e.Value = nombreCategoria;
                e.FormattingApplied = true;
            }
        }

        private void CargarProductos()
        {
            _productoLOG = new ProductoLOG();
            _marcaLOG = new MarcaLOG();
            int idMarca = 0;
            int idCategoria = 0;
            string nombreProducto = null;

            DataGridViewColumn columna = dgvMostrarProductos.Columns["Eliminar"];

            if (cmbMarcas.SelectedValue != null)
            {
                idMarca = int.Parse(cmbMarcas.SelectedValue.ToString());
            }
            if (cmbCategorias.SelectedValue != null)
            {
                idCategoria = int.Parse(cmbCategorias.SelectedValue.ToString());
            }
            if (txtNombre.Text.Length > 0)
            {
                nombreProducto = txtNombre.Text;
            }

            if (rdbActivos.Checked)
            {
                columna.Visible = true;
                dgvMostrarProductos.DataSource = _productoLOG.Filtrar(idCategoria, false, idMarca, nombreProducto);
            }
            else if (rdbInactivos.Checked)
            {
                columna.Visible = false;
                dgvMostrarProductos.DataSource = _productoLOG.Filtrar(idCategoria, true, idMarca, nombreProducto);
            }
        }

        private void rdbActivos_CheckedChanged(object sender, EventArgs e)
        {
            CargarProductos();
        }

        private void rdbInactivos_CheckedChanged(object sender, EventArgs e)
        {
            CargarProductos();
        }

        private void dgvMostrarProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    int id = int.Parse(dgvMostrarProductos.Rows[e.RowIndex].Cells["Codigo"].Value.ToString());

                    if (dgvMostrarProductos.Columns[e.ColumnIndex].Name.Equals("Editar"))
                    {
                        AgregarProducto objRegistroProducto = new AgregarProducto(id);
                        objRegistroProducto.ShowDialog();
                        CargarProductos();
                    }
                    else if (dgvMostrarProductos.Columns[e.ColumnIndex].Name.Equals("Eliminar"))
                    {
                        var desicion = MessageBox.Show("¿Está seguro que desea eliminar el producto?", "Tienda | Edicion Producto",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        _productoLOG = new ProductoLOG();

                        int resultado = 0;

                        if (desicion != DialogResult.Yes)
                        {
                            MessageBox.Show("El producto se continua mostrando en el listado.", "Tienda | Edicion Productos",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            resultado = _productoLOG.EliminarProducto(id);
                            CargarProductos();

                            if (resultado > 0)
                            {
                                MessageBox.Show("Producto eliminado con exito.", "Tienda | Edicion de Producto",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("No se logro eliminar el producto.", "Tienda | Edicion de Producto",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Ocurrio un error");
            }
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            cmbMarcas.SelectedIndex = 0;
            cmbCategorias.SelectedIndex = 0;
            txtNombre.Clear();
            txtNombre.Text = "";
        }

        private void cmbMarcas_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarProductos();
        }

        private void cmbCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarProductos();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            CargarProductos();
        }
    }
}

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
            _categoriaLOG = new CategoriaLOG();
            _marcaLOG = new MarcaLOG();
            cmbMarcas.DataSource = _marcaLOG.ObtenerMarca();
            cmbMarcas.SelectedIndex = -1;
            cmbMarcas.SelectedValue = 0;
            cmbCategorias.DataSource = _categoriaLOG.ObtenerCategorias();
            cmbCategorias.SelectedIndex = -1;
            cmbCategorias.SelectedValue = 0;
            
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

            if (cmbMarcas.SelectedValue != null)
            {
                idMarca = int.Parse(cmbMarcas.SelectedValue.ToString());              
            }
            if (cmbCategorias.SelectedValue != null)
            {
                idCategoria = int.Parse(cmbCategorias.SelectedValue.ToString());
            }

            if (cmbMarcas.SelectedValue == null) 
            {
                if (rdbActivos.Checked)
                {                        
                       
                    dgvMostrarProductos.DataSource = _productoLOG.ObtenerProductos();                    
                }                  
                else if (rdbInactivos.Checked)
                {                        
                     
                    dgvMostrarProductos.DataSource = _productoLOG.ObtenerProductos(true);
                }
            }
            else if (idMarca > 0)
            {
                if (rdbActivos.Checked)
                {
                    dgvMostrarProductos.DataSource = _productoLOG.FiltrarPorMarca(idMarca);
                }
                else if (rdbInactivos.Checked)
                {

                    dgvMostrarProductos.DataSource = _productoLOG.FiltrarPorMarca(idMarca, true);
                }
            }
            if  (idCategoria > 0)
            {
                if (rdbActivos.Checked)
                {
                    dgvMostrarProductos.DataSource = _productoLOG.FiltrarPorcategoria(idCategoria);
                }
                else if (rdbInactivos.Checked)
                {
                    dgvMostrarProductos.DataSource = _productoLOG.FiltrarPorcategoria(idCategoria, true);
                }
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

        private void cmbMarcas_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbCategorias.SelectedIndex = -1;
            CargarProductos();
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            cmbMarcas.SelectedIndex = -1;
            cmbCategorias.SelectedIndex = -1;
            txtNombre.Text = "";
        }

        private void cmbCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbMarcas.SelectedIndex = -1;
            CargarProductos();
        }
    }
}

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

namespace CapaVista
{
    public partial class AgregarProducto : Form
    {
        ProductoLOG _productoLOG;
        MarcaLOG _marcaLOG;
        CategoriaLOG _categoriaLOG;

        public AgregarProducto()
        {
            InitializeComponent();

            _marcaLOG = new MarcaLOG();
            cmbMarcas.DataSource = _marcaLOG.ObtenerMarca();
            cmbMarcas.DisplayMember = "Nombre";
            cmbMarcas.ValueMember = "idMarca";
            cmbMarcas.SelectedIndex = -1;

            _categoriaLOG = new CategoriaLOG();
            cmbCategorias.DataSource = _categoriaLOG.ObtenerCategorias();
            cmbCategorias.DisplayMember = "Nombre";
            cmbCategorias.ValueMember = "idCategoria";
            cmbCategorias.SelectedIndex = -1;


            productoBindingSource.MoveLast();
            productoBindingSource.AddNew();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarProducto();
        }

        private void GuardarProducto()
        {

            try
            {
                _productoLOG = new ProductoLOG();

                if (string.IsNullOrEmpty(txtNombre.Text))
                {
                    MessageBox.Show("Por favor ingrese el nombre del producto", "Tienda AS | Agregar Producto",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNombre.Focus();
                    txtNombre.BackColor = Color.LightYellow;
                }
                else if (string.IsNullOrEmpty(txtDescripcion.Text))
                {
                    MessageBox.Show("Por favor ingrese la descripción del producto", "Tienda AS | Agregar Producto",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtDescripcion.Focus();
                    txtDescripcion.BackColor = Color.LightYellow;
                }
                else if (string.IsNullOrEmpty(txtPrecio.Text) || Convert.ToDecimal(txtPrecio.Text) == 0)
                {
                    MessageBox.Show("Por favor ingrese el precio valido del producto", "Tienda AS | Agregar Producto",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPrecio.Focus();
                    txtPrecio.BackColor = Color.LightYellow;
                }
                else if (string.IsNullOrEmpty(txtExistencias.Text) || Convert.ToDecimal(txtExistencias.Text) == 0)
                {
                    MessageBox.Show("Por favor ingrese las existencias validas del producto", "Tienda AS | Agregar Producto",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtExistencias.Focus();
                    txtExistencias.BackColor = Color.LightYellow;
                }
                else if (!chkEstado.Checked)
                {
                    var dialogo = MessageBox.Show("Estas seguro que desea guardar el producto inactivo?", "Tienda | Registro Producto",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (dialogo != DialogResult.Yes)
                    {
                        MessageBox.Show("Seleccione el cuadro estado como activo", "Tienda | Registro Productos",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }

                Producto producto;
                producto = (Producto)productoBindingSource.Current;
                int resultado = _productoLOG.GuardarProducto(producto);

                if (resultado > 0)
                {
                    MessageBox.Show("Producto Agregado con Exito", "Tienda | Registro Productos",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se logro agregagr el producto", "Tienda | Registro Productos",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrio un error {ex}", "Tienda | Registro Productos",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AgregarProducto_Load(object sender, EventArgs e)
        {

        }
    }
}

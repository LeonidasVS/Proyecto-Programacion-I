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
using System.Security.Cryptography;

namespace CapaVista
{
    public partial class AgregarProducto : Form
    {
        ProductoLOG _productoLOG;
        MarcaLOG _marcaLOG;
        CategoriaLOG _categoriaLOG;
        int _id;

        public AgregarProducto(int id = 0)
        {
            InitializeComponent();

            _id = id;

            if (_id > 0)
            {
                this.Text = "Tienda | Edicion de Producto";
                btnGuardar.Text = "Actualizar";
                lblTitulo.Text = "Editar Productos";

                CargarDatos(_id);
            }
            else
            {
                MostrarMarcasYCategorias();
                productoBindingSource.MoveLast();
                productoBindingSource.AddNew();
            }
        }

        private void CargarDatos(int id)
        {
            _productoLOG = new ProductoLOG();
            productoBindingSource.DataSource = _productoLOG.ObtenerProductoPorId(id);
            MostrarMarcasYCategorias();
        }

        private void MostrarMarcasYCategorias()
        {
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
                    var dialogo = MessageBox.Show("¿Está seguro que desea guardar el producto como inactivo?", "Tienda | Registro Producto",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (dialogo != DialogResult.Yes)
                    {
                        MessageBox.Show("Seleccione el cuadro estado como activo", "Tienda | Registro Productos",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }

                // En caso de ser actualizacion.
                if (_id > 0)
                {
                    Producto producto;
                    producto = (Producto)productoBindingSource.Current;
                    int resultado = _productoLOG.EditarProducto(producto, _id);
                    if (resultado > 0)
                    {
                        MessageBox.Show("Producto Editado con Exito", "Tienda | Edicion Productos",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("No se logro editar el producto", "Tienda | Edicion Productos",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                // En caso de ser nuevo producto.
                else
                {
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

<<<<<<< HEAD
        private void btnAdmMarcas_Click(object sender, EventArgs e)
        {
            AdministrarMarcas objAdministrarMarcas = new AdministrarMarcas();
            objAdministrarMarcas.ShowDialog();
            _marcaLOG = new MarcaLOG();
            cmbMarcas.DataSource = _marcaLOG.ObtenerMarca();
            cmbMarcas.DisplayMember = "Nombre";
            cmbMarcas.ValueMember = "idMarca";
        }

        private void btnAdmCategorias_Click(object sender, EventArgs e)
        {
            MantenimientoCategoria objMantenimeintoCategoria = new MantenimientoCategoria();
            objMantenimeintoCategoria.ShowDialog();
            _categoriaLOG = new CategoriaLOG();
            cmbCategorias.DataSource = _categoriaLOG.ObtenerCategorias();
            cmbCategorias.DisplayMember = "Nombre";
            cmbCategorias.ValueMember = "idCategoria";
=======
        private void AgregarProducto_Load(object sender, EventArgs e)
        {

>>>>>>> dbddcde63f085e1eacc57d2914303b1a816ccc31
        }
    }
}
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

namespace CapaVista
{
    public partial class Ventas : Form
    {
        _VentaLog ventalog;
        ProductoLog _productolog;
        MetodoPagoLog metodo;
        DataTable detalleVenta;
        public Ventas()
        {
            InitializeComponent();
            CargarProductos();
            CargarMetodoPagos();

            detalleVenta = new DataTable();

            detalleVenta.Columns.Add("Codigo",typeof(int));
            detalleVenta.Columns.Add("Productos",typeof(string));
            detalleVenta.Columns.Add("Precio",typeof(decimal));
            detalleVenta.Columns.Add("Cantidad",typeof(int));
            detalleVenta.Columns.Add("SubTotal",typeof(decimal));

        }

        private void CargarMetodoPagos()
        {
            metodo = new MetodoPagoLog();
            meotdoBinding.DataSource = metodo.ObtenerMetodoDePago();
        }

        private void CargarProductos()
        {
            _productolog = new ProductoLog();
            productoBinding.DataSource = _productolog.ObtenerProductos();
        }

        private void Regresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ProcesarVenta_Click(object sender, EventArgs e)
        {

        }

        private void añadirVenta_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtCantidad.Text))
                {
                    _productolog = new ProductoLog();
                    int codigo = int.Parse(txtCodigo.Text);
                    int cantidad = int.Parse(txtCantidad.Text);

                    var producto = (Producto)productoBinding.Current;
                    if (producto != null)
                    {
                        detalleVenta.Rows.Add(codigo, producto.Nombre, producto.Precio, cantidad, (cantidad * producto.Precio));

                        DetalleVentaData.DataSource = detalleVenta;

                        decimal montoTotal = 0;

                        foreach (DataGridViewRow row in DetalleVentaData.Rows)
                        {
                            montoTotal += decimal.Parse(row.Cells["SubTotal"].Value.ToString());
                        }

                        txtMonto.Text = montoTotal.ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Digita la cantidad de producto a comprar", "Tienda AS | Ventas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }catch(Exception)
            {
                MessageBox.Show("Ocurrio un ERROR","Tienda AS | Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCodigo.Text))
            {
                _productolog = new ProductoLog();

                int codigo = int.Parse(txtCodigo.Text);

                var producto = _productolog.ObtenerProductoPorId(codigo);


                if (producto!=null && producto.Estado==true)
                {
                    comboBoxNombrePro.Text = producto.Nombre;
                }
                else
                {
                    comboBoxNombrePro.Text = "";
                }
            }
            else
            {
                CargarProductos();
            }
        }

        private void comboBoxNombrePro_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtCantidad.Clear();
        }

        private void Ventas_Load(object sender, EventArgs e)
        {

        }
    }
}

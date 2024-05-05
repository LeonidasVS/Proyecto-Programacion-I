using Capa_Entidades;
using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
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

            detalleVenta.Columns.Add("Codigo", typeof(int));
            detalleVenta.Columns.Add("Productos", typeof(string));
            detalleVenta.Columns.Add("Precio", typeof(decimal));
            detalleVenta.Columns.Add("Cantidad", typeof(int));
            detalleVenta.Columns.Add("SubTotal", typeof(decimal));

        }

        private void CargarMetodoPagos()
        {
            metodo = new MetodoPagoLog();
            metodoBinding.DataSource = metodo.ObtenerMetodoDePago();
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

        public void Limpiar()
        {
            CargarProductos();
            CargarMetodoPagos();
            txtCantidad.Clear();
            txtMonto.Clear();
            int calcular = DetalleVentaData.Rows.Count;

            for (int i = calcular - 1; i >= 0; i--)
            {
                DetalleVentaData.Rows.RemoveAt(i);
            }

        }
        private void ProcesarVenta_Click(object sender, EventArgs e)
        {
            try
            {
                if (DetalleVentaData.Rows.Count > 0)
                {

                    ventalog = new _VentaLog();
                    Venta venta = new Venta();
                    venta.Fecha = DateTime.Now;
                    venta.Total = decimal.Parse(txtMonto.Text);

                    foreach (DataGridViewRow row in DetalleVentaData.Rows)
                    {

                        var detalle = new Detalle_Venta()
                        {
                            idProducto = int.Parse(row.Cells["Codigo"].Value.ToString()),
                            Precio = decimal.Parse(row.Cells["Precio"].Value.ToString()),
                            Cantidad = int.Parse(row.Cells["Cantidad"].Value.ToString()),
                            idMetodoPago = int.Parse(comboPagos.SelectedValue.ToString())
                        };



                        venta.Detalles.Add(detalle);
                    }

                    int resultado = ventalog.GuardarVenta(venta);

                    if (resultado > 0)
                    {
                        MessageBox.Show("Venta realizada con Exito","Tienda AS | Ventas",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        Limpiar();
                    }
                    else
                    {
                        MessageBox.Show("La venta no se logro realizar", "Tienda AS | Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Debes realizar una venta para procesarla", "Tienda AS | Ventas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"{ex.Message}","Tienda AS | Ventas",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

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
                    int encontrarCodigo;
                    var producto = (Producto)productoBinding.Current;

                    if (producto != null && cantidad>0 && cantidad<=producto.Stock)
                    {
                        foreach (DataGridViewRow buscar in DetalleVentaData.Rows)
                        {
                            encontrarCodigo = int.Parse(buscar.Cells["Codigo"].Value.ToString());

                            if (encontrarCodigo == codigo)
                            {
                                MessageBox.Show("EL Producto es existente. Escoge otro a tu gusto","Tienda AS | Ventas",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                                return;
                            }
                        }
                        detalleVenta.Rows.Add(codigo, producto.Nombre, producto.Precio, cantidad, (cantidad * producto.Precio));

                        DetalleVentaData.DataSource = detalleVenta;

                        decimal montoTotal = 0;

                        foreach (DataGridViewRow row in DetalleVentaData.Rows)
                        {
                            montoTotal += decimal.Parse(row.Cells["SubTotal"].Value.ToString());
                        }

                        txtMonto.Text = montoTotal.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Digita una cantidad valida entre las exitencias", "Tienda AS | Ventas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Ingresa la cantidad que deseas", "Tienda AS | Ventas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void CalcularMontoTotal()
        {
            decimal montoTotal = 0;

            foreach (DataGridViewRow row in DetalleVentaData.Rows)
            {
                montoTotal += decimal.Parse(row.Cells["SubTotal"].Value.ToString());
            }

            txtMonto.Text = montoTotal.ToString();
        }

        private void DetalleVentaData_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            try
            {
                if (e.ColumnIndex==2 && e.RowIndex>=0)
                {
                   bool esdecimal=decimal.TryParse(e.FormattedValue.ToString(),out  decimal preciofinal);
                   int cantidadfinal = int.Parse(DetalleVentaData.Rows[e.RowIndex].Cells["Cantidad"].Value.ToString());

                    if (esdecimal)
                    {
                        decimal esdecimal2 = decimal.Parse(e.FormattedValue.ToString());
                        if (preciofinal == 0)
                        {
                            e.Cancel = true;
                            MessageBox.Show("Ingresa un precio valido", "Tienda AS | Ventas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            decimal SubTotal = preciofinal * cantidadfinal;
                            DetalleVentaData.Rows[e.RowIndex].Cells["Precio"].Value = esdecimal2;
                            DetalleVentaData.Rows[e.RowIndex].Cells["SubTotal"].Value = SubTotal;
                            CalcularMontoTotal();
                        }
                    }
                    else
                    {
                        e.Cancel = true;
                        MessageBox.Show("No se permite caracteres o espacios en blanco", "Tienda AS | Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al ingresar la cantidad", "Tienda AS | Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

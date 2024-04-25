using CapaDatos;
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
    public partial class RegistroVenta : Form
    {
        MetodoPagoLOG _metodoPagoLOG;
        MarcaLOG _marcaLOG;
        VentaLOG _ventaLOG;
        ProductoLOG _productoLOG;
        DataTable detalleVenta;
        public RegistroVenta()
        {
            InitializeComponent();

            CargarProducto();

            detalleVenta = new DataTable();
            detalleVenta.Columns.Add("Codigo", typeof(int));
            detalleVenta.Columns.Add("Nombre", typeof(string));
            detalleVenta.Columns.Add("Marca", typeof(string));
            detalleVenta.Columns.Add("Precio", typeof(decimal));
            detalleVenta.Columns.Add("Cantidad", typeof(int));
            detalleVenta.Columns.Add("SubTotal", typeof(decimal));

            _metodoPagoLOG = new MetodoPagoLOG();
            MetodoPagoBindingSource.DataSource = _metodoPagoLOG.FormasDePago();
            cmbMetodoPago.DataSource = _metodoPagoLOG.FormasDePago();
            txtCodigoProducto.Text = "-1";
        }

        private void CargarProducto()
        {
            _productoLOG = new ProductoLOG();
            ProductoBindingSource.DataSource = _productoLOG.ObtenerProductos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCodigoProducto.Text))
            {
                _productoLOG = new ProductoLOG();

                int codigo = int.Parse(txtCodigoProducto.Text);

                var producto = _productoLOG.ObtenerProductoPorId(codigo);

                if (producto != null && producto.Activo == true)
                {
                    cmbNombre.Text = producto.Nombre;
                }
                else
                {
                    cmbNombre.Text = "";
                }
            }
            else
            {
                CargarProducto();
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                _productoLOG = new ProductoLOG();

                int codigo = int.Parse(txtCodigoProducto.Text);
                int cantidad = int.Parse(txtCantidad.Text);

                var producto = (Producto)ProductoBindingSource.Current;

                if (producto != null)
                {

                    decimal montoTotal = 0;
                    
                    if (int.Parse(txtCantidad.Text) > int.Parse(txtExistencias.Text))
                    {
                        // Mensaje en caso de que no hayan suficientes existencias
                        MessageBox.Show("Las existencias no son suficientes para esta venta", "Tienda | Registro venta",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (int.Parse(txtCantidad.Text) == 0) 
                    {
                        MessageBox.Show("No se pueden vender CERO productos", "Tienda | Registro venta",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        // Agregar venta
                        detalleVenta.Rows.Add(codigo, producto.Nombre, producto.idMarca, producto.PrecioUnitario,
                        cantidad, (cantidad * producto.PrecioUnitario));

                        dgvDetalleVenta.DataSource = detalleVenta;
                        // Restar los productos vendidos
                        int existenciasAct = int.Parse(txtExistencias.Text) - int.Parse(txtCantidad.Text);
                        txtExistencias.Text = existenciasAct.ToString();
                        producto.Existencias = existenciasAct;

                        foreach (DataGridViewRow row in dgvDetalleVenta.Rows)
                        {
                            montoTotal += decimal.Parse(row.Cells["SubTotal"].Value.ToString());
                        }

                        // Agregar monto total
                        txtTotal.Text = montoTotal.ToString();
                    }         
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Ocurrio un error", "Tienda | Registro venta",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            try
            {
                _ventaLOG = new VentaLOG();
                _productoLOG  = new ProductoLOG();

                Venta venta = new Venta();
                venta.Fecha = DateTime.Now;
                venta.Total = decimal.Parse(txtTotal.Text);

                foreach (DataGridViewRow row in dgvDetalleVenta.Rows)
                {
                    var detalle = new DetalleVenta()
                    {
                        ProductoId = int.Parse(row.Cells["Codigo"].Value.ToString()),
                        Precio = decimal.Parse(row.Cells["Precio"].Value.ToString()),
                        Cantidad = int.Parse(row.Cells["Cantidad"].Value.ToString()),
                        idMetodoPago = int.Parse(cmbMetodoPago.SelectedValue.ToString())
                    };

                    venta.Detalles.Add(detalle);
                }

                int resultado = _ventaLOG.guardarVenta(venta);

                if (resultado >= 0)
                {

                    MessageBox.Show("Venta guardada con exito", "Tienda | Registro venta",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("No se logro guardar la venta", "Tienda | Registro venta",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Ocurrio un error {ex}", "Tienda | Registro venta",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvDetalleVenta_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            _marcaLOG = new MarcaLOG();
            if (e.RowIndex >= 0 && e.ColumnIndex == dgvDetalleVenta.Columns["Marca"].Index)
            {
                int idMarca = Convert.ToInt32(e.Value);
                string nombreMarca = _marcaLOG.mostrarNombreMarca(idMarca);
                e.Value = nombreMarca;
                e.FormattingApplied = true;
            }
        }
    }
}

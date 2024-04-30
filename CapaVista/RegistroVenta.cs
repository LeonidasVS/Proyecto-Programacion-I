using CapaDatos;
using CapaEntidades;
using CapaLogica;
using CapaVista.Properties;
using Microsoft.Win32;
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
            CargarMetodoPago();

            detalleVenta = new DataTable();
            detalleVenta.Columns.Add("Codigo", typeof(int));
            detalleVenta.Columns.Add("Nombre", typeof(string));
            detalleVenta.Columns.Add("Marca", typeof(string));
            detalleVenta.Columns.Add("Precio", typeof(decimal));
            detalleVenta.Columns.Add("Cantidad", typeof(int));
            detalleVenta.Columns.Add("SubTotal", typeof(decimal));
        }

        private void CargarProducto()
        {
            _productoLOG = new ProductoLOG();
            ProductoBindingSource.DataSource = _productoLOG.ObtenerProductos();
            _metodoPagoLOG = new MetodoPagoLOG();
        }

        private void CargarMetodoPago()
        {
            _metodoPagoLOG = new MetodoPagoLOG();
            MetodoPagoBindingSource.DataSource = _metodoPagoLOG.FormasDePago();
            cmbMetodoPago.DataSource = _metodoPagoLOG.FormasDePago();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
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
        private void cmbIdProducto_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cmbIdProducto.Text))
            {
                _productoLOG = new ProductoLOG();
                int codigo = int.Parse(cmbIdProducto.Text);
                var producto = _productoLOG.ObtenerProductoPorId(codigo);

                if (producto != null && producto.Estado == true)
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

                int codigo = int.Parse(cmbIdProducto.Text);
                int cantidad = int.Parse(cmbCantidad.Text);
                var producto = (Producto)ProductoBindingSource.Current;

                if (producto != null)
                {
                    if (int.Parse(cmbCantidad.Text) > int.Parse(cmbExistencias.Text))
                    {
                        MessageBox.Show("Las existencias no son suficientes para esta venta", "Tienda | Registro venta",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (int.Parse(cmbCantidad.Text) == 0)
                    {
                        MessageBox.Show("No se pueden vender CERO productos", "Tienda | Registro venta",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        CalcularMontoTotal();

                        foreach (DataGridViewRow row in dgvRegistroVenta.Rows)
                        {
                            if (int.Parse(cmbIdProducto.Text) == int.Parse(row.Cells["Codigo"].Value.ToString()))
                            {
                                MessageBox.Show("Este pruducto ya se encuentra en el pedido. Por favor, actualizar la cantidad directamente en la tabla.", "Tienda AS | Registro venta",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                        }
                        detalleVenta.Rows.Add(codigo, producto.Nombre, producto.idMarca, producto.PrecioUnitario,
                                cantidad, (cantidad * producto.PrecioUnitario));

                        dgvRegistroVenta.DataSource = detalleVenta;

                        // Restar los productos vendidos
                        int existenciasAct = int.Parse(cmbExistencias.Text) - int.Parse(cmbCantidad.Text);
                        cmbExistencias.Text = existenciasAct.ToString();
                        producto.Stock = existenciasAct;

                        CalcularMontoTotal();
                    }
                }
                else
                {
                    MessageBox.Show("Digita la cantidad de producto a comprar", "Tienda AS | Registro venta",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error", "Tienda AS | Registro venta",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            try
            {
                _ventaLOG = new VentaLOG();
                _productoLOG = new ProductoLOG();

                Venta venta = new Venta();
                venta.Fecha = DateTime.Now;
                venta.Total = decimal.Parse(cmbTotal.Text);

                foreach (DataGridViewRow row in dgvRegistroVenta.Rows)
                {
                    var detalle = new DetalleVenta()
                    {
                        idProducto = int.Parse(row.Cells["Codigo"].Value.ToString()),
                        Precio = decimal.Parse(row.Cells["Precio"].Value.ToString()),
                        Cantidad = int.Parse(row.Cells["Cantidad"].Value.ToString()),
                        idMetodoPago = int.Parse(cmbMetodoPago.SelectedValue.ToString())
                    };
                    venta.Detalles.Add(detalle);
                }
                int resultado = _ventaLOG.guardarVenta(venta);

                if (resultado >= 0)
                {
                    MessageBox.Show("Venta guardada con exito", "Tienda AS | Registro venta",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _productoLOG.ProductoAgotado();
                    LimpiarTablaVenta();
                }
                else
                {
                    MessageBox.Show("No se logro guardar la venta", "Tienda AS | Registro venta",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrio un error {ex}", "Tienda AS | Registro venta",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LimpiarTablaVenta()
        {
            CargarProducto();
            CargarMetodoPago();

            int calcular = detalleVenta.Rows.Count;

            for (int i = calcular - 1; i >= 0; i--)
            {
                detalleVenta.Rows.RemoveAt(i);
            }
            cmbTotal.Clear();
        }

        private void dgvRegistroVenta_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            _marcaLOG = new MarcaLOG();
            if (e.RowIndex >= 0 && e.ColumnIndex == dgvRegistroVenta.Columns["Marca"].Index)
            {
                int idMarca = Convert.ToInt32(e.Value);
                string nombreMarca = _marcaLOG.mostrarNombreMarca(idMarca);
                e.Value = nombreMarca;
                e.FormattingApplied = true;
            }
        }

        private void dgvRegistroVenta_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
                {
                    int id = int.Parse(dgvRegistroVenta.Rows[e.RowIndex].Cells["Codigo"].Value.ToString());
                    bool precioValido = decimal.TryParse(dgvRegistroVenta.Rows[e.RowIndex].Cells["Precio"].Value.ToString(), out decimal precio);
                    int cantidad = int.Parse(dgvRegistroVenta.Rows[e.RowIndex].Cells["Cantidad"].Value.ToString());
                    if (precioValido)
                    {
                        decimal subTotal = precio * cantidad;
                        dgvRegistroVenta.Rows[e.RowIndex].Cells["SubTotal"].Value = subTotal;

                        CalcularMontoTotal();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error");
            }
        }

        private void CalcularMontoTotal()
        {
            decimal montoTotal = 0;

            foreach (DataGridViewRow row in dgvRegistroVenta.Rows)
            {
                montoTotal += decimal.Parse(row.Cells["SubTotal"].Value.ToString());
            }
            cmbTotal.Text = montoTotal.ToString();
        }

        private void cmbNombre_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbCantidad.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var desicion = MessageBox.Show("Esto eliminará todos los productos registrados en la venta actual. ¿Desea continuar?", "Tienda AS | Registro venta",
                 MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (desicion != DialogResult.Yes)
            {
                MessageBox.Show("La venta del producto se continua mostrando en el listado.", "Tienda | Registro venta",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                LimpiarTablaVenta();
                CargarProducto();
                MessageBox.Show("Se eliminaron los productos registrados en la venta.", "Tienda AS | Registro venta",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvRegistroVenta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    int id = int.Parse(dgvRegistroVenta.Rows[e.RowIndex].Cells["Codigo"].Value.ToString());
                    DataRow filaEliminar = detalleVenta.AsEnumerable().FirstOrDefault(row => row.Field<int>("Codigo") == id);

                    if (dgvRegistroVenta.Columns[e.ColumnIndex].Name.Equals("Eliminar"))
                    {
                        var desicion = MessageBox.Show("¿Está seguro que desea eliminar la venta de este producto?", "Tienda | Registro venta",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        _productoLOG = new ProductoLOG();

                        if (desicion != DialogResult.Yes)
                        {
                            MessageBox.Show("La venta del producto se continua mostrando en el listado.", "Tienda | Registro venta",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            if (filaEliminar != null)
                            {
                                filaEliminar.Delete();
                                CargarProducto();
                                MessageBox.Show("La venta del producto se eliminó del listado.", "Tienda | Registro venta",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show($"No se encontró un producto con el id ({id}) en el listado", "Tienda | Registro venta",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error.", "Tienda | Registro venta",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}


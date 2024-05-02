using CapaDatos;
using CapaEntidades;
using CapaLogica;
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
                    if (int.Parse(txtCantidad.Text) > int.Parse(txtExistencias.Text))
                    {
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
                        CalcularMontoTotal();

                        foreach (DataGridViewRow row in dgvDetalleVenta.Rows)
                        {
                            if (int.Parse(txtCodigoProducto.Text) == int.Parse(row.Cells["Codigo"].Value.ToString()))
                            {
                                MessageBox.Show("Este pruducto ya se encuentra en el pedido. Por favor, actualizar la cantidad directamente en la tabla.", "Tienda AS | Registro venta",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }                               
                        }
                        detalleVenta.Rows.Add(codigo, producto.Nombre, producto.idMarca, producto.PrecioUnitario,
                                cantidad, (cantidad * producto.PrecioUnitario));

                        dgvDetalleVenta.DataSource = detalleVenta;

                        // Restar los productos vendidos
                        int existenciasAct = int.Parse(txtExistencias.Text) - int.Parse(txtCantidad.Text);
                        txtExistencias.Text = existenciasAct.ToString();
                        producto.Existencias = existenciasAct;

                        CalcularMontoTotal();
                    }         
                }
                else
                {
                    MessageBox.Show("Digita la cantidad de producto a comprar", "Tienda AS | Registro venta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            txtTotal.Clear();
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

        private void dgvDetalleVenta_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex >= 0 && e.RowIndex >= 0)                   
                {
                    int id = int.Parse(dgvDetalleVenta.Rows[e.RowIndex].Cells["Codigo"].Value.ToString());
                    int prodAct = _productoLOG.ObtenerExistenciasDesdeBD(id);
                    int CantInicial = int.Parse(txtCantidad.Text);
                    bool precioValido = decimal.TryParse(dgvDetalleVenta.Rows[e.RowIndex].Cells["Precio"].Value.ToString(), out decimal precio);                   
                    int cantidad = int.Parse(dgvDetalleVenta.Rows[e.RowIndex].Cells["Cantidad"].Value.ToString());
                   
                    if (cantidad <= _productoLOG.ObtenerExistenciasDesdeBD(id))                
                    {                    
                        if (precioValido && cantidad > 0)                       
                        {                       
                            decimal subTotal = precio * cantidad;                            
                            dgvDetalleVenta.Rows[e.RowIndex].Cells["SubTotal"].Value = subTotal;
                            
                            CalcularMontoTotal();                                                
                            prodAct -= cantidad;                            
                            txtExistencias.Text = prodAct.ToString();                            
                        }                        
                    }
                    else
                    {
                        MessageBox.Show("Las existencias no son suficientes para esta venta", "Tienda | Registro venta",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        dgvDetalleVenta.Rows[e.RowIndex].Cells["Cantidad"].Value = CantInicial;
                        txtExistencias.Text = (_productoLOG.ObtenerExistenciasDesdeBD(id) - CantInicial).ToString();
                    }
                    if (e.ColumnIndex == dgvDetalleVenta.Columns["Cantidad"].Index && Convert.ToInt32(dgvDetalleVenta.Rows[e.RowIndex].Cells["Cantidad"].Value) == 0)
                    {
                        dgvDetalleVenta.Rows.RemoveAt(e.RowIndex);
                        MessageBox.Show("Se eliminó el producto de esta venta", "Tienda | Registro venta",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        CargarProducto();
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

            foreach (DataGridViewRow row in dgvDetalleVenta.Rows)
            {
                montoTotal += decimal.Parse(row.Cells["SubTotal"].Value.ToString());
            }
            txtTotal.Text = montoTotal.ToString();
        }

        private void cmbNombre_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtCantidad.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LimpiarTablaVenta();
            CargarProducto();
            MessageBox.Show("Se eliminaron los productos registrados en la venta.","Tienda AS | Registro venta",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

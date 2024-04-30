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
    public partial class ListaDetalleVentas : Form
    {
        DetalleVentaLog detalleLog;
        _VentaLog ventalog;
        ProductoLog productoLog;
        MetodoPagoLog metodolog;
        public ListaDetalleVentas()
        {
            InitializeComponent();
            CargarDetalleVenta();
            CargarVentas();
        }

        private void CargarVentas()
        {
            ventalog = new _VentaLog();
            dataVentaGrid.DataSource = ventalog.ObtenerVentas();
        }

        private void CargarDetalleVenta()
        {
            detalleLog = new DetalleVentaLog();
            detalleVentaGrid.DataSource = detalleLog.ObtenerDetalleVenta();
        }

        private void Regresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void detalleVentaGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            productoLog = new ProductoLog();

            if(e.RowIndex>=0 && e.ColumnIndex == detalleVentaGrid.Columns["idProducto"].Index)
            {
                int idProducto = Convert.ToInt32(e.Value);
                string nombreproducto = productoLog.ObtenerProductoPorNombre(idProducto);
                e.Value = nombreproducto;
                e.FormattingApplied = true;
            }

            metodolog = new MetodoPagoLog();

            if (e.RowIndex >= 0 && e.ColumnIndex == detalleVentaGrid.Columns["idMetodoPago"].Index)
            {
                int idMetodo = Convert.ToInt32(e.Value);
                string nombreMetodo = metodolog.ObtenerMetodoPagoPorNombre(idMetodo);
                e.Value = nombreMetodo;
                e.FormattingApplied = true;
            }

        }
    }
}

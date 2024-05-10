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
    public partial class Facturacion : Form
    {
        DetalleVentaLog detalleLog;
        ProductoLog productoLog;
        _VentaLog ventalog;
        public Facturacion()
        {
            InitializeComponent();
            CargarDetalleVenta();
        }

        private void CargarDetalleVenta()
        {
            detalleLog = new DetalleVentaLog();
            detalleFacturacion.DataSource = detalleLog.ObtenerFactura();
            DateTime now = DateTime.Now;
            string longDate = now.ToLongDateString();
            lbFecha.Text = longDate;
        }

        private void detalleFacturacion_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            productoLog = new ProductoLog();
            DataGridViewColumn columna = detalleFacturacion.Columns["SubTotal"];
            columna.DisplayIndex = 5;

            if (e.RowIndex >= 0 && e.ColumnIndex == detalleFacturacion.Columns["idProducto"].Index)
            {
                int idProducto = Convert.ToInt32(e.Value);
                string nombreproducto = productoLog.ObtenerProductoPorNombre(idProducto);
                e.Value = nombreproducto;
                e.FormattingApplied = true;
            }

            ventalog = new _VentaLog();

            if (e.RowIndex >= 0 && e.ColumnIndex == detalleFacturacion.Columns["idVenta"].Index)
            {
                int idVenta = Convert.ToInt32(e.Value);
                decimal total = ventalog.ObtenerVentaPorId(idVenta);
                txtMonto.Text = Convert.ToString(total);
            }

            int canfinal=int.Parse(detalleFacturacion.Rows[e.RowIndex].Cells["Cantidad"].Value.ToString());
            decimal precio=decimal.Parse(detalleFacturacion.Rows[e.RowIndex].Cells["Precio"].Value.ToString());
            decimal resultado = canfinal * precio;

            detalleFacturacion.Rows[e.RowIndex].Cells["SubTotal"].Value = resultado;
        }

        private void Regresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

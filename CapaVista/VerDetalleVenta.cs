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
    public partial class VerDetalleVenta : Form
    {
        DetalleVentaLOG _detalleVentaLOG;
        ProductoLOG _productoLOG;
        MetodoPagoLOG _metodoPagoLOG;
        public VerDetalleVenta()
        {
            InitializeComponent();

            _detalleVentaLOG = new DetalleVentaLOG();
            dgvDetalleVenta.DataSource = _detalleVentaLOG.LeerDetalleVenta();
        }

        private void dgvDetalleVenta_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            _productoLOG = new ProductoLOG();
            if (e.RowIndex >= 0 && e.ColumnIndex == dgvDetalleVenta.Columns["Producto"].Index) 
            {
                int idProducto = Convert.ToInt32(e.Value);
                string nombreProducto = _productoLOG.NombreProductoDesdeBD(idProducto);
                e.Value = nombreProducto;
                e.FormattingApplied = true;
            }
            _metodoPagoLOG = new MetodoPagoLOG();
            if (e.RowIndex >= 0 && e.ColumnIndex == dgvDetalleVenta.Columns["MetodoPago"].Index)
            {
                int idMetodoPago = Convert.ToInt32(e.Value);
                string nombremetodoPago = _metodoPagoLOG.ObtenerNombreMtdPagodesdeBD(idMetodoPago);
                e.Value = nombremetodoPago;
                e.FormattingApplied = true;
            }
        }
    }
}

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
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    int id = int.Parse(dgvDetalleVenta.Rows[e.RowIndex].Cells["Codigo"].Value.ToString());

                    if (dgvDetalleVenta.Columns[e.ColumnIndex].Name.Equals("Detalle"))
                    {
                        Factura objFacatura = new Factura(id);
                        objFacatura.ShowDialog();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error", "Tienda AS | Ventas Realizadas",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

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
    public partial class VerVentasRealizadas : Form
    {
        VentaLOG _ventaLOG;
        public VerVentasRealizadas()
        {
            _ventaLOG = new VentaLOG();
            InitializeComponent();
            dgvVentasRealizadas.DataSource = _ventaLOG.VentasRealizadas();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvVentasRealizadas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    int id = int.Parse(dgvVentasRealizadas.Rows[e.RowIndex].Cells["Codigo"].Value.ToString());

                    if (dgvVentasRealizadas.Columns[e.ColumnIndex].Name.Equals("Detalle"))
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
    }
}

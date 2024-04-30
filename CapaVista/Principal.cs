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
    public partial class Principal : Form
    {
        public Principal(string pass)
        {
            InitializeComponent();
            if (pass == "vendedor123")
            {
                AdministrarProductos.Visible = false;
                tsmDetalleVenta.Visible = false;

            }
            else if (pass == "admin123")
            {
                tsmVentas.Enabled = false;
            }
        }

        private void administrarProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdministrarProductos objAdministrarProductos = new AdministrarProductos();
            objAdministrarProductos.ShowDialog();
        }

        private void realizarVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroVenta objRegistroVenta = new RegistroVenta();
            objRegistroVenta.ShowDialog();
        }
    }
}

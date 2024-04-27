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
    public partial class Form1 : Form
    {
        public Form1(string pass)
        {
            InitializeComponent();
            if (pass == "vendedor123")
            {
                tsmProductos.Visible = false;
                tsmDetalleVenta.Visible = false;
                tsmMas.Visible = false;

            }
            else if (pass == "admin123")
            {
                tsmVentas.Enabled = false;
            }
        }

        private void administrarProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdministrarProductos objadmProductos = new AdministrarProductos();
            objadmProductos.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void realizarVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroVenta objRegistroVenta = new RegistroVenta();
            objRegistroVenta.ShowDialog();
        }

        private void administrarMarcasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdministrarMarcas objAdministrarMarcas = new AdministrarMarcas();
            objAdministrarMarcas.ShowDialog();
        }

        private void adminitrarCategoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MantenimientoCategoria objMantenientoCategoria = new MantenimientoCategoria();
            objMantenientoCategoria.ShowDialog();
        }

        private void administrarMetodosDePagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdministrarMetodosPago objAdmMtdsPago = new AdministrarMetodosPago();
            objAdmMtdsPago.ShowDialog();
        }
    }
}

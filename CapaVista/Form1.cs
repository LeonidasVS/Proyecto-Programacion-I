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
    public partial class Store_AS : System.Windows.Forms.Form
    {
        public Store_AS(string pass)
        {
            InitializeComponent();
            if (pass == "vendedor123")
            {
                Producto.Visible = false;
                RegistroVentas.Visible = false;

            }
            else if(pass=="admin123")
            {
                Ventas.Enabled = false;
            }

        }
        private void AdmonProducto_Click_1(object sender, EventArgs e)
        {
            this.Close();
            MantenimientoProducto mntoPro = new MantenimientoProducto();
            mntoPro.ShowDialog();
        }
    }
}

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
                Mas.Visible = false;

            }
            else if(pass=="admin123")
            {
                Ventas.Enabled = false;
            }

        }
        private void AdmonProducto_Click_1(object sender, EventArgs e)
        {
            MantenimientoProducto mntoPro = new MantenimientoProducto();
            mntoPro.ShowDialog();
        }

        private void MarcasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MarcaRegistro marca = new MarcaRegistro();
            //marca.ShowDialog();
            MantenimientoMarca marca = new MantenimientoMarca();
            marca.ShowDialog();
        }

        private void CategoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //CategoriaRegistro categoria = new CategoriaRegistro();
            //categoria.ShowDialog();
            MantenimientoCategorias category = new MantenimientoCategorias();
            category.ShowDialog();
        }

        private void realizarVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ventas ventas = new Ventas();
            ventas.ShowDialog();
        }
    }
}

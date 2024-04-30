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
        //Funcion para validar que contenido se le mostrara el usuario que se logea
        //Aparte se crea una varible para traer la contraseña 
        public Store_AS(string pass)
        {
            InitializeComponent();
            if (pass == "vendedor123")
            {
                //Si es el vendedor se le oculta los productos, los registros de ventas y otras opciones.
                Producto.Visible = false;
                RegistroVentas.Visible = false;
                Mas.Visible = false;

            }
            else if(pass=="admin123")
            {
                //Y si es el admin se le inabilita las ventas.
                Ventas.Enabled = false;
            }

        }
        private void AdmonProducto_Click_1(object sender, EventArgs e)
        {
            //Funcion para llamar e inicializar la ventana del mantenimiento del producto
            MantenimientoProducto mntoPro = new MantenimientoProducto();
            mntoPro.ShowDialog();
        }

        private void MarcasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Funcion para llamar e inicializar la ventana del mantenimiento de las marcas
            MantenimientoMarca marca = new MantenimientoMarca();
            marca.ShowDialog();
        }

        private void CategoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Funcion para llamar e inicializar la ventana del mantenimiento de las categorias
            MantenimientoCategorias category = new MantenimientoCategorias();
            category.ShowDialog();
        }

        private void realizarVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Funcion para llamar e inicializar la ventana para realizar una venta
            Ventas ventas = new Ventas();
            ventas.ShowDialog();
        }

        private void verRegistroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaDetalleVentas listado = new ListaDetalleVentas();
            listado.ShowDialog();
        }
    }
}

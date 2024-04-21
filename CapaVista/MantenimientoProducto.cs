using CapaLogica;
using System;
using System.Windows.Forms;

namespace CapaVista
{
    public partial class MantenimientoProducto : Form
    {
        ProductoLog productoLog;
        public MantenimientoProducto()
        {
            InitializeComponent();
            productoLog = new ProductoLog();
            TablaProductos.DataSource = productoLog.ObtenerProductos();
        }

        private void Regresar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AñadirProducto_Click(object sender, EventArgs e)
        {
            Registro_Producto acceder = new Registro_Producto();
            acceder.ShowDialog();
        }
    }
}

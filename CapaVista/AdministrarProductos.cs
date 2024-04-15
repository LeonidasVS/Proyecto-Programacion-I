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
    public partial class AdministrarProductos : Form
    {
        ProductoLOG _productoLOG;
        public AdministrarProductos()
        {
            InitializeComponent();
            _productoLOG = new ProductoLOG();
            dgvMostrarProductos.DataSource = _productoLOG.ObtenerProductos();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarProducto objAgregarProducto = new AgregarProducto();
            objAgregarProducto.ShowDialog();
        }
    }
}

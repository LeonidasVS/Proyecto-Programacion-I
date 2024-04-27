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
    public partial class MantenimientoCategoria : Form
    {
        CategoriaLOG _categoriaLOG;
        public MantenimientoCategoria()
        {
            InitializeComponent();

            CargarProductos();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarCategoria objAgregarCategoria = new AgregarCategoria();
            objAgregarCategoria.ShowDialog();
            CargarProductos();
        }

        private void CargarProductos()
        {
            _categoriaLOG = new CategoriaLOG();
            dgvCategorias.DataSource = _categoriaLOG.ObtenerCategorias();
        }
    }
}

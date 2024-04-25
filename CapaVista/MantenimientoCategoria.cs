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

            _categoriaLOG = new CategoriaLOG();
            dgvCategorias.DataSource = _categoriaLOG.ObtenerCategorias();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarCategoria objAgregarCategoria = new AgregarCategoria();
            objAgregarCategoria.ShowDialog();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            dgvCategorias.DataSource = _categoriaLOG.ObtenerCategorias();
        }
    }
}

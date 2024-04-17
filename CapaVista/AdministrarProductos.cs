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
        MarcaLOG _marcaLOG;
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

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            _marcaLOG = new MarcaLOG();
            if (e.RowIndex >= 0 && e.ColumnIndex == dgvMostrarProductos.Columns["IdMarca"].Index)
            {
                int idMarca = Convert.ToInt32(e.Value);
                string nombreMarca = _marcaLOG.mostrarNombreMarca(idMarca);
                e.Value = nombreMarca;
                e.FormattingApplied = true;
            }
        }
    }
}

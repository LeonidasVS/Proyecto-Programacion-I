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
        CategoriaLOG _categoriaLOG;
        public AdministrarProductos()
        {
            InitializeComponent();
            CargarProductos();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarProducto objAgregarProducto = new AgregarProducto();
            objAgregarProducto.ShowDialog();
            CargarProductos();
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

            _categoriaLOG = new CategoriaLOG();
            if (e.RowIndex >= 0 && e.ColumnIndex == dgvMostrarProductos.Columns["IdCategoria"].Index)
            {
                int idCategoria = Convert.ToInt32(e.Value);
                string nombreCategoria = _categoriaLOG.ObtenerCategoriaPorId(idCategoria);
                e.Value = nombreCategoria;
                e.FormattingApplied = true;
            }
        }

        private void CargarProductos()
        {
            _productoLOG = new ProductoLOG();
            dgvMostrarProductos.DataSource = _productoLOG.ObtenerProductos();
        }
    }
}

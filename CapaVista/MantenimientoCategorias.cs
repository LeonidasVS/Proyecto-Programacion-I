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
    public partial class MantenimientoCategorias : Form
    {
        CategoriaLog category;
        public MantenimientoCategorias()
        {
            InitializeComponent();
            CargarCategoriaas();
        }

        private void CargarCategoriaas()
        {
            category = new CategoriaLog();
            TablaCategorias.DataSource = category.ObtenerCategorias();
        }

        private void AñadirCategory_Click(object sender, EventArgs e)
        {
            CategoriaRegistro category = new CategoriaRegistro();
            category.ShowDialog();
            CargarCategoriaas();
        }

        private void Regresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

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
    public partial class AdministrarMarcas : Form
    {
        MarcaLOG _marcaLOG;
        public AdministrarMarcas()
        {
            InitializeComponent();

            cargarMarcas();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarMarca objAgregarMarca = new AgregarMarca();
            objAgregarMarca.ShowDialog();
            cargarMarcas();
        }

        private void cargarMarcas()
        {
            _marcaLOG = new MarcaLOG();
            dgvMarcas.DataSource = _marcaLOG.ObtenerMarca();
        }
    }
}

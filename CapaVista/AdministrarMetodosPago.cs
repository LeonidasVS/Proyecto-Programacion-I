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
    public partial class AdministrarMetodosPago : Form
    {
        MetodoPagoLOG _metodopagoLOG;
        public AdministrarMetodosPago()
        {
            InitializeComponent();
            CargarMtdsPago();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargarMtdsPago()
        {
            _metodopagoLOG = new MetodoPagoLOG();
            dgvMtdsPago.DataSource = _metodopagoLOG.FormasDePago();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarMetodoPago objAgregarMtdsPago = new AgregarMetodoPago();
            objAgregarMtdsPago.ShowDialog();
            CargarMtdsPago();
        }
    }
}

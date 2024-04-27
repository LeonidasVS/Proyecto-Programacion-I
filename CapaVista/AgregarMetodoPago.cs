using CapaEntidades;
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
    public partial class AgregarMetodoPago : Form
    {
        MetodoPagoLOG _metodoPagoLOG;
        public AgregarMetodoPago()
        {
            InitializeComponent();

            MetdPagoBindingSource.MoveLast();
            MetdPagoBindingSource.AddNew();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarMtdPago();
        }

        private void GuardarMtdPago()
        {
            try
            {
                _metodoPagoLOG = new MetodoPagoLOG();
                if (string.IsNullOrEmpty(txtNombre.Text))
                {
                    MessageBox.Show("Por favor ingrese el nombre de la marca", "Tienda AS | Agregar Marca",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNombre.Focus();
                    txtNombre.BackColor = Color.LightYellow;
                }
                else if (!chbActivo.Checked)
                {
                    var dialogo = MessageBox.Show("Estas seguro que desea guardar la marca inactiva?", "Tienda | Registro Marca",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (dialogo != DialogResult.Yes)
                    {
                        MessageBox.Show("Seleccione el cuadro estado como activo", "Tienda | Registro Marca",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }

                MetodoPago metdpago;
                metdpago = (MetodoPago)MetdPagoBindingSource.Current;
                int resultado = _metodoPagoLOG.AgregarMtdPago(metdpago);

                if (resultado > 0)
                {
                    MessageBox.Show("Marca Agregada con Exito", "Tienda | Registro Marca",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se logro agregagr la Marca", "Tienda | Registro marca",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Ocurrio un error", "Tienda AS | Agregar Marca",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

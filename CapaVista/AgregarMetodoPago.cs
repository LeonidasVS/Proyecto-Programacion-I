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
        int _id;
        public AgregarMetodoPago(int id = 0)
        {
            InitializeComponent();
            _id = id;
            if (id > 0)
            {
                lblTitulo.Text = "Editar Metodo de Pago";

                this.Text = "Tienda AS |Editar Metodo de Pago";
                btnGuardar.Text = "Actualizar";

                CargarDatos(_id);
            }
            else
            {
                MetdPagoBindingSource.MoveLast();
                MetdPagoBindingSource.AddNew();
            }  
        }

        private void CargarDatos(int id)
        {
            _metodoPagoLOG = new MetodoPagoLOG();
            MetdPagoBindingSource.DataSource = _metodoPagoLOG.MetodoPagoPorId(_id);
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
                    MessageBox.Show("Por favor ingrese el nombre deel metodo de pago", "Tienda AS | Registro Metodo de pago",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNombre.Focus();
                    txtNombre.BackColor = Color.LightYellow;
                }
                else if (!chbActivo.Checked)
                {
                    var dialogo = MessageBox.Show("Estas seguro que desea guardar el metodo de pago inactivo?", "Tienda | Registro Metodo de pago",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (dialogo != DialogResult.Yes)
                    {
                        MessageBox.Show("Seleccione el cuadro estado como activo", "Tienda | Registro Metodo de pago",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }

                if (_id > 0)
                {
                    MetodoPago metdpago;
                    metdpago = (MetodoPago)MetdPagoBindingSource.Current;
                    int resultado = _metodoPagoLOG.AgregarMtdPago(metdpago, _id, true);

                    if (resultado > 0)
                    {
                        MessageBox.Show("Metodo de pago editado con Exito", "Tienda | Editar metodo de pago",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("No se logro editarla Marca", "Tienda | Editar metodo de pago",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MetodoPago metdpago;
                    metdpago = (MetodoPago)MetdPagoBindingSource.Current;
                    int resultado = _metodoPagoLOG.AgregarMtdPago(metdpago);

                    if (resultado > 0)
                    {
                        MessageBox.Show("Metodo de pago agregado con Exito", "Tienda | Registro Metodo de pago",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("No se logro agregagr el metodo de pago", "Tienda | Registro Metodo de pago",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Ocurrio un error", "Tienda AS | Registro Metodo de pago",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

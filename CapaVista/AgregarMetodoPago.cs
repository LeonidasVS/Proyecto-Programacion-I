using Capa_Entidades;
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
        MetodoPagoLog _metodolog;
        int _id = 0;
        public AgregarMetodoPago(int id=0)
        {
            _id = id;
            InitializeComponent();
            bindingMetodo.MoveLast();
            bindingMetodo.AddNew();

            if (_id > 0)
            {
                this.Text = "Tienda Store_AS | Edicion de Metodo de Pago";
                GuardarMetodo.Text = "Update";
                Titulo.Text = "Edicion de Metodos de Pago";
                NombreMetodo.Enabled = false;
                CargarDatosMetodo(_id);
            }
            else
            {
                Habilitar.Visible = false;
                bindingMetodo.MoveLast();
                bindingMetodo.AddNew();
            }
        }

        private void CargarDatosMetodo(int id)
        {
            _metodolog = new MetodoPagoLog();
            bindingMetodo.DataSource = _metodolog.ObtenerMetodoPorId(id);
        }

        private void Habilitar_Click(object sender, EventArgs e)
        {
            NombreMetodo.Enabled = true;
        }

        private void GuardarMetodo_Click(object sender, EventArgs e)
        {
            GuardarMetodoPago();
        }

        private void Regresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GuardarMetodoPago()
        {
            try
            {
                _metodolog = new MetodoPagoLog();

                if (string.IsNullOrEmpty(NombreMetodo.Text))
                {
                    MessageBox.Show("Se Requiere Nombre del Metodo de Pago", "Tienda AS | Registro Categoria",
                       MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    NombreMetodo.Focus();
                    return;
                }
                if (!checkMetodo.Checked)
                {
                    var dialogo = MessageBox.Show("¿Deseas Dejar El Metodo Inactivo?", "Tienda AS | Registro Categoria",
                       MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (dialogo != DialogResult.Yes)
                    {
                        MessageBox.Show("Selecciona el estado como ACTIVO", "Tienda  AS| Registro Categoria",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }

                int resultado;

                if (_id > 0)
                {
                    MetodoPago metodopago;
                    metodopago = (MetodoPago)bindingMetodo.Current;

                    resultado = _metodolog.ActualizarMetodo(metodopago, _id);

                    if (resultado > 0)
                    {
                        MessageBox.Show("¡ El Metodo de Pago se Actualizo Exitosamente !", "Tienda AS | Metodo de Pago",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error! El Metodo de Pago no se actualizo", "Tienda AS | Registro Metodo de Pago",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    bindingMetodo.EndEdit();
                    MetodoPago metodopago2;
                    metodopago2 = (MetodoPago)bindingMetodo.Current;
                    resultado = _metodolog.GuardarMetodo(metodopago2);

                    if (resultado > 0)
                    {
                        MessageBox.Show("¡El Metodo de Pago se añadió Exitosamente!", "Tienda AS | Registro Metodo de Pago",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error! El Metodo de Pago no se guardo", "Tienda AS | Registro Metodo de Pago",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Tienda AS | Registro Metodo de Pago",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

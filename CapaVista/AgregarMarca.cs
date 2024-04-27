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
    public partial class AgregarMarca : Form
    {
        MarcaLOG _marcaLOG;
        public AgregarMarca()
        {
            InitializeComponent();

            marcaBindingSource.MoveLast();
            marcaBindingSource.AddNew();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarMarca();
        }

        private void GuardarMarca()
        {
            try
            {
                _marcaLOG = new MarcaLOG();
                if (string.IsNullOrEmpty(txtNombreMarca.Text))
                {
                    MessageBox.Show("Por favor ingrese el nombre de la marca", "Tienda AS | Agregar Marca",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNombreMarca.Focus();
                    txtNombreMarca.BackColor = Color.LightYellow;
                }
                else if (string.IsNullOrEmpty(txtDescripcion.Text))
                {
                    MessageBox.Show("Por favor ingrese la descripción de la marca", "Tienda AS | Agregar Marca",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNombreMarca.Focus();
                    txtNombreMarca.BackColor = Color.LightYellow;
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

                Marca marca;
                marca = (Marca)marcaBindingSource.Current;
                int resultado = _marcaLOG.AgregarMarca(marca);

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

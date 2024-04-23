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
    public partial class MarcaRegistro : Form
    {
        MarcaLog _marcalog;
        public MarcaRegistro()
        {
            InitializeComponent();
            marcasBinding.MoveLast();
            marcasBinding.AddNew();
        }

        private void GuardarMarca_Click(object sender, EventArgs e)
        {
            GuardarMarcas();
        }

        private void GuardarMarcas()
        {
            _marcalog = new MarcaLog();
            try
            {

                if (string.IsNullOrEmpty(NombreMarca.Text))
                {
                    MessageBox.Show("Se Requiere Nombre de la Marca", "Tienda AS | Registro Marca",
                           MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    NombreMarca.Focus();
                    NombreMarca.BackColor = Color.Azure;
                    return;
                }
                if (string.IsNullOrEmpty(Descripcion.Text))
                {
                    MessageBox.Show("Se Requiere Descripcion de la Marca", "Tienda AS | Registro Registro Marca",
                           MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Descripcion.Focus();
                    Descripcion.BackColor = Color.Azure;
                    return;
                }
                if (!checkMarca.Checked)
                {
                    var dialogo= MessageBox.Show("¿Deseas dejar la Marca Inactiva?", "Tienda AS | Registro Marca",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (dialogo!=DialogResult.Yes)
                    {
                        MessageBox.Show("Selecciona el estado como ACTIVO", "Tienda  AS| Registro Marca",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }

                marcasBinding.EndEdit();
                Marca marca;
                marca = (Marca)marcasBinding.Current;
                int resultado =_marcalog.SaveMarcas(marca);

                if (resultado > 0)
                {
                    MessageBox.Show("¡La Marca se añadió Exitosamente!", "Tienda AS | Registro Marca",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Error! La Marca no se guardo", "Tienda AS | Registro Marca",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Tienda AS | Registro Marca",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Regresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

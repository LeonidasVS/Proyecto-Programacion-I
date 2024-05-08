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
    public partial class MantenimientoMarca : Form
    {
        MarcaLog marca;
        public MantenimientoMarca()
        {
            InitializeComponent();
            CargarMarca();
        }

        private void CargarMarca()
        {
            marca = new MarcaLog();
            TablaMarcas.DataSource = marca.ObtenerMarcas();
            string nombremarca = filtrarPorNombre.Text;

            if (rdbActivos.Checked && filtrarPorNombre.Text.Length > 0)
            {
                TablaMarcas.DataSource = marca.LeerMarcaPornombre(nombremarca);
            }
            else if (rdbInactivos.Checked && filtrarPorNombre.Text.Length > 0)
            {
                TablaMarcas.DataSource = marca.LeerMarcaPornombre(nombremarca,true);
            }
            else if (rdbActivos.Checked)
            {
                TablaMarcas.DataSource = marca.ObtenerMarcas();
            }
            else if (rdbInactivos.Checked)
            {
                TablaMarcas.DataSource = marca.ObtenerMarcas(true);
            }
        }

        private void AñadirMarca_Click(object sender, EventArgs e)
        {
            MarcaRegistro marca = new MarcaRegistro();
            marca.ShowDialog();
            CargarMarca();
        }

        private void Regresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TablaMarcas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    int id = int.Parse(TablaMarcas.Rows[e.RowIndex].Cells["idMarca"].Value.ToString());

                    if (TablaMarcas.Columns[e.ColumnIndex].Name.Equals("Editar"))
                    {

                        MarcaRegistro update = new MarcaRegistro(id);
                        update.ShowDialog();
                        CargarMarca();

                    }else if (TablaMarcas.Columns[e.ColumnIndex].Name.Equals("Eliminar"))
                    {
                        var ValidarEliminar = MessageBox.Show("¿Deseas Eliminar La Marca?", "Tienda AS | Precaución", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (ValidarEliminar == DialogResult.Yes)
                        {
                            marca = new MarcaLog();

                            int resultado = marca.EliminarMarca(id);

                            if (resultado > 0)
                            {
                                MessageBox.Show("Marca Eliminada con Exito", "Tienda AS | Eliminar Marca",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                                CargarMarca();
                            }
                            else
                            {
                                MessageBox.Show("La Marca no se Elimino", "Tienda AS | Eliminar Marca",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error:{ex.Message} ");
            }
        }

        private void rdbActivos_CheckedChanged(object sender, EventArgs e)
        {
            CargarMarca();
        }

        private void rdbInactivos_CheckedChanged(object sender, EventArgs e)
        {
            CargarMarca();
        }

        private void filtrarPorNombre_TextChanged(object sender, EventArgs e)
        {
            CargarMarca();
        }
    }
}

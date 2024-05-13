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

            CargarMarcas();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarMarca objAgregarMarca = new AgregarMarca();
            objAgregarMarca.ShowDialog();
            CargarMarcas();
        }

        private void CargarMarcas()
        {
            _marcaLOG = new MarcaLOG();

            DataGridViewColumn columna = dgvMarcas.Columns["Eliminar"];

            if (rdbActivos.Checked)
            {
                columna.Visible = true;
                dgvMarcas.DataSource = _marcaLOG.ObtenerMarca();
            }
            else if (rdbInactivos.Checked)
            {
                columna.Visible = false;
                dgvMarcas.DataSource = _marcaLOG.ObtenerMarca(true);
            }
        }

        private void dgvMarcas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    int id = int.Parse(dgvMarcas.Rows[e.RowIndex].Cells["Codigo"].Value.ToString());

                    if (dgvMarcas.Columns[e.ColumnIndex].Name.Equals("Editar"))
                    {
                        AgregarMarca objAgregarMarca = new AgregarMarca(id);
                        objAgregarMarca.ShowDialog();
                        CargarMarcas();
                    }
                    else if (dgvMarcas.Columns[e.ColumnIndex].Name.Equals("Eliminar"))
                    {
                        var desicion = MessageBox.Show("¿Está seguro que desea eliminar la marca?", "Tienda | Editar marca",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        _marcaLOG = new MarcaLOG();

                        int resultado = 0;

                        if (desicion != DialogResult.Yes)
                        {
                            MessageBox.Show("La marca se continua mostrando en el listado.", "Tienda | Editar marca",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            resultado = _marcaLOG.EliminarMarca(id);
                            CargarMarcas();

                            if (resultado > 0)
                            {
                                MessageBox.Show("Marca eliminada con Exito.", "Tienda | Editar marca",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("No se logro eliminar la marca.", "Tienda | Editar marca",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Ocurrio un error");
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            CargarMarcas();
        }

        private void rdbActivos_CheckedChanged(object sender, EventArgs e)
        {
            CargarMarcas();
        }
    }
}

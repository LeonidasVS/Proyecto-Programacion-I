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

            DataGridViewColumn columna = dgvMtdsPago.Columns["Eliminar"];

            if (rdbActivos.Checked)
            {
                columna.Visible = true;
                dgvMtdsPago.DataSource = _metodopagoLOG.FormasDePago();
            }
            else if (rdbInactivos.Checked)
            {
                columna.Visible = false;
                dgvMtdsPago.DataSource = _metodopagoLOG.FormasDePago(true);
            }
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarMetodoPago objAgregarMtdsPago = new AgregarMetodoPago();
            objAgregarMtdsPago.ShowDialog();
            CargarMtdsPago();
        }

        private void dgvMtdsPago_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    int id = int.Parse(dgvMtdsPago.Rows[e.RowIndex].Cells["Codigo"].Value.ToString());

                    if (dgvMtdsPago.Columns[e.ColumnIndex].Name.Equals("Editar"))
                    {
                        AgregarMetodoPago objAgregarMetodoPago = new AgregarMetodoPago(id);
                        objAgregarMetodoPago.ShowDialog();
                        CargarMtdsPago();
                    }
                    else if (dgvMtdsPago.Columns[e.ColumnIndex].Name.Equals("Eliminar"))
                    {
                        var desicion = MessageBox.Show("¿Está seguro que desea eliminar la marca?", "Tienda | Editar marca",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        _metodopagoLOG = new MetodoPagoLOG();

                        int resultado = 0;

                        if (desicion != DialogResult.Yes)
                        {
                            MessageBox.Show("La marca se continua mostrando en el listado.", "Tienda | Editar marca",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            resultado = _metodopagoLOG.EliminarMtdPago(id);
                            CargarMtdsPago();

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

        private void rdbActivos_CheckedChanged(object sender, EventArgs e)
        {
            CargarMtdsPago();
        }

        private void rdbInactivos_CheckedChanged(object sender, EventArgs e)
        {
            CargarMtdsPago();
        }
    }
}

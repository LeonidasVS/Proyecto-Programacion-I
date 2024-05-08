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
    public partial class MantenimientoMetodoPago : Form
    {
        MetodoPagoLog metodolog;
        public MantenimientoMetodoPago()
        {
            InitializeComponent();
            CargarMetodoPago();
        }

        private void CargarMetodoPago()
        {
            metodolog = new MetodoPagoLog();
            string nombremetodo = filtrarPorNombre.Text;

            if (rdbActivos.Checked && filtrarPorNombre.Text.Length > 0)
            {
                TablaMetodoPago.DataSource = metodolog.LeerMetodoPornombre(nombremetodo);
            }
            else if (rdbInactivos.Checked && filtrarPorNombre.Text.Length > 0)
            {
                TablaMetodoPago.DataSource = metodolog.LeerMetodoPornombre(nombremetodo, true);
            }
            else if (rdbActivos.Checked)
            {
                TablaMetodoPago.DataSource = metodolog.ObtenerMetodoDePago();
            }
            else if (rdbInactivos.Checked)
            {
                TablaMetodoPago.DataSource = metodolog.ObtenerMetodoDePago(true);
            }
        }

        private void AñadirProducto_Click(object sender, EventArgs e)
        {
            AgregarMetodoPago acceder = new AgregarMetodoPago();
            acceder.ShowDialog();
            CargarMetodoPago();
        }

        private void TablaMetodoPago_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    int id = int.Parse(TablaMetodoPago.Rows[e.RowIndex].Cells["idMetodoPago"].Value.ToString());

                    if (TablaMetodoPago.Columns[e.ColumnIndex].Name.Equals("Editar"))
                    {
                        AgregarMetodoPago acceder = new AgregarMetodoPago(id);
                        acceder.ShowDialog();
                        CargarMetodoPago();

                    }
                    else if (TablaMetodoPago.Columns[e.ColumnIndex].Name.Equals("Eliminar"))
                    {
                        var ValidarEliminar = MessageBox.Show("¿Deseas Eliminar el Metodo de Pago?", "Tienda AS | Precaución", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (ValidarEliminar == DialogResult.Yes)
                        {
                            metodolog = new MetodoPagoLog();

                            int resultado = metodolog.EliminarCategoria(id);

                            if (resultado > 0)
                            {
                                MessageBox.Show("Metodo de Pago Eliminada con Exito", "Tienda AS | Categorias",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                                CargarMetodoPago();
                            }
                            else
                            {
                                MessageBox.Show("Metodo de Pago no se Elimino", "Tienda AS | Categoria",
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
            CargarMetodoPago();
        }

        private void rdbInactivos_CheckedChanged(object sender, EventArgs e)
        {
            CargarMetodoPago();
        }

        private void filtrarPorNombre_TextChanged(object sender, EventArgs e)
        {
            CargarMetodoPago();
        }

        private void Regresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

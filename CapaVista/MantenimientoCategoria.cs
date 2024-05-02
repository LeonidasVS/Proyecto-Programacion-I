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
    public partial class MantenimientoCategoria : Form
    {
        CategoriaLOG _categoriaLOG;
        public MantenimientoCategoria()
        {
            InitializeComponent();

            CargarCategorias();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarCategoria objAgregarCategoria = new AgregarCategoria();
            objAgregarCategoria.ShowDialog();
            CargarCategorias();
        }

        private void CargarCategorias()
        {
            _categoriaLOG = new CategoriaLOG();

            if (rdbActivo.Checked)
            {
                dgvCategorias.DataSource = _categoriaLOG.ObtenerCategorias();
            }
            else if (rdbInactivo.Checked)
            {
                dgvCategorias.DataSource = _categoriaLOG.ObtenerCategorias(true);
            }
            
        }

        private void dgvCategorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    int id = int.Parse(dgvCategorias.Rows[e.RowIndex].Cells["Codigo"].Value.ToString());

                    if (dgvCategorias.Columns[e.ColumnIndex].Name.Equals("Editar"))
                    {
                        AgregarCategoria objAgregarMarca = new AgregarCategoria(id);
                        objAgregarMarca.ShowDialog();
                        CargarCategorias();
                    }
                    else if (dgvCategorias.Columns[e.ColumnIndex].Name.Equals("Eliminar"))
                    {
                        var desicion = MessageBox.Show("¿Está seguro que desea eliminar la marca?", "Tienda | Editar marca",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        _categoriaLOG = new CategoriaLOG();

                        int resultado = 0;

                        if (desicion != DialogResult.Yes)
                        {
                            MessageBox.Show("La marca se continua mostrando en el listado.", "Tienda | Editar marca",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            resultado = _categoriaLOG.EliminarCategoria(id);
                            CargarCategorias();

                            if (resultado > 0)
                            {
                                MessageBox.Show("Marca eliminado con Exito.", "Tienda | Editar marca",
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

        private void rdbActivo_CheckedChanged(object sender, EventArgs e)
        {
            CargarCategorias();
        }

        private void rdbInactivo_CheckedChanged(object sender, EventArgs e)
        {
            CargarCategorias();
        }
    }
}

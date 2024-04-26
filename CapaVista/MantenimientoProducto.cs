using CapaLogica;
using System;
using System.Windows.Forms;

namespace CapaVista
{
    public partial class MantenimientoProducto : Form
    {
        ProductoLog productoLog;
        public MantenimientoProducto()
        {
            InitializeComponent();
            productoLog = new ProductoLog();
            TablaProductos.DataSource = productoLog.ObtenerProductos();
        }

        private void Regresar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AñadirProducto_Click(object sender, EventArgs e)
        {
            Registro_Producto acceder = new Registro_Producto();
            acceder.ShowDialog();
        }

        private void actualizarProducto_Click(object sender, EventArgs e)
        {
            productoLog = new ProductoLog();
            TablaProductos.DataSource = productoLog.ObtenerProductos();
        }

        private void TablaProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex>=0 && e.ColumnIndex>=0)
                {
                    int id = int.Parse(TablaProductos.Rows[e.RowIndex].Cells["idProducto"].Value.ToString());

                    if (TablaProductos.Columns[e.ColumnIndex].Name.Equals("Editar"))
                    {
                        Registro_Producto acceder = new Registro_Producto(id);
                        acceder.ShowDialog();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error");
            }
        }
    }
}

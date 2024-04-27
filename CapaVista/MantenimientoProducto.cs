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
            CargarPRoducto();
;        }

        private void Regresar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AñadirProducto_Click(object sender, EventArgs e)
        {
            Registro_Producto acceder = new Registro_Producto();
            acceder.ShowDialog();
            CargarPRoducto();
        }

        private void CargarPRoducto()
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
                        CargarPRoducto();

                    }else if (TablaProductos.Columns[e.ColumnIndex].Name.Equals("Eliminar"))
                    {
                        var ValidarEliminar = MessageBox.Show("¿Deseas Eliminar EL Producto?", "Tienda AS | Precaución", MessageBoxButtons.YesNo,MessageBoxIcon.Question);

                        if (ValidarEliminar == DialogResult.Yes)
                        {
                            productoLog = new ProductoLog();

                            int resultado = productoLog.EliminarProducto(id);

                            if (resultado>0)
                            {
                                MessageBox.Show("Producto Eliminado con Exito", "Tienda AS | Producto",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                                CargarPRoducto();
                            }
                            else
                            {
                                MessageBox.Show("Producto no se Elimino", "Tienda AS | Producto",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }

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

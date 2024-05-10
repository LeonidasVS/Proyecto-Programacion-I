using CapaLogica;
using System;
using System.Windows.Forms;

namespace CapaVista
{
    public partial class MantenimientoProducto : Form
    {
        ProductoLog productoLog;
        MarcaLog marcalog;
        CategoriaLog categorilog;

        public MantenimientoProducto()
        {
            InitializeComponent();
            CargarPRoducto();
;        }

        //Funcion para cerrar la ventana
        private void Regresar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        //Funcion para agregar un producto. LLamamos e inicializamos la ventana del registro de productos 
        private void AñadirProducto_Click(object sender, EventArgs e)
        {
            Registro_Producto acceder = new Registro_Producto();
            acceder.ShowDialog();

            CargarPRoducto();
        }

        //Funcion para cargar los productos atravez del datagridview para mostrar los productos agregados o los productos actualizados
        private void CargarPRoducto()
        {
            productoLog = new ProductoLog();

            string nombreproducto = filtrarPorNombre.Text;
            DataGridViewColumn columna = TablaProductos.Columns["Eliminar"];

            if (rdbActivos.Checked && filtrarPorNombre.Text.Length > 0)
            {
                columna.Visible = true;
                TablaProductos.DataSource = productoLog.LeerProductoPornombre(nombreproducto);
            }
            else if (rdbInactivos.Checked && filtrarPorNombre.Text.Length > 0)
            {
                columna.Visible = false;
                TablaProductos.DataSource = productoLog.LeerProductoPornombre(nombreproducto, true);
            }
            else if (rdbActivos.Checked)
            {
                columna.Visible = true;
                TablaProductos.DataSource = productoLog.ObtenerProductos();
            }
            else if (rdbInactivos.Checked)
            {
                columna.Visible = false;
                TablaProductos.DataSource = productoLog.ObtenerProductos(true);

            }
        }

        //FUncion para validad la edicion y eliminacion del producto, en donde verificamos la celda que se hace click
        private void TablaProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex>=0 && e.ColumnIndex>=0)
                {
                    //Se parsea el parametro entranda a entero
                    int id = int.Parse(TablaProductos.Rows[e.RowIndex].Cells["idProducto"].Value.ToString());

                    //Validamos si la celda que se toca es la EDITAR
                    if (TablaProductos.Columns[e.ColumnIndex].Name.Equals("Editar"))
                    {
                        //LLamamos e inicializamos la ventana de registro venta ya que tomamos como modelo para mostrar los datos que se actualizaran
                        Registro_Producto acceder = new Registro_Producto(id);
                        acceder.ShowDialog();
                        CargarPRoducto();

                        //Validamos si la celda que se toca si es la de ELIMINAR
                    }
                    else if (TablaProductos.Columns[e.ColumnIndex].Name.Equals("Eliminar"))
                    {
                        //Preguntamos si el usuario esta seguro de eliminar el producto
                        var ValidarEliminar = MessageBox.Show("¿Deseas Eliminar EL Producto?", "Tienda AS | Precaución", MessageBoxButtons.YesNo,MessageBoxIcon.Question);

                        if (ValidarEliminar == DialogResult.Yes)
                        {
                            //Inicilizamos o llamamos la capa logica de ProductoLog
                            productoLog = new ProductoLog();

                            //Y le pasamos el id como parametro que se eliminara 
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
                MessageBox.Show($"Error:{ex.Message} ");
            }
        }

        private void TablaProductos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            marcalog = new MarcaLog();

            if (e.RowIndex>=0 && e.ColumnIndex == TablaProductos.Columns["idMarca"].Index)
            {
                int idMarca = Convert.ToInt32(e.Value);
                string nombreMarca = marcalog.mostrarNombreMarca(idMarca);
                e.Value = nombreMarca;
                e.FormattingApplied = true;
            }

            categorilog = new CategoriaLog();

            if (e.RowIndex >= 0 && e.ColumnIndex == TablaProductos.Columns["idCategoria"].Index)
            {
                int idcategoria = Convert.ToInt32(e.Value);
                string nombreCategoria = categorilog.mostrarNombreCategorya(idcategoria);
                e.Value = nombreCategoria;
                e.FormattingApplied = true;
            }

        }

        private void rdbActivos_CheckedChanged(object sender, EventArgs e)
        {
            CargarPRoducto();
        }

        private void rdbInactivos_CheckedChanged(object sender, EventArgs e)
        {
            CargarPRoducto();
        }

        private void filtrarPorNombre_TextChanged(object sender, EventArgs e)
        {
            CargarPRoducto();
        }

        private void cbxMarcas_SelectedIndexChanged(object sender, EventArgs e)
        {
            filtrarPorNombre.Clear();
            CargarPRoducto();
        }
    }
}

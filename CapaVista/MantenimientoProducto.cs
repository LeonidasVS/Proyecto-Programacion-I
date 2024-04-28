﻿using CapaLogica;
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
            TablaProductos.DataSource = productoLog.ObtenerProductos();
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
    }
}

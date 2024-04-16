using Capa_Entidades;
using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista
{
    public partial class Registro_Producto : Form
    {
        ProductoLog _productoLog;

    public Registro_Producto()
        {
            InitializeComponent();
            ProductoBindingSource.MoveLast();
            ProductoBindingSource.AddNew();
        }

        private void Salir2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GuardarProducto_Click(object sender, EventArgs e)
        {
            Guardarproducto();
        }

        private void Guardarproducto()
        {
            try
            {
                _productoLog = new ProductoLog();

                if (string.IsNullOrEmpty(textBox1.Text))
                {
                    MessageBox.Show("Se requiere el nombre del producto", "Tienda AS | Registro Producto",
                       MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox1.Focus();
                    textBox1.BackColor = Color.Azure;
                    return;
                }
                if (string.IsNullOrEmpty(DescripcionProducto.Text))
                {
                    MessageBox.Show("Se requiere la descripcion del producto", "Tienda AS | Registro Producto",
                       MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    DescripcionProducto.Focus();
                    DescripcionProducto.BackColor = Color.Azure;
                    return;
                }
                if (string.IsNullOrEmpty(PrecioUni.Text) || Convert.ToDecimal(PrecioUni.Text) == 0)
                {
                    MessageBox.Show("Por favor ingrese el precio valido del producto", "Tienda AS | Registro Producto",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    PrecioUni.Focus();
                    PrecioUni.BackColor = Color.Azure;
                }
                else if (string.IsNullOrEmpty(Stock.Text) || Convert.ToDecimal(Stock.Text) == 0)
                {
                    MessageBox.Show("Por favor ingrese las existencias validas del producto", "Tienda AS | Registro Producto",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Stock.Focus();
                    Stock.BackColor = Color.Azure;
                }
                else if (!Activo.Checked)
                {
                    var dialogo = MessageBox.Show("Estas seguro que desea guardar el producto inactivo?", "Tienda AS | Registro Producto",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (dialogo != DialogResult.Yes)
                    {
                        MessageBox.Show("Seleccione el cuadro estado como activo", "Tienda  AS| Registro Productos",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }

                Producto producto;
                producto = (Producto)ProductoBindingSource.Current;
                int resultado = _productoLog.SaveProducto(producto);

                if (resultado > 0)
                {
                    MessageBox.Show("Producto Agregado con Exito", "Tienda | Registro Productos",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se logro agregagr el producto", "Tienda | Registro Productos",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error :(", "Tienda | Registro Productos",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

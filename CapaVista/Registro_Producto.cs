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
                if (string.IsNullOrEmpty(Stock.Text) || Convert.ToDecimal(Stock.Text)==0)
                {
                    MessageBox.Show("Se requiere existencia del producto", "Tienda AS | Registro Producto",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Stock.Focus();
                    Stock.BackColor = Color.Azure;
                    return;
                }
                if (string.IsNullOrEmpty(PrecioUni.Text) || Convert.ToDecimal(PrecioUni.Text) == 0)
                {
                    MessageBox.Show("Se requiere precio del producto", "Tienda AS | Registro Producto",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);
                    PrecioUni.Focus();
                    PrecioUni.BackColor = Color.Azure;
                    return;
                }
                if (!Activo.Checked)
                {
                    var dialogo= MessageBox.Show("¿Desear guardar el produco INACTIVO?", "Tienda AS | Registro Producto",
                       MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (dialogo==DialogResult.No)
                    {
                        MessageBox.Show("Chequea el estado como ACTIVO", "Tienda AS | Registro Producto",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }

                ProductoBindingSource.EndEdit();
                Producto producto;
                producto = (Producto)ProductoBindingSource.Current;
                int resultado = _productoLog.SaveProducto(producto);

                if (resultado > 0)
                {
                    MessageBox.Show("Producto añadido 'Exitosamente'", "Tienda AS | Registro Producto",
                      MessageBoxButtons.OK, MessageBoxIcon.Information);
                    resert();
                }
                else
                {
                    MessageBox.Show("Error de registro", "Tienda AS | Registro Producto",
                      MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch(Exception){
                MessageBox.Show("Eror! La creacion fue denegada", "Tienda AS | Registro Producto",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        public void resert()
        {

            textBox1.Clear();
            DescripcionProducto.Clear();
            Stock.Clear();
            PrecioUni.Clear();
            textBox1.BackColor = Color.White;
            DescripcionProducto.BackColor = Color.White;
            Stock.BackColor = Color.White;
            PrecioUni.BackColor = Color.White;
            Activo.Checked = false;

        }
    }
}

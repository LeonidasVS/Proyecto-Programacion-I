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
        public Registro_Producto()
        {
            InitializeComponent();
        }

        private void Salir2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void GuardarProducto_Click(object sender, EventArgs e)
        {
            GuardarPro();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                DescripcionProducto.Focus();
            }
        }

        private void DescripcionProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                PrecioUni.Focus();
            }
        }

        private void PrecioUni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                Stock.Focus();
            }
        }

        private void Stock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void GuardarPro()
        {
            try
            {

                if (string.IsNullOrEmpty(textBox1.Text))
                {
                    MessageBox.Show("Se requiere nombre de producto", "Store AS | Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox1.Focus();
                    textBox1.BackColor = Color.Azure;
                    return;
                }
                if (string.IsNullOrEmpty(DescripcionProducto.Text))
                {
                    MessageBox.Show("Se requiere descripcion de producto", "Store AS | Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    DescripcionProducto.Focus();
                    DescripcionProducto.BackColor = Color.Azure;
                    return;
                }
                if (string.IsNullOrEmpty(PrecioUni.Text) || Convert.ToDecimal(PrecioUni.Text) == 0)
                {
                    MessageBox.Show("Se requiere precio de producto", "Store AS | Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    PrecioUni.Focus();
                    PrecioUni.BackColor = Color.Azure;
                    return;
                }
                if (string.IsNullOrEmpty(Stock.Text) || Convert.ToDecimal(Stock.Text) == 0)
                {
                    MessageBox.Show("Se requiere existencias de producto", "Store AS | Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Stock.Focus();
                    Stock.BackColor = Color.Azure;
                    return;
                }
                if (!checkBox1.Checked)
                {
                    var dialogo = MessageBox.Show("¿Desear guardar el producto inactivo?", "Store AS | Registro Producto", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (dialogo==DialogResult.No)
                    {
                        MessageBox.Show("Chequea el campo 'Estado' como ACTIVO", "Store AS | Registro Producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un eror", "Store AS | Registro de Productos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {

            }
        }
    }
}

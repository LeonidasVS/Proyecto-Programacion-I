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
            textBox1.BackColor = Color.White;
            DescripcionProducto.BackColor = Color.White;
            PrecioUni.BackColor = Color.White;
            Stock.BackColor = Color.White;
        }

        private void Salir2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void GuardarProducto_Click(object sender, EventArgs e)
        {

            if (textBox1.Text.Length == 0 || DescripcionProducto.Text.Length == 0 || PrecioUni.Text == "" || Stock.Text == "")
            {
                MessageBox.Show("Rellena los campos vacios", "Error | Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (PrecioUni.Text == "0" || Stock.Text == "0")
                {
                    MessageBox.Show("El Precio o las Existencias tienen que ser diferente de 0", "Error | Falta de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    
                }
            }
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
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
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
    }
}

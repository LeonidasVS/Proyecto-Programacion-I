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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

        }

        public string Username { get; set; }
        public string Contraseña { get; set; }

        public void Ventana()
        {
            Principal StoreAS = new Principal(Contraseña);
            StoreAS.ShowDialog();
        }


        private void Usuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtcontrasena.Focus();
            }
        }

        private void Password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        public void Limpiar()
        {
            txtUsuario.Clear();
            txtcontrasena.Clear();
        }

        private void buttonAcceder_Click(object sender, EventArgs e)
        {
            Username = txtUsuario.Text;
            Contraseña = txtcontrasena.Text;

            if (Username == "admin123" && Contraseña == "admin123")
            {
                Limpiar();
                Ventana();
            }
            else if (Username == "vendedor123" && Contraseña == "vendedor123")
            {
                Limpiar();
                Ventana();
            }
            else
            {
                MessageBox.Show("Error!! Intentalo de nuevo", "Store AS | Datos incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Limpiar();
            }
        }
    }
}

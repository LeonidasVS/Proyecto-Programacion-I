using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista
{
    public partial class Login : System.Windows.Forms.Form
    {
        public Login()
        {
            InitializeComponent();
        }
        public string Username { get; set; }
        public string Contraseña { get; set; }

        public void Inicio()
        {
            Store_AS StoreAS = new Store_AS(Contraseña);
            StoreAS.ShowDialog();
        }


        private void Usuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            if (e.KeyChar==Convert.ToChar(Keys.Enter))
            {
                Password.Focus();
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
            Usuario.Clear();
            Password.Clear();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            Username = Usuario.Text;
            Contraseña = Password.Text;

            if (Username == "admin123" && Contraseña == "admin123")
            {
                Limpiar();
               Inicio();
            }
            else if (Username == "vendedor123" && Contraseña == "vendedor123")
            {
               Limpiar();
               Inicio();
            }
            else
            {
                MessageBox.Show("Error!! Intentalo de nuevo", "Store AS | Datos incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Limpiar();
            }
        }

        private void Usuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

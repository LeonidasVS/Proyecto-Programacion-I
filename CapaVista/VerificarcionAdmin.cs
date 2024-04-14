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
    public partial class VerificarcionAdmin : System.Windows.Forms.Form
    {
        public VerificarcionAdmin()
        {
            InitializeComponent();
        }
        public string Username { get; set; }
        public string Contraseña { get; set; }

        public void Ventana()
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
               Ventana();
            }
            else if (Username == "vendedor123" && Contraseña == "vendedor123")
            {
               Ventana();
            }
            else
            {
                MessageBox.Show("Error!! Intentalo de nuevo", "Inicio de Sesión", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Limpiar();
            }
        }
    }
}

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
        //Se inicializa 2 constantes para obtener el nombre y contraseña del usuario
        public string Username { get; set; }
        public string Contraseña { get; set; }

        public void Inicio()
        {
            //Llamamos la ventana principal y le pasamos el parametro de la contraseña 
            //para validar el tipo de usuario logeado
            Store_AS StoreAS = new Store_AS(Contraseña);
            StoreAS.ShowDialog();
        }


        private void Usuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Validacion de la entrada de caracteres
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
            //Validacion de la entrada de caracteres
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
            //Funcion para validar el tipo de usuario que se esta logeando y validar credenciales
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
    }
}

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
    public partial class MantenimientoProducto : Form
    {
        public MantenimientoProducto()
        {
            InitializeComponent();
        }

        private void Regresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AgregarProducto_Click(object sender, EventArgs e)
        {
            Registro_Producto acceder = new Registro_Producto();
            acceder.ShowDialog();
        }
    }
}

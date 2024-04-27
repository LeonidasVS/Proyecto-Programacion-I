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
    public partial class MantenimientoMarca : Form
    {
        public MantenimientoMarca()
        {
            InitializeComponent();
        }

        private void AñadirMarca_Click(object sender, EventArgs e)
        {
            MarcaRegistro marca = new MarcaRegistro();
            marca.ShowDialog();
        }
    }
}

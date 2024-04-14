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
    public partial class Store_AS : System.Windows.Forms.Form
    {
        public Store_AS(string pass)
        {
            InitializeComponent();
            if (pass== "vendedor123")
            {
                Producto.Enabled = false;
                RegistroVentas.Enabled = false;

            }
        }

    }
}

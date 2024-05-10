using CapaEntidades;
using CapaLogica;
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
    public partial class Factura : Form
    {
        DetalleVentaLOG _detalleVentaLOG;
        ProductoLOG _productoLOG;
        VentaLOG _ventaLOG;
        MetodoPagoLOG _metodoPagoLOG;
        int _id;
        public Factura(int id = 55)
        {
            _id = id;
            InitializeComponent();

        }

        private void Factura_Load(object sender, EventArgs e)
        {
            _detalleVentaLOG = new DetalleVentaLOG();
            _productoLOG = new ProductoLOG();
            _ventaLOG = new VentaLOG();
            _metodoPagoLOG = new MetodoPagoLOG();

            var detallesVenta = _detalleVentaLOG.ObtenerDetalleVentaPorIdVent(_id);

            int index = 3; // Posición vertical inicial

            labelFecha.Text = _ventaLOG.FechaVentaPorId(_id);
            lblTotal.Text = _ventaLOG.TotalVentaPorId(_id).ToString();
            lblMtdPago.Text = _metodoPagoLOG.ObtenerNombreMtdPagodesdeBD(_detalleVentaLOG.IdMetodoPagoPoridVenta(_id));

            foreach (var detalleVenta in detallesVenta)
            {
                // Crear Labels para el nombre, precio y cantidad del producto
                Label lblNombre = new Label();
                lblNombre.Text = _productoLOG.NombreProductoDesdeBD(detalleVenta.ProductoId);
                Label lblPrecio = new Label();
                lblPrecio.Text = detalleVenta.Precio.ToString();
                Label lblCantidad = new Label();
                lblCantidad.Text = detalleVenta.Cantidad.ToString();
                Label lblSubTotal = new Label();
                lblSubTotal.Text = (detalleVenta.Cantidad*detalleVenta.Precio).ToString();

                // Configurar la posición de los Labels
                lblNombre.Left = 12; // Posición horizontal
                lblNombre.Size = new Size(200,18);
                lblPrecio.Left = 299; // Posición horizontal
                lblCantidad.Left = 400; // Posición horizontal
                lblCantidad.Size = new Size(75, 18);
                lblSubTotal.Left = 485;
                lblNombre.Top = 20 + (index * 60); // Espacio vertical entre productos
                lblPrecio.Top = lblNombre.Top; // Misma posición vertical que lblNombre
                lblCantidad.Top = lblNombre.Top; // Misma posición vertical que lblNombre
                lblSubTotal.Top = lblNombre.Top;

                // Agregar los Labels al formulario
                this.Controls.Add(lblNombre);
                this.Controls.Add(lblPrecio);
                this.Controls.Add(lblCantidad);
                this.Controls.Add(lblSubTotal);

                // Incrementar la posición vertical para el próximo conjunto de Labels
                index++;
            }
        }

        private void btnHecho_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

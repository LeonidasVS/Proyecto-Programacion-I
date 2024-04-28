using Capa_Entidades;
using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista
{
    public partial class Registro_Producto : Form
    {
        ProductoLog _productoLog;
        MarcaLog _marcaLog;
        CategoriaLog categoriaLog;
        int _id=0;
        public Registro_Producto(int id=0)
        {
            _id = id;
            InitializeComponent();

            if (_id > 0)
            {
                this.Text = "Tienda Store_AS | Edicion de Productos";
                GuardarProducto.Text = "Update";
                Titulo.Text = "Edicion de Productos";
                CargarDatosProdutos(_id);
            }
            else
            {
                CargarMarcas();
                CargarCategorias();
                ProductoBindingSource.MoveLast();
                ProductoBindingSource.AddNew();
            }
        }

        private void CargarDatosProdutos(int id)
        {
            _productoLog = new ProductoLog();
            ProductoBindingSource.DataSource = _productoLog.ObtenerProductoPorId(id);
            CargarMarcas();
            CargarCategorias();
        }

        private void CargarMarcas()
        {
            _marcaLog = new MarcaLog();
            marcaBindingSource.DataSource = _marcaLog.ObtenerMarcas();

        }
        private void CargarCategorias()
        {
            categoriaLog = new CategoriaLog();
            categoriaBindingSource.DataSource = categoriaLog.ObtenerCategorias();
            
        }
        private void Regresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void GuardarProducto_Click(object sender, EventArgs e)
        {
            Guardarproducto();
        }

        private void Guardarproducto()
        {
            try
            {
                _productoLog = new ProductoLog();

                if (string.IsNullOrEmpty(textBox1.Text))
                {
                    MessageBox.Show("Se Requiere Nombre del Producto", "Tienda AS | Registro Producto",
                       MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox1.Focus();
                    textBox1.BackColor = Color.Azure;
                    return;
                }
                if (string.IsNullOrEmpty(DescripcionProducto.Text))
                {
                    MessageBox.Show("Se Requiere Descripcion del Producto", "Tienda AS | Registro Producto",
                       MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    DescripcionProducto.Focus();
                    DescripcionProducto.BackColor = Color.Azure;
                    return;
                }
                if (string.IsNullOrEmpty(Stock.Text) || Convert.ToDecimal(Stock.Text) == 0)
                {
                    MessageBox.Show("Se Requiere Existencias del Producto", "Tienda AS | Registro Producto",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Stock.Focus();
                    Stock.BackColor = Color.Azure;
                    return;
                }
                if (string.IsNullOrEmpty(PrecioUni.Text) || Convert.ToDecimal(PrecioUni.Text) == 0)
                {
                    MessageBox.Show("Se Requiere Precio del Producto", "Tienda AS | Registro Producto",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    PrecioUni.Focus();
                    PrecioUni.BackColor = Color.Azure;
                    return;
                }
                if (!Activo.Checked)
                {
                    var dialogo = MessageBox.Show("¿Deseas Dejar El Producto Inactivo?", "Tienda AS | Registro Producto",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (dialogo != DialogResult.Yes)
                    {
                        MessageBox.Show("Selecciona el estado como ACTIVO", "Tienda  AS| Registro Productos",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
                if (cbxMarca.SelectedItem==null)
                {
                    MessageBox.Show("Selecciona una Marca del Producto", "Tienda AS | Registro Producto",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (cbxCategoria.SelectedItem==null)
                {
                    MessageBox.Show("Selecciona una Categoria del Producto", "Tienda AS | Registro Producto",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int resultado;

                if (_id > 0)
                {
                    Producto producto;
                    producto = (Producto)ProductoBindingSource.Current;

                    resultado = _productoLog.ActualizarProducto(producto,_id);

                    if (resultado > 0)
                    {
                        MessageBox.Show("¡ EL Producto se Actualizo Exitosamente !", "Tienda AS | Registro Productos",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error! El producto no se actualizo", "Tienda AS | Registro Productos",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {

                    Producto producto;
                    producto = (Producto)ProductoBindingSource.Current;
                    resultado = _productoLog.SaveProducto(producto);

                    if (resultado > 0)
                    {
                        MessageBox.Show("¡ EL Producto se añadió Exitosamente !", "Tienda AS | Registro Productos",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error! El producto no se guardo", "Tienda AS | Registro Productos",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show($"Ocurrio un error {ex.Message} :(", "Tienda AS | Registro Productos",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}

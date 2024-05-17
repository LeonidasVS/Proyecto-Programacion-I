using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class ProductoLOG
    {
        ProductoDAL _productoDAL;

        public int EditarProducto(Producto producto, int id)
        {
            _productoDAL = new ProductoDAL();
            return _productoDAL.Guardar(producto, id, true);
        }

        public List<Producto> Filtrar(int idCategoria = 0, bool inactivo = false, int idMarca = 0, string nombre = null)
        {
            _productoDAL = new ProductoDAL();
            return _productoDAL.Filtrar(idCategoria, inactivo, idMarca, nombre);
        }

        public int EliminarProducto(int id)
        {
            _productoDAL = new ProductoDAL();
            return _productoDAL.EliminarProducto(id);
        }

        public int GuardarProducto(Producto producto, int id = 0, bool esActualizacion = false)
        {
            _productoDAL = new ProductoDAL();

            return _productoDAL.Guardar(producto, id, esActualizacion);
        }

        public Producto ObtenerProductoPorId(int codigo)
        {
            _productoDAL= new ProductoDAL();
            return _productoDAL.LeerPorId(codigo);
        }

        public List<Producto> ObtenerProductos(bool inactivos = false)
        {  
            _productoDAL = new ProductoDAL();
            return _productoDAL.Leer(inactivos);
        }

        public void ProductoAgotado()
        {
            _productoDAL = new ProductoDAL();
            _productoDAL.EliminarAgotado();
        }

        public string NombreProductoDesdeBD(int id)
        {
            _productoDAL = new ProductoDAL();
            return _productoDAL.ObtenerNombreProductoDesdeBD(id);
        }
    }
}

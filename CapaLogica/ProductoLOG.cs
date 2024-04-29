using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
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
    }
}

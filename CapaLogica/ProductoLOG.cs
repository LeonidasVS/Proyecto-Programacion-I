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

        public int EliminarProducto(int id)
        {
            _productoDAL = new ProductoDAL();
            return _productoDAL.EliminarProducto(id);
        }

        public List<Producto> FiltrarPorcategoria(int idCategoria, bool inactivo = false)
        {
            _productoDAL = new ProductoDAL();
            return _productoDAL.FiltrarPorCategoria(idCategoria, inactivo);
        }

        public List<Producto> FiltrarPorMarca(int idMarca, bool inactivo = false)
        {
            _productoDAL = new ProductoDAL();
            return _productoDAL.FiltrarPorMarca(idMarca, inactivo);
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

        public int ObtenerExistenciasDesdeBD(int id) 
        {
            _productoDAL = new ProductoDAL();
            return _productoDAL.ObtenerExistenciasDesdeBD(id);
        }

        public List<Producto> FiltrarPorNombre(string nombre, bool inactivo = false)
        {
            _productoDAL = new ProductoDAL();
            return _productoDAL.FiltrarPorNombre(nombre, inactivo);
        }

        public string NombreProductoDesdeBD(int id)
        {
            _productoDAL = new ProductoDAL();
            return _productoDAL.ObtenerNombreProductoDesdeBD(id);
        }
    }
}

using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class ProductoDAL
    {
        ContextoBd _db;

        public int EliminarProducto(int id)
        {
            _db = new ContextoBd();
            int resultado = 0;

            var producto = _db.Productos.Find(id);

            if (producto != null)
            {
                producto.Estado = false;
                _db.SaveChanges();

                resultado = producto.idProducto;
            }

            return resultado;
        }

        public List<Producto> FiltrarPorCategoria(int idCategoria, bool inactivo = false)
        {
            _db = new ContextoBd();
            if (inactivo)
            {
                return _db.Productos.Where(p => p.idCategoria == idCategoria && p.Estado == false).ToList();
            }
            else
            {
                return _db.Productos.Where(p => p.idCategoria == idCategoria && p.Estado == true).ToList();
            }
        }

        public List<Producto> FiltrarPorMarca(int idMarca, bool inactivo = false)
        {
            _db = new ContextoBd();
            if (inactivo)
            {
                return _db.Productos.Where(p => p.idMarca == idMarca && p.Estado == false).ToList();
            }
            else
            {
                return _db.Productos.Where(p => p.idMarca == idMarca && p.Estado == true).ToList();
            }
        }

        public int Guardar(Producto producto, int id = 0, bool esActualizacion = false)
        {
            _db = new ContextoBd();
            int resultado;

            if (esActualizacion)
            {
                producto.idProducto = id;

                _db.Entry(producto).State = System.Data.Entity.EntityState.Modified;
                _db.SaveChanges();

                resultado = producto.idProducto;
            }
            else
            {
                _db.Productos.Add(producto);
                _db.SaveChanges();

                resultado = producto.idProducto;
            }
            return resultado;
        }

        public List<Producto> Leer(bool inactivos = false)
        {
            _db = new ContextoBd();
            if (inactivos)
            {
                return _db.Productos.Where(p => p.Estado == false).ToList();
            }
            else
            {
                return _db.Productos.Where(p => p.Estado == true).ToList();
            }

        }
        public Producto LeerPorId(int id)
        {
            _db = new ContextoBd();
            return _db.Productos.Find(id);
        }

        public void EliminarAgotado()
        {
            _db = new ContextoBd();
            var productoAgotado = _db.Productos.Where(p => p.Stock == 0);

            foreach (var producto in productoAgotado)
            {
                producto.Estado = false;
            }
            _db.SaveChanges();
        }
        public int ObtenerExistenciasDesdeBD(int id)
        {
            _db = new ContextoBd();
            var producto = _db.Productos.FirstOrDefault(p => p.idProducto == id);
            if (producto != null)
            {
                return producto.Stock;
            }
            else
            {
                return 0;
            }
        }

        public List<Producto> FiltrarPorNombre(string nombre, bool inactivo = false)
        {
            _db = new ContextoBd();
            if (inactivo)
            {
                return _db.Productos.Where(p => p.Estado == false && p.Nombre.Contains(nombre)).ToList();
            }
            else
            {
                return _db.Productos.Where(p => p.Estado == true && p.Nombre.Contains(nombre)).ToList();
            }
        }

        public string ObtenerNombreProductoDesdeBD(int id)
        {
            string nombreProducto = string.Empty;
            _db = new ContextoBd();
            Producto producto = _db.Productos.FirstOrDefault(p => p.idProducto == id);
            if (producto != null)
            {
                nombreProducto = producto.Nombre;
            }

            return nombreProducto;
        }
    }
}

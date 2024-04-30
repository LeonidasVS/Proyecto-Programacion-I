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
        ContextoBD _db;

        public int EliminarProducto(int id)
        {
            _db = new ContextoBD();
            int resultado = 0;

            var producto = _db.Productos.Find(id);

            if (producto != null)
            {
                producto.Activo = false;
                _db.SaveChanges();

                resultado = producto.IdProducto;
            }

            return resultado;
        }

        public List<Producto> FiltrarPorMarca(int idMarca, bool inactivo = false)
        {
            _db = new ContextoBD();
            if (inactivo)
            {
                return _db.Productos.Where(p => p.idMarca == idMarca && p.Activo == false).ToList();
            }
            else
            {
                return _db.Productos.Where(p => p.idMarca == idMarca && p.Activo == true).ToList();
            }
        }

        public int Guardar(Producto producto, int id = 0, bool esActualizacion = false)
        {
            _db = new ContextoBD();
            int resultado;

            if (esActualizacion)
            {
                producto.IdProducto = id;

                _db.Entry(producto).State = System.Data.Entity.EntityState.Modified;
                _db.SaveChanges();

                resultado = producto.IdProducto;
            }
            else
            {
                _db.Productos.Add(producto);
                _db.SaveChanges();

                resultado = producto.IdProducto;
            }
            return resultado;
        }

        public List<Producto> Leer(bool inactivos = false)
        {
            _db = new ContextoBD();
            if (inactivos)
            {
                return _db.Productos.Where(p => p.Activo == false).ToList();
            }
            else
            {
                return _db.Productos.Where(p => p.Activo == true).ToList();
            }

        }
        public Producto LeerPorId(int id)
        {
            _db = new ContextoBD();
            return _db.Productos.Find(id);
        }
    }
}

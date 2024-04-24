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

        public List<Producto> Leer()
        {
            _db = new ContextoBd();
            return _db.Productos.Where(p => p.Estado == true).ToList();

        }
        public Producto LeerPorId(int id)
        {
            _db = new ContextoBd();
            return _db.Productos.Find(id);
        }
    }
}

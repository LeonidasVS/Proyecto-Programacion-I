using System;
using CapaDatos;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Entidades;

namespace CapaLogica
{
    public class ProductoLog
    {
        ProductoDAL productodal;

        public int SaveProducto(Producto producto, int id=0,bool actualizacion=false)
        {
            productodal = new ProductoDAL();
            return productodal.GuardarProducto(producto, id, actualizacion);
        }

        public int ActualizarProducto(Producto producto,int id )
        {
            productodal = new ProductoDAL();

            return productodal.GuardarProducto(producto, id, true);
        }
        public List<Producto> ObtenerProductos()
        {
            productodal = new ProductoDAL();
            return productodal.leer();
        }
        public Producto ObtenerProductoPorId(int codigo)
        {
            productodal = new ProductoDAL();

            return productodal.LeerProducto(codigo);
        }

        public int EliminarProducto(int id)
        {
            productodal = new ProductoDAL();
            return productodal.Eliminar(id);
        }
    }
}

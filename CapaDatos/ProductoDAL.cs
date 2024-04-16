using Capa_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class ProductoDAL
    {
        ContextoBD contexto;
        
        public int GuardarProducto(Producto producto,int id=0, bool actualizacion=false)
        {
            contexto = new ContextoBD();
            int resultado;

            if (actualizacion)
            {
                producto.idProducto = id;

                contexto.Entry(producto).State = System.Data.Entity.EntityState.Modified;
                contexto.SaveChanges();

                resultado = producto.idProducto;
            }
            else
            {
                contexto.Producto.Add(producto);
                contexto.SaveChanges();

                resultado = producto.idProducto;
            }

            return resultado;
        }

        public List<Producto> leer()
        {
            contexto = new ContextoBD();
            return contexto.Producto.Where(p => p.Estado == true).ToList();
        }
        public Producto LeerProducto(int id)
        {
            contexto = new ContextoBD();
            return contexto.Producto.Find(id);
        }
    }
}

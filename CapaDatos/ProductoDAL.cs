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

        public int Eliminar(int id)
        {
            contexto = new ContextoBD();
            int resultado=0;

            var producto = contexto.Producto.Find(id);

            if (producto!=null)
            {
                producto.Estado = false;
                contexto.SaveChanges();

                resultado = producto.idProducto;
            }

            return resultado;
        }

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

        public List<Producto> leer(bool inactivos=false)
        {
            contexto = new ContextoBD();

            if (inactivos)
            {
                return contexto.Producto.Where(p => p.Estado == false).ToList();
            }
            else
            {
                return contexto.Producto.Where(p => p.Estado == true).ToList();
            }
        }

        public List<Producto> LeerPorNombre(string nombre, bool inactivos = false)
        {
            contexto = new ContextoBD();

            if (inactivos)
            {
                return contexto.Producto.Where(p => p.Estado == false && p.Nombre.Contains(nombre)).ToList();
            }
            else
            {
                return contexto.Producto.Where(p => p.Estado == true && p.Nombre.Contains(nombre)).ToList();
            }
        }
        public Producto LeerProducto(int id)
        {
            contexto = new ContextoBD();
            return contexto.Producto.Find(id);
        }

        public string ObtenerNombreProductoDesdeBD(int idProducto)
        {
            string nombreProducto = string.Empty;
            contexto = new ContextoBD();
            Producto pro = contexto.Producto.FirstOrDefault(m => m.idProducto == idProducto);
            if (pro != null)
            {
                nombreProducto = pro.Nombre;
            }
            return nombreProducto;
        }
    }
}

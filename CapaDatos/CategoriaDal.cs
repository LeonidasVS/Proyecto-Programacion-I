using Capa_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CategoriaDAL
    {
        ContextoBD contexto;
       
        public int SaveCategoria(Categoria categoria, int id=0,bool esActualizacion=false)
        {
            contexto = new ContextoBD();
            int resultado;

            if (esActualizacion)
            {
                categoria.idCategoria = id;
                contexto.Entry(categoria).State = System.Data.Entity.EntityState.Modified;
                contexto.SaveChanges();

                resultado = categoria.idCategoria;
            }
            else
            {

                contexto.Categoria.Add(categoria);
                contexto.SaveChanges();

                resultado = categoria.idCategoria;
            }

            return resultado;
        }

        public List<Categoria> LeerCategoria()
        {
            contexto = new ContextoBD();
            return contexto.Categoria.Where(c => c.Estado == true).ToList();
        }

        public Categoria BuscarCategoria(int id)
        {
            contexto = new ContextoBD();
            return contexto.Categoria.Find(id);
        }

        public int Eliminar(int id)
        {
            contexto = new ContextoBD();
            int resultado = 0;

            var cate = contexto.Categoria.Find(id);

            if (cate != null)
            {
                cate.Estado = false;
                contexto.SaveChanges();

                resultado = cate.idCategoria;
            }

            return resultado;
        }

        public string ObtenerNombreCategoriaDesdeBD(int idcategoria)
        {
            string nombreCategoria = string.Empty;
            contexto = new ContextoBD();
            Categoria cate = contexto.Categoria.FirstOrDefault(m => m.idCategoria == idcategoria);
            if (cate != null)
            {
                nombreCategoria = cate.Nombre;
            }
            return nombreCategoria;
        }
    }
}

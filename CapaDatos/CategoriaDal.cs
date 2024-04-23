using Capa_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CategoriaDal
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
            return contexto.Categoria.Find(id);
        }
    }
}

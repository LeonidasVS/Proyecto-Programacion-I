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
        public List<Categoria> LeerCategoria()
        {
            contexto = new ContextoBD();
            return contexto.Categoria.Where(c => c.idCategoria > 0).ToList();
        }
        public Categoria BuscarCategorias(int id)
        {
            contexto = new ContextoBD();
            return contexto.Categoria.Find(id);
        }
    }
}

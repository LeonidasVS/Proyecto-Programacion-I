using Capa_Entidades;
using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class CategoriaLog
    {
        CategoriaDAL categoriaDAL;

        public int GuardarCategoria(Categoria categoria,int id=0,bool Actualizacion=false)
        {
            categoriaDAL = new CategoriaDAL();
            return categoriaDAL.SaveCategoria(categoria,id,Actualizacion);
        }
        public List<Categoria> ObtenerCategorias()
        {
            categoriaDAL = new CategoriaDAL();
            return categoriaDAL.LeerCategoria();
        }
    }
}

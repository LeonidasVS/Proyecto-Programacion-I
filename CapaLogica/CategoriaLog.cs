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
        CategoriaDal categorialog;
        public List<Categoria> ObtenerCategorias()
        {
            categorialog = new CategoriaDal();
            return categorialog.LeerCategoria();
        }
    }
}

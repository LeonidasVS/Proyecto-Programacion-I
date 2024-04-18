using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CategoriaDAL
    {
        ContextoBD _db;
        public List<Categoria> Categorias()
        {
            _db = new ContextoBD();
            return _db.Categorias.ToList();
        }

        public string ObtenerNombreCategoriaDesdeBD(int idCategoria)
        {
            string nombreCategoria = string.Empty;
            _db = new ContextoBD();
            Categoria categoria = _db.Categorias.FirstOrDefault(m => m.idCategoria == idCategoria);
            if (categoria != null)
            {
                nombreCategoria = categoria.Nombre;
            }
            return nombreCategoria;
        }
    }
}

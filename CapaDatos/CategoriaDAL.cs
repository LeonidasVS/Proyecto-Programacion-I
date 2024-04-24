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
        ContextoBd _db;

        public int AgregarCategoria(Categoria categoria, int id = 0, bool esActualizacion = false)
        {
            _db = new ContextoBd();
            int resultado;

            if (esActualizacion)
            {
                categoria.idCategoria = id;
                _db.Entry(categoria).State = System.Data.Entity.EntityState.Modified;
                _db.SaveChanges();

                resultado = categoria.idCategoria;
            }
            else
            {

                _db.Categorias.Add(categoria);
                _db.SaveChanges();

                resultado = categoria.idCategoria;
            }

            return resultado;
        }
        public List<Categoria> Categorias()
        {
            _db = new ContextoBd();
            return _db.Categorias.ToList();
        }

        public string ObtenerNombreCategoriaDesdeBD(int idCategoria)
        {
            string nombreCategoria = string.Empty;
            _db = new ContextoBd();
            Categoria categoria = _db.Categorias.FirstOrDefault(m => m.idCategoria == idCategoria);
            if (categoria != null)
            {
                nombreCategoria = categoria.Nombre;
            }
            return nombreCategoria;
        }
    }
}

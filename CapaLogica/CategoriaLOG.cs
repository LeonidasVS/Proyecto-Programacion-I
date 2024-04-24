using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class CategoriaLOG
    {
        CategoriaDAL _categoriaDAL;
        public int GuardarCategoria(Categoria categoria, int id = 0, bool Actualizacion = false)
        {
            _categoriaDAL = new CategoriaDAL();
            return _categoriaDAL.AgregarCategoria(categoria, id, Actualizacion);
        }
        public List<Categoria> ObtenerCategorias()
        {
            _categoriaDAL = new CategoriaDAL();
            return _categoriaDAL.Categorias();
        }

        public string ObtenerCategoriaPorId(int idCategoria)
        {
            _categoriaDAL = new CategoriaDAL();
            return _categoriaDAL.ObtenerNombreCategoriaDesdeBD(idCategoria);
        }
    }
}
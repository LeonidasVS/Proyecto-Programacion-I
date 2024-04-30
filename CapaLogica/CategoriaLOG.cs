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
        public List<Categoria> ObtenerCategorias(bool inactivo = false)
        {
            _categoriaDAL = new CategoriaDAL();
            return _categoriaDAL.Categorias(inactivo);
        }

        public string ObtenerCategoriaPorId(int idCategoria)
        {
            _categoriaDAL = new CategoriaDAL();
            return _categoriaDAL.ObtenerNombreCategoriaDesdeBD(idCategoria);
        }

        public int EditarCategoria(Categoria categoria, int id, bool esActualizacion)
        {
            _categoriaDAL = new CategoriaDAL();
            return _categoriaDAL.AgregarCategoria(categoria, id, esActualizacion);
        }

        public int EliminarCategoria(int id)
        {
            _categoriaDAL = new CategoriaDAL();
            return _categoriaDAL.Eliminarcategoria(id);
        }

        public Categoria LeerPorID(int id)
        {
            _categoriaDAL = new CategoriaDAL();
            return _categoriaDAL.LeerPorId(id);
        }
    }
}
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

        public int ActualizarCategoria(Categoria categorya, int id)
        {
            categoriaDAL = new CategoriaDAL();

            return categoriaDAL.SaveCategoria(categorya, id, true);
        }

        public int EliminarCategoria(int id)
        {
            categoriaDAL = new CategoriaDAL();
            return categoriaDAL.Eliminar(id);
        }
        public int GuardarCategoria(Categoria categoria,int id=0,bool Actualizacion=false)
        {
            categoriaDAL = new CategoriaDAL();
            return categoriaDAL.SaveCategoria(categoria,id,Actualizacion);
        }
        public List<Categoria> ObtenerCategorias(bool inactivos = false)
        {
            categoriaDAL = new CategoriaDAL();
            return categoriaDAL.LeerCategoria(inactivos);
        }

        public List<Categoria> LeerCategoriaPornombre(string nombre, bool inactivos = false)
        {
            categoriaDAL = new CategoriaDAL();
            return categoriaDAL.LeerPorNombre(nombre, inactivos);
        }
        public object ObtenerCategoriaPorId(int id)
        {
            categoriaDAL = new CategoriaDAL();
            return categoriaDAL.BuscarCategoria(id);
        }

        public string mostrarNombreCategorya(int idcategoria)
        {
            categoriaDAL = new CategoriaDAL();
            return categoriaDAL.ObtenerNombreCategoriaDesdeBD(idcategoria);
        }
    }
}

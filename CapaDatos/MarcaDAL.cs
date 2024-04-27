using Capa_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class MarcaDAL
    {
        ContextoBD contexto;

        public int GuardarMarca(Marca marca, int id, bool esActualizacion = false)
        {
            contexto = new ContextoBD();

            int resultado;

            if (esActualizacion)
            {

                marca.idMarca = id;

                contexto.Entry(marca).State = System.Data.Entity.EntityState.Modified;
                contexto.SaveChanges();

                resultado = marca.idMarca;

            }else
            {
                contexto.Marca.Add(marca);
                contexto.SaveChanges();

                resultado = marca.idMarca;

            }
            return resultado;
        }
        public List<Marca> LeerMarcas()
        {
            contexto = new ContextoBD();
            return contexto.Marca.Where(m=> m.Estado==true).ToList();
        }
        public Marca BuscarMarca(int id)
        {
            contexto = new ContextoBD();
            return contexto.Marca.Find(id);
        }

        public int Eliminar(int id)
        {
            contexto = new ContextoBD();
            int resultado = 0;

            var marca = contexto.Marca.Find(id);

            if (marca != null)
            {
                marca.Estado = false;
                contexto.SaveChanges();

                resultado = marca.idMarca;
            }

            return resultado;
        }
    }
}

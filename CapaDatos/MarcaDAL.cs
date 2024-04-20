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
        public List<Marca> LeerMarcas()
        {
            contexto = new ContextoBD();
            return contexto.Marca.Where(m=> m.idMarca>0).ToList();
        }
        public Marca BuscarMarca(int id)
        {
            contexto = new ContextoBD();
            return contexto.Marca.Find(id);
        }
    }
}

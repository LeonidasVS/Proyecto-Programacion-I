using Capa_Entidades;
using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class MarcaLOG
    {
        MarcaDAL _marDal;
        public List<Marca> ObtenerMarcas()
        {

            _marDal = new MarcaDAL();
            return _marDal.LeerMarcas();
        }
    }
}

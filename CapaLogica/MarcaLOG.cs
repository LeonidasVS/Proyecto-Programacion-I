using Capa_Entidades;
using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class MarcaLog
    {
        MarcaDAL _marDal;

        public int SaveMarcas(Marca marca, int id=0,bool esActualizacion=false)
        {
            _marDal = new MarcaDAL();
            return _marDal.GuardarMarca(marca, id, esActualizacion);
        }
        public List<Marca> ObtenerMarcas()
        {
            _marDal = new MarcaDAL();
            return _marDal.LeerMarcas();
        }
        //public Marca ObtenerMarcaPorId(int codigo)
        //{
        //    _marDal = new MarcaDAL();

        //    return _marDal.BuscarMarca(codigo);
        //}

    }
}

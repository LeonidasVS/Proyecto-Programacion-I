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
        public List<Marca> ObtenerMarcas(bool inactivos = false)
        {
            _marDal = new MarcaDAL();
            return _marDal.LeerMarcas(inactivos);
        }

        public Marca ObtenerMarcaPorId(int id)
        {
            _marDal = new MarcaDAL();

            return _marDal.BuscarMarca(id);
        }
        public int ActualizarMarca(Marca marca, int id)
        {
            _marDal = new MarcaDAL();

            return _marDal.GuardarMarca(marca, id, true);
        }

        public int EliminarMarca(int id)
        {
            _marDal = new MarcaDAL();
            return _marDal.Eliminar(id);
        }

        public string mostrarNombreMarca(int idMarca)
        {
            _marDal = new MarcaDAL();
            return _marDal.ObtenerNombreMarcaDesdeBD(idMarca);
        }

        public List<Marca> LeerMarcaPornombre(string nombre, bool inactivos = false)
        {
            _marDal = new MarcaDAL();
            return _marDal.LeerPorNombre(nombre, inactivos);
        }
    }
}

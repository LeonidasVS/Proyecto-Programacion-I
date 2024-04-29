using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class MarcaLOG
    {
        MarcaDAL _marcaDAL;

        public List<Marca> ObtenerMarca(bool inactivo = false)
        {
            _marcaDAL = new MarcaDAL();
            return _marcaDAL.marcas(inactivo);
        }

        public Marca LeerPorId(int id)
        {
            _marcaDAL = new MarcaDAL();
            return _marcaDAL.LeerPorId(id);
        }

        public string mostrarNombreMarca(int idMarca)
        {
            _marcaDAL = new MarcaDAL();
            return _marcaDAL.ObtenerNombreMarcaDesdeBD(idMarca);
        }

        public int AgregarMarca(Marca marca, int id = 0, bool esActualizacion = false)
        {
            _marcaDAL = new MarcaDAL();
            return _marcaDAL.GuardarMarca(marca, id, esActualizacion);
        }

        public int EditarMarca(Marca marca, int id, bool esActualizacion)
        {
            _marcaDAL = new MarcaDAL();
            return _marcaDAL.GuardarMarca(marca, id, esActualizacion);
        }

        public int EliminarMarca(int id)
        {
            _marcaDAL = new MarcaDAL();
            return _marcaDAL.EliminarMarca(id);
        }
    }
}

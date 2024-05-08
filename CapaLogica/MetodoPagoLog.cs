using Capa_Entidades;
using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class MetodoPagoLog
    {
        Metodo_PagoDAL metodo;

        public int ActualizarMetodo(MetodoPago metodopago, int id)
        {
            metodo = new Metodo_PagoDAL();

            return metodo.SaveMetodoDePago(metodopago, id, true);
        }

        public int EliminarCategoria(int id)
        {
            metodo = new Metodo_PagoDAL();
            return metodo.Eliminar(id);
        }

        public int GuardarMetodo(MetodoPago metodopago2, int id=0, bool esActualizacion=false)
        {
            metodo = new Metodo_PagoDAL();
            return metodo.SaveMetodoDePago(metodopago2, id, esActualizacion);
        }

        public object LeerMetodoPornombre(string nombremetodo, bool esInactivo=false)
        {
            metodo = new Metodo_PagoDAL();
            return metodo.LeerPorNombre(nombremetodo, esInactivo);
        }

        public List<MetodoPago> ObtenerMetodoDePago(bool inactivos = false)
        {
            metodo = new Metodo_PagoDAL();
            return metodo.LeerMetodoPago(inactivos);
        }

        public string ObtenerMetodoPagoPorNombre(int idMetodo)
        {
            metodo = new Metodo_PagoDAL();
            return metodo.ObtenerNombreMetodoDesdeBD(idMetodo);
        }

        public object ObtenerMetodoPorId(int id)
        {
            metodo = new Metodo_PagoDAL();
            return metodo.BuscarMetodo(id);
        }
    }
}

using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class MetodoPagoLOG
    {
        MetodoPagoDAL _metodoPagoDAL;
        public List<MetodoPago> FormasDePago(bool inactivo = false)
        {
            _metodoPagoDAL = new MetodoPagoDAL();
            return _metodoPagoDAL.FormasDePago(inactivo);
        }

        public int AgregarMtdPago(MetodoPago metodoPago, int id = 0, bool esActualizacion = false)
        {
            _metodoPagoDAL = new MetodoPagoDAL();
            return _metodoPagoDAL.GuardarMetodoPago(metodoPago, id, esActualizacion);
        }

        public string ObtenerNombreMtdPagodesdeBD(int id)
        {
            _metodoPagoDAL = new MetodoPagoDAL();
            return _metodoPagoDAL.ObtenerNombreMetdPagoDesdeBD(id);
        }

        public int EliminarMtdPago(int id)
        {
            _metodoPagoDAL = new MetodoPagoDAL();
            return _metodoPagoDAL.EliminarMtdpago(id);
        }

        public object MetodoPagoPorId(int id)
        {
            _metodoPagoDAL = new MetodoPagoDAL();
            return _metodoPagoDAL.MetodoPagoPorId(id);
        }
    }
}

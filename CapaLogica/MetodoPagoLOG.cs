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
        public List<MetodoPago> FormasDePago()
        {
            _metodoPagoDAL = new MetodoPagoDAL();
            return _metodoPagoDAL.FormasDePago();
        }

        public int AgregarMtdPago(MetodoPago metodoPago)
        {
            _metodoPagoDAL = new MetodoPagoDAL();
            return _metodoPagoDAL.GuardarMetodoPago(metodoPago);
        }

        public string ObtenerNombreMtdPagodesdeBD(int id)
        {
            _metodoPagoDAL = new MetodoPagoDAL();
            return _metodoPagoDAL.ObtenerNombreMetdPagoDesdeBD(id);
        }
    }
}

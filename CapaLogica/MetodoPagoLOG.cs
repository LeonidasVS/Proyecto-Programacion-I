using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class MetodoPagoLOG
    {
        MetodoPagoDAL _metodoPagoDAL;
        public List<MetodoPago> metodopago()
        {
            _metodoPagoDAL = new MetodoPagoDAL();
            return _metodoPagoDAL.MetodoPagos();
        }
    }
}
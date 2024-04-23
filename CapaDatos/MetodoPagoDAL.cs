using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class MetodoPagoDAL
    {
        ContextoBD _db; 
        public List<MetodoPago> FormasDePago()
        {
            _db = new ContextoBD();
            return _db.MetodoPagos.ToList();
        }
    }
}

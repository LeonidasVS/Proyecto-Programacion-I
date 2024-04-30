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
        ContextoBd _db;
        public List<MetodoPago> MetodoPagos()
        {
            _db = new ContextoBd();
            return _db.MetodoPagos.ToList();
        }
    }
}
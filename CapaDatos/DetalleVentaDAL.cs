using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DetalleVentaDAL
    {
        ContextoBD _db;

        public List<DetalleVenta> LeerDetalleVenta()
        {
            _db = new ContextoBD();
            return _db.DetalleVenta.Where(v => v.IdDetalleVenta > 0).ToList();
        }

        public DetalleVenta ObtenerDetalleVenta(int id)
        {
            _db = new ContextoBD();
            return _db.DetalleVenta.Find(id);
        }
    }
}

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

        public List<DetalleVenta> ObtenerDetalleVentaPorIdVenta(int id)
        {
            _db = new ContextoBD();
            return _db.DetalleVenta.Where(d => d.VentaId == id).ToList();
        }

        public int IdMetodoPagoPoridVenta(int id)
        {
            _db = new ContextoBD();
            List<DetalleVenta> mtdPago = _db.DetalleVenta.Where(d => d.VentaId == id).ToList();
            int idMetodPago = 0;
            foreach (var idMtdPago in mtdPago)
            {
                idMetodPago = idMtdPago.idMetodoPago;
            }

            return idMetodPago;
        }
    }
}

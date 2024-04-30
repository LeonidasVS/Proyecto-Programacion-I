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
        ContextoBd _db;

        public List<DetalleVenta> LeerDetalleVenta()
        {
            _db = new ContextoBd();
            return _db.DetalleVentas.Where(v => v.idDetalleVenta > 0).ToList();
        }

        public DetalleVenta ObtenerDetalleVenta(int id)
        {
            _db = new ContextoBd();
            return _db.DetalleVentas.Find(id);
        }

        public List<DetalleVenta> ObtenerDetalleVentaPorIdVenta(int id)
        {
            _db = new ContextoBd();
            return _db.DetalleVentas.Where(d => d.idDetalleVenta == id).ToList();
        }

        public int IdMetodoPagoPoridVenta(int id)
        {
            _db = new ContextoBd();
            List<DetalleVenta> mtdPago = _db.DetalleVentas.Where(d => d.idDetalleVenta == id).ToList();
            int idMetodPago = 0;
            foreach (var idMtdPago in mtdPago)
            {
                idMetodPago = idMtdPago.idMetodoPago;
            }

            return idMetodPago;
        }
    }
}
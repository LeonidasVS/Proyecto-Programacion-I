using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class DetalleVentaLOG
    {
        DetalleVentaDAL _detalleVentaDAL;
        public List<DetalleVenta> LeerDetalleVenta()
        {
            _detalleVentaDAL = new DetalleVentaDAL();
            return _detalleVentaDAL.LeerDetalleVenta();
        }

        public List<DetalleVenta> ObtenerDetalleVentaPorIdVent(int id)
        {
            _detalleVentaDAL = new DetalleVentaDAL();
            return _detalleVentaDAL.ObtenerDetalleVentaPorIdVenta(id);
        }

        public int IdMetodoPagoPoridVenta(int id)
        {
            _detalleVentaDAL = new DetalleVentaDAL();
            return _detalleVentaDAL.IdMetodoPagoPoridVenta(id);
        }
    }
}

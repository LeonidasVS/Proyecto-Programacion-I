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
    }
}

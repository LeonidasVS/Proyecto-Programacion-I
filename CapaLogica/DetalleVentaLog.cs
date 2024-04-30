using Capa_Entidades;
using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class DetalleVentaLog
    {
        Detalle_VentaDAL detalleDal;
        public List<Detalle_Venta> ObtenerDetalleVenta()
        {
            detalleDal = new Detalle_VentaDAL();
            return detalleDal.LeerDetalle();
        }
    }
}

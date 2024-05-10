using Capa_Entidades;
using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class _VentaLog
    {
        VentaDAL _ventadal;

        public int GuardarVenta(Venta venta)
        {
            _ventadal = new VentaDAL();
            return _ventadal.GuardarVentaDal(venta);
        }
        public decimal ObtenerVentaPorId(int idVenta)
        {
            _ventadal = new VentaDAL();
            return _ventadal.ObtenerTotalDesdeBD(idVenta);
        }

        public List<Venta> ObtenerVentas()
        {
            _ventadal = new VentaDAL();
            return _ventadal.LeerVenta();
        }
    }
}

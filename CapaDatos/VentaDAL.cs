using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class VentaDAL
    {
        ContextoBD _db;

        public int GuardarVenta(Venta venta, int id = 0, bool esActualizacion = false)
        {
            _db = new ContextoBD();
            int resultado;

            if (esActualizacion)
            {
                venta.VentaId = id;

                _db.Entry(venta).State = System.Data.Entity.EntityState.Modified;
                _db.SaveChanges();
            }
            else
            {
                _db.Ventas.Add(venta);
                _db.SaveChanges();
            }

            resultado = venta.VentaId;

            return resultado;
        }

        public int IdDeUltimaVenta()
        {
            _db = new ContextoBD();
            var ultimoId = _db.Ventas.OrderByDescending(v => v.VentaId).Select(v => v.VentaId).FirstOrDefault();

            return ultimoId;
        }

        public string FechaVentaPorid(int id)
        {
            _db = new ContextoBD();
            var venta = _db.Ventas.Find(id);
            string fecha = string.Empty;
            if (venta != null)
            {
                fecha = venta.Fecha.ToLongDateString();
            }

            return fecha;
        }

        public decimal TotalVentaPorid(int id)
        {
            _db = new ContextoBD();
            var venta = _db.Ventas.Find(id);
            decimal total = 0;
            if (venta != null)
            {
                total = venta.Total;
            }

            return total;
        }
    }
}

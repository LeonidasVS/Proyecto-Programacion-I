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
        ContextoBd _db;

        public int GuardarVenta(Venta venta, int id = 0, bool esActualizacion = false)
        {
            _db = new ContextoBd();
            int resultado;

            if (esActualizacion)
            {
                venta.idVenta = id;

                _db.Entry(venta).State = System.Data.Entity.EntityState.Modified;
                _db.SaveChanges();
            }
            else
            {
                _db.Ventas.Add(venta);
                _db.SaveChanges();
            }

            resultado = venta.idVenta;

            return resultado;
        }
<<<<<<< HEAD

        public int IdDeUltimaVenta()
        {
            _db = new ContextoBd();
            var ultimoId = _db.Ventas.OrderByDescending(v => v.idVenta).Select(v => v.idVenta).FirstOrDefault();

            return ultimoId;
        }

        public string FechaVentaPorid(int id)
        {
            _db = new ContextoBd();
            var venta = _db.Ventas.Find(id);
            string fecha = string.Empty;
            if (venta != null)
            {
                fecha = venta.Fecha.ToLongDateString();
            }

            return fecha;
        }

        public string HoraVentaPorid(int id)
        {
            _db = new ContextoBd();
            var venta = _db.Ventas.Find(id);
            string fecha = string.Empty;
            if (venta != null)
            {
                fecha = venta.Fecha.ToLongTimeString();
            }

            return fecha;
        }

        public decimal TotalVentaPorid(int id)
        {
            _db = new ContextoBd();
            var venta = _db.Ventas.Find(id);
            decimal total = 0;
            if (venta != null)
            {
                total = venta.Total;
            }

            return total;
        }

        public List<Venta> Ventas()
        {
            _db = new ContextoBd();
            return _db.Ventas.ToList();
        }
=======
>>>>>>> dbddcde63f085e1eacc57d2914303b1a816ccc31
    }
}


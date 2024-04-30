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
    }
}


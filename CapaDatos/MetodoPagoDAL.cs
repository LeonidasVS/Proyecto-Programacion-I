using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class MetodoPagoDAL
    {
        ContextoBD _db; 
        public List<MetodoPago> FormasDePago()
        {
            _db = new ContextoBD();
            return _db.MetodoPagos.ToList();
        }

        public int GuardarMetodoPago(MetodoPago metodoPago, int id = 0, bool actualizacion = false)
        {
            _db = new ContextoBD();

            int retornar;

            if (actualizacion)
            {
                metodoPago.idMetodoPago = id;
                _db.Entry(metodoPago).State = System.Data.Entity.EntityState.Modified;
                _db.SaveChanges();
                retornar = metodoPago.idMetodoPago;
            }

            else
            {
                _db.MetodoPagos.Add(metodoPago);
                _db.SaveChanges();
                retornar = metodoPago.idMetodoPago;
            }

            return retornar;
        }

        public MetodoPago ObtenerMetodoPago(int id)
        {
            _db = new ContextoBD();
            return _db.MetodoPagos.Find(id);
        }
    } 
}

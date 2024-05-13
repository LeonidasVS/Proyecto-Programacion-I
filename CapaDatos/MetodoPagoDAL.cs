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

        public int EliminarMtdpago(int id)
        {
            _db = new ContextoBD();
            var metodoPago = _db.MetodoPagos.Find(id);

            if (metodoPago != null)
            {
                metodoPago.Estado = false;
                _db.SaveChanges();
            }

            return metodoPago.idMetodoPago;
        }

        public List<MetodoPago> FormasDePago(bool inactivo = false)
        {
            _db = new ContextoBD();
            if (inactivo)
            {
                return _db.MetodoPagos.Where(m => m.Estado == false).ToList();
            }
            else
            {
                return _db.MetodoPagos.Where(m => m.Estado == true).ToList();
            }
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

        public List<MetodoPago> MetodoPagoPorId(int id)
        {
            _db = new ContextoBD();
            return _db.MetodoPagos.Where(m => m.idMetodoPago == id).ToList();
        }

        public MetodoPago ObtenerMetodoPago(int id)
        {
            _db = new ContextoBD();
            return _db.MetodoPagos.Find(id);
        }

        public string ObtenerNombreMetdPagoDesdeBD(int id)
        {
            _db = new ContextoBD();
            string NombreMtdPago = string.Empty;
            MetodoPago metodoPago = _db.MetodoPagos.FirstOrDefault(m => m.idMetodoPago == id);
            if (metodoPago != null)
            {
                NombreMtdPago = metodoPago.FormaDePago;
            }

            return NombreMtdPago;
        }
    } 
}

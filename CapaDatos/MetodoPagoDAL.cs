using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class MetodoPagoDAL
    {
        ContextoBd _db;
<<<<<<< HEAD
        public List<MetodoPago> FormasDePago()
=======
        public List<MetodoPago> MetodoPagos()
>>>>>>> dbddcde63f085e1eacc57d2914303b1a816ccc31
        {
            _db = new ContextoBd();
            return _db.MetodoPagos.ToList();
        }
<<<<<<< HEAD

        public int GuardarMetodoPago(MetodoPago metodoPago, int id = 0, bool actualizacion = false)
        {
            _db = new ContextoBd();

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
            _db = new ContextoBd();
            return _db.MetodoPagos.Find(id);
        }

        public string ObtenerNombreMetdPagoDesdeBD(int id)
        {
            _db = new ContextoBd();
            string NombreMtdPago = string.Empty;
            MetodoPago metodoPago = _db.MetodoPagos.FirstOrDefault(m => m.idMetodoPago == id);
            if (metodoPago != null)
            {
                NombreMtdPago = metodoPago.FormaPago;
            }

            return NombreMtdPago;
        }
=======
>>>>>>> dbddcde63f085e1eacc57d2914303b1a816ccc31
    }
}
using Capa_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class VentaDAL
    {
        ContextoBD contexto;

        public int GuardarVentaDal(Venta venta, int id = 0, bool actualizacion = false)
        {
            contexto = new ContextoBD();
            int resultado;

            if (actualizacion)
            {
                venta.idVenta = id;

                contexto.Entry(venta).State = System.Data.Entity.EntityState.Modified;
                contexto.SaveChanges();

                resultado = venta.idVenta;
            }
            else
            {
                contexto.Venta.Add(venta);
                contexto.SaveChanges();

                resultado = venta.idVenta;
            }

            return resultado;
        }

        //public List<Venta> LeerVenta()
        //{
        //    contexto = new ContextoBD();
        //    return contexto.Venta.Where(p => p.idVenta>0 == true).ToList();
        //}
        //public Venta ObtenerVenta(int id)
        //{
        //    contexto = new ContextoBD();
        //    return contexto.Venta.Find(id);
        //}
    }
}

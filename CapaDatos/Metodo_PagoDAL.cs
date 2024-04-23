using Capa_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Metodo_PagoDAL
    {
        ContextoBD contexto;

        public int GuardarMetodo_de_Pago(MetodoPago metodo, int id, bool esActualizacion=false, bool esEliminacion=false)
        {
            contexto = new ContextoBD();

            int resultado;

            if (esActualizacion)
            {
                metodo.idMetodoPago = id;
                contexto.Entry(metodo).State = System.Data.Entity.EntityState.Modified;
                contexto.SaveChanges();

                resultado = metodo.idMetodoPago;
            }else
            {
                contexto.Metodo.Add(metodo);
                contexto.SaveChanges();

                resultado = metodo.idMetodoPago;

            }
            return resultado;
        }
        
        public MetodoPago BuscarMetodoPago(int id)
        {
            contexto = new ContextoBD();
            return contexto.Metodo.Find(id);

        }
        public List<MetodoPago> LeerMetodoPago()
        {
            contexto = new ContextoBD();
            return contexto.Metodo.Where(m => m.idMetodoPago > 0).ToList();
        }
    }
}

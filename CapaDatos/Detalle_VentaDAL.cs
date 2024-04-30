using Capa_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Detalle_VentaDAL
    {
        ContextoBD contexto;
        public List<Detalle_Venta> LeerDetalle()
        {
            contexto = new ContextoBD();
            return contexto.Detalle.Where(d => d.idDetalleVenta > 0).ToList();
        }

        //public Detalle_Venta LeerDetalle2(int id)
        //{
        //    contexto = new ContextoBD();
        //    return contexto.Detalle.Find(id);
        //}
      
    }
}

using Capa_Entidades;
using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class MetodoPagoLog
    {
        Metodo_PagoDAL metodo;
        public List<MetodoPago> ObtenerMetodoDePago()
        {
            metodo = new Metodo_PagoDAL();
            return metodo.LeerMetodoPago();
        }
     
    }
}

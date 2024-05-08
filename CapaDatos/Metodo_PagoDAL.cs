using Capa_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
        public List<MetodoPago> LeerMetodoPago(bool inactivos)
        {
            contexto = new ContextoBD();

            if (inactivos)
            {
                return contexto.Metodo.Where(p => p.Estado == false).ToList();
            }
            else
            {
                return contexto.Metodo.Where(p => p.Estado == true).ToList();
            }

        }

        public string ObtenerNombreMetodoDesdeBD(int idMetodo)
        {
            string nombreMetodo = string.Empty;
            contexto = new ContextoBD();
            MetodoPago metodo = contexto.Metodo.FirstOrDefault(m => m.idMetodoPago == idMetodo);
            if (metodo != null)
            {
                nombreMetodo = metodo.FormaDePago;
            }
            return nombreMetodo;
        }

        public MetodoPago BuscarMetodo(int id)
        {
            contexto = new ContextoBD();
            return contexto.Metodo.Find(id);
        }

        public int SaveMetodoDePago(MetodoPago metodopago, int id, bool esActualizacion)
        {
            contexto = new ContextoBD();
            int resultado;

            if (esActualizacion)
            {
                metodopago.idMetodoPago = id;
                contexto.Entry(metodopago).State = System.Data.Entity.EntityState.Modified;
                contexto.SaveChanges();

                resultado = metodopago.idMetodoPago;
            }
            else
            {

                contexto.Metodo.Add(metodopago);
                contexto.SaveChanges();

                resultado = metodopago.idMetodoPago;
            }

            return resultado;
        }

        public int Eliminar(int id)
        {
            contexto = new ContextoBD();
            int resultado = 0;

            var metodo = contexto.Metodo.Find(id);

            if (metodo != null)
            {
                metodo.Estado = false;
                contexto.SaveChanges();

                resultado = metodo.idMetodoPago;
            }

            return resultado;
        }

        public List<MetodoPago> LeerPorNombre(string nombremetodo, bool esInactivo)
        {
             contexto = new ContextoBD();

                if (esInactivo)
                {
                    return contexto.Metodo.Where(p => p.Estado == false && p.FormaDePago.Contains(nombremetodo)).ToList();
                }
                else
                {
                return contexto.Metodo.Where(p => p.Estado == true && p.FormaDePago.Contains(nombremetodo)).ToList();
                }
        }
    }
}

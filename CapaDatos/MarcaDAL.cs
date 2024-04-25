using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class MarcaDAL
    {
        ContextoBD _db;

        public List<Marca> marcas()
        {
            _db = new ContextoBD();
            return _db.Marcas.Where(p => p.Estado == true).ToList();
        }

        public string ObtenerNombreMarcaDesdeBD(int idMarca)
        {
            string nombreMarca = string.Empty;
            _db = new ContextoBD();           
            Marca marca = _db.Marcas.FirstOrDefault(m => m.idMarca == idMarca);     
            if (marca != null)               
            {                   
                nombreMarca = marca.Nombre;               
            }           
            return nombreMarca;
        }

        public int GuardarMarca(Marca marca, int id = 0, bool esActualizacion = false)
        {
            _db = new ContextoBD();

            int resultado;

            if (esActualizacion)
            {
                marca.idMarca = id;

                _db.Entry(marca).State = System.Data.Entity.EntityState.Modified;
                _db.SaveChanges();

                resultado = marca.idMarca;

            }
            else
            {
                _db.Marcas.Add(marca);
                _db.SaveChanges();

                resultado = marca.idMarca;

            }
            return resultado;
        }
    }
}

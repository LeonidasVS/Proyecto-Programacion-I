using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
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
            return _db.Marcas.ToList();
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
    }
}

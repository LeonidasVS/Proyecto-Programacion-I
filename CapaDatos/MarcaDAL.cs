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
        ContextoBd _db;

        public List<Marca> marcas()
        {
            _db = new ContextoBd();
            return _db.Marcas.ToList();
        }

        public string ObtenerNombreMarcaDesdeBd(int idMarca)
        {
            string nombreMarca = string.Empty;
            _db = new ContextoBd();
            Marca marca = _db.Marcas.FirstOrDefault(m => m.idMarca == idMarca);
            if (marca != null)
            {
                nombreMarca = marca.Nombre;
            }
            return nombreMarca;
        }
    }
}

﻿using CapaEntidades;
using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class MarcaLOG
    {
        MarcaDAL _marcaDAL;

        public List<Marca> ObtenerMarca()
        {
            _marcaDAL = new MarcaDAL();
            return _marcaDAL.marcas();
        }

        public string mostrarNombreMarca(int idMarca)
        {
            _marcaDAL = new MarcaDAL();
            return _marcaDAL.ObtenerNombreMarcaDesdeBd(idMarca);
        }
    }
}
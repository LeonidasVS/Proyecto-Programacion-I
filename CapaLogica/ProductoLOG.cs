﻿using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class ProductoLOG
    {
        Producto _producto;
        ProductoDAL _productoDal;

        public int GuardarProducto(Producto producto, int id = 0, bool esActualizacion = false)
        {
            _productoDal = new ProductoDAL();

            return _productoDal.Guardar(producto, id, esActualizacion);
        }

        public List<Producto> ObtenerProductos()
        {  
            _productoDal = new ProductoDAL();
            return _productoDal.Leer();
        }
    }
}

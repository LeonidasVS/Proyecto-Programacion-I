﻿using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class VentaLOG
    {
        VentaDAL _ventaDAL;
        public int guardarVenta(Venta venta)
        {
            _ventaDAL = new VentaDAL();
            return _ventaDAL.GuardarVenta(venta);
        }
    }
}

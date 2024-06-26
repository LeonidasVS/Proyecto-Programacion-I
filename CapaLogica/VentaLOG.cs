﻿using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
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

        public int UltimoIdVenta()
        {
            _ventaDAL = new VentaDAL();
            return _ventaDAL.IdDeUltimaVenta();
        }

        public string FechaVentaPorId(int id)
        {
            _ventaDAL = new VentaDAL();
            return _ventaDAL.FechaVentaPorid(id);
        }

        public string HoraVentaPorId(int id)
        {
            _ventaDAL = new VentaDAL();
            return _ventaDAL.HoraVentaPorid(id);
        }
        public decimal TotalVentaPorId(int id)
        {
            _ventaDAL = new VentaDAL();
            return _ventaDAL.TotalVentaPorid(id);
        }

        public List<Venta> VentasRealizadas()
        {
            _ventaDAL = new VentaDAL();
            return _ventaDAL.Ventas();
        }
    }
}

﻿using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class ProductoDAL
    {
        ContextoBD _db;

        public int Guardar(Producto producto, int id = 0, bool esActualizacion = false)
        {
            _db = new ContextoBD();
            int resultado;

            if (esActualizacion)
            {
                producto.IdProducto = id;

                _db.Entry(producto).State = System.Data.Entity.EntityState.Modified;
                _db.SaveChanges();

                resultado = producto.IdProducto;
            }
            else
            {
                _db.Productos.Add(producto);
                _db.SaveChanges();

                resultado = producto.IdProducto;
            }
            return resultado;
        }

        public List<Producto> Leer()
        {
            _db = new ContextoBD();
            return _db.Productos.Where(p => p.Activo == true).ToList();
        }
        public Producto LeerPorId(int id)
        {
            _db = new ContextoBD();
            return _db.Productos.Find(id);
        }
    }
}

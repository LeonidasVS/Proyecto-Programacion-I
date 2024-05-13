using CapaEntidades;
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

        public int EliminarProducto(int id)
        {
            _db = new ContextoBD();
            int resultado = 0;

            var producto = _db.Productos.Find(id);

            if (producto != null)
            {
                producto.Activo = false;
                _db.SaveChanges();

                resultado = producto.IdProducto;
            }

            return resultado;
        }

        public List<Producto> FiltrarPorCategoria(int idCategoria, bool inactivo = false)
        {
            _db = new ContextoBD();
            if (inactivo)
            {
                return _db.Productos.Where(p => p.idCategoria == idCategoria && p.Activo == false).ToList();
            }
            else 
            {
                return _db.Productos.Where(p => p.idCategoria == idCategoria && p.Activo == true).ToList();
            }
        }

        public List<Producto> Filtrar(int idCategoria = 0, bool inactivo = false, int idMarca = 0, string nombre = null)
        {
            _db = new ContextoBD();
            if (idMarca != 0)
            {
                if (inactivo)
                {
                    if (idCategoria != 0)
                    {
                        if (nombre != null)
                        {
                            return _db.Productos.Where(p => p.idMarca == idMarca && p.Activo == false && p.Nombre.Contains(nombre) && p.idCategoria == idCategoria).ToList();
                        }
                        // En caso de que el nombre sea nulo
                        else
                        {
                            return _db.Productos.Where(p => p.idMarca == idMarca && p.Activo == false && p.idCategoria == idCategoria).ToList();
                        }
                    }
                    // En caso que el id categoria sea 0
                    else
                    {
                        if (nombre != null)
                        {
                            return _db.Productos.Where(p => p.idMarca == idMarca && p.Activo == false && p.Nombre.Contains(nombre)).ToList();
                        }
                        // En caso de que el nombre sea nulo
                        else
                        {
                            return _db.Productos.Where(p => p.idMarca == idMarca && p.Activo == false).ToList();
                        }                       
                    }                    
                }
                // En caso de que sean los inactivos
                else
                {
                    if (idCategoria != 0)
                    {
                        if (nombre != null)
                        {
                            return _db.Productos.Where(p => p.idMarca == idMarca && p.Activo == true && p.Nombre.Contains(nombre) && p.idCategoria == idCategoria).ToList();
                        }
                        // En caso de que el nombre sea nulo
                        else
                        {
                            return _db.Productos.Where(p => p.idMarca == idMarca && p.Activo == true && p.idCategoria == idCategoria).ToList();
                        }
                    }
                    // En caso que el id categoria sea 0
                    else
                    {
                        if (nombre != null)
                        {
                            return _db.Productos.Where(p => p.idMarca == idMarca && p.Activo == true && p.Nombre.Contains(nombre)).ToList();
                        }
                        // En caso de que el nombre sea 0
                        else
                        {
                            return _db.Productos.Where(p => p.idMarca == idMarca && p.Activo == true).ToList();
                        }
                    }
                }
            }
            else if (idCategoria != 0)
            {
                if (inactivo)
                {
                    if (idMarca != 0)
                    {
                        if (nombre != null)
                        {
                            return _db.Productos.Where(p => p.idMarca == idMarca && p.Activo == false && p.Nombre.Contains(nombre) && p.idCategoria == idCategoria).ToList();
                        }
                        // En caso de que el nombre sea nulo
                        else
                        {
                            return _db.Productos.Where(p => p.idMarca == idMarca && p.Activo == false && p.idCategoria == idCategoria).ToList();
                        }
                    }
                    // en caso de que el id marca sea 0
                    else 
                    {
                        if (nombre != null)
                        {
                            return _db.Productos.Where(p => p.idCategoria== idCategoria && p.Activo == false && p.Nombre.Contains(nombre)).ToList();
                        }
                        // en caso de que el nombre sea nulo
                        else
                        {
                            return _db.Productos.Where(p => p.idCategoria == idCategoria && p.Activo == false).ToList();
                        }
                    }
                }
                else
                {
                    if (idMarca != 0)
                    {
                        if (nombre != null)
                        {
                            return _db.Productos.Where(p => p.idMarca == idMarca && p.Activo == true && p.Nombre.Contains(nombre) && p.idCategoria == idCategoria).ToList();
                        }
                        // En caso de que el nombre sea nulo
                        else
                        {
                            return _db.Productos.Where(p => p.idMarca == idMarca && p.Activo == true && p.idCategoria == idCategoria).ToList();
                        }
                    }
                    // en caso de que el id marca sea 0
                    else
                    {
                        if (nombre != null)
                        {
                            return _db.Productos.Where(p => p.idCategoria == idCategoria && p.Activo == true && p.Nombre.Contains(nombre)).ToList();
                        }
                        // en caso de que el nombre sea nulo
                        else
                        {
                            return _db.Productos.Where(p => p.idCategoria == idCategoria && p.Activo == true).ToList();
                        }
                    }
                }
            }
            else if (nombre != null)
            {
                if (inactivo)
                {
                    if (idMarca != 0)
                    {
                        if (idCategoria != 0)
                        {
                            return _db.Productos.Where(p => p.idMarca == idMarca && p.Activo == false && p.Nombre.Contains(nombre) && p.idCategoria == idCategoria).ToList();
                        }
                        // En caso de que el nombre sea nulo
                        else
                        {
                            return _db.Productos.Where(p => p.idMarca == idMarca && p.Activo == false && p.Nombre.Contains(nombre)).ToList();
                        }
                    }
                    // en caso de que el id marca sea 0
                    else
                    {
                        if (idCategoria != 0)
                        {
                            return _db.Productos.Where(p => p.idCategoria == idCategoria && p.Activo == false && p.Nombre.Contains(nombre)).ToList();
                        }
                        // en caso de que el nombre sea nulo
                        else
                        {
                            return _db.Productos.Where(p => p.Nombre.Contains(nombre) && p.Activo == false).ToList();
                        }
                    }
                }
                else
                {
                    if (idMarca != 0)
                    {
                        if (idCategoria != 0)
                        {
                            return _db.Productos.Where(p => p.idMarca == idMarca && p.Activo == true && p.Nombre.Contains(nombre) && p.idCategoria == idCategoria).ToList();
                        }
                        // En caso de que el nombre sea nulo
                        else
                        {
                            return _db.Productos.Where(p => p.idMarca == idMarca && p.Activo == true && p.Nombre.Contains(nombre)).ToList();
                        }
                    }
                    // en caso de que el id marca sea 0
                    else
                    {
                        if (idCategoria != 0)
                        {
                            return _db.Productos.Where(p => p.idCategoria == idCategoria && p.Activo == true && p.Nombre.Contains(nombre)).ToList();
                        }
                        // en caso de que el id categoria sea 0
                        else
                        {
                            return _db.Productos.Where(p => p.Nombre.Contains(nombre) && p.Activo == true).ToList();
                        }
                    }
                }
            }
            else
            {
                if (inactivo)
                {
                    return _db.Productos.Where(p => p.Activo == false).ToList();
                }
                else
                {
                    return _db.Productos.Where(p => p.Activo == true).ToList();
                }
            }
        }

        public List<Producto> FiltrarPorMarca(int idMarca, bool inactivo = false)
        {
            _db = new ContextoBD();
            if (inactivo)
            {
                return _db.Productos.Where(p => p.idMarca == idMarca && p.Activo == false).ToList();
            }
            else
            {
                return _db.Productos.Where(p => p.idMarca == idMarca && p.Activo == true).ToList();
            }
        }

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

        public List<Producto> Leer(bool inactivos = false)
        {
            _db = new ContextoBD();
            if (inactivos)
            {
                return _db.Productos.Where(p => p.Activo == false).ToList();
            }
            else
            {
                return _db.Productos.Where(p => p.Activo == true).ToList();
            }

        }
        public Producto LeerPorId(int id)
        {
            _db = new ContextoBD();
            return _db.Productos.Find(id);
        }

        public void EliminarAgotado()
        {
            _db = new ContextoBD();
            var productoAgotado = _db.Productos.Where(p => p.Existencias == 0);

            foreach ( var producto in productoAgotado)
            {
                producto.Activo = false;
            }
            _db.SaveChanges();
        }

        public List<Producto> FiltrarPorNombre(string nombre, bool inactivo = false)
        {
            _db = new ContextoBD();
            if (inactivo)
            {
                return _db.Productos.Where(p => p.Activo == false && p.Nombre.Contains(nombre)).ToList();
            }
            else
            {
                return _db.Productos.Where(p => p.Activo == true && p.Nombre.Contains(nombre)).ToList();
            }
        }

        public string ObtenerNombreProductoDesdeBD(int id)
        {
            string nombreProducto = string.Empty;
            _db = new ContextoBD();
            Producto producto = _db.Productos.FirstOrDefault(p => p.IdProducto == id);
            if (producto != null)
            {
                nombreProducto = producto.Nombre;
            }

            return nombreProducto;
        }
    }
}

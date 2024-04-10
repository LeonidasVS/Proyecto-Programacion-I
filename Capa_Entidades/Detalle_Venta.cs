using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidades
{
    public class Detalle_Venta
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idDetalleVenta { get; set; }

        [Required]
        public int Cantidad { get; set; }

        [Required]
        public decimal Precio { get; set; }

        public int idProducto { get; set; }
        [ForeignKey("idProducto")]
        public Producto Producto { get; set; }


        [Required]
        public int idVenta { get; set; }
        [ForeignKey("idVenta")]
        public Venta Venta { get; set; }
    }
}

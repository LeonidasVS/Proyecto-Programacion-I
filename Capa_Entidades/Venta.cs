using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidades
{
    public class Venta
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idVenta { get; set; }
        [Required]
        public int Cantidad { get; set; }
        [Required]
        public decimal Precio_Total { get; set; }
        [Required]
        public DateTime Fecha { get; set; }
    }
}

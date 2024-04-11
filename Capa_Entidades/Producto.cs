using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidades
{
    public class Producto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idProducto { get; set; }

        [Required]
        [MaxLength(100)]
        public string Nombre { get; set; }
        [Required]
        public int Cantidad { get; set; }
        [Required]
        public int Stock { get; set; }
        [Required]
        public decimal Precio { get; set; }
        [Required]
        public bool Estado { get; set; }

        [Required]
        public int idVenta { get; set; }
        [ForeignKey("idVenta")]
        public Marca Marca { get; set; }

        [Required]
        public int idCategoria { get; set; }
        [ForeignKey("idVenta")]
        public Categoria Categoria { get; set; }
    }
}

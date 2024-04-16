using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Producto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdProducto { get; set; }
        [Required]
        [MaxLength(100)]
        public string Nombre { get; set; }
        [Required]
        [MaxLength(250)]
        public string Descripcion { get; set;}
        [Required]
        public int Existencias { get; set;}
        [Required]
        public decimal PrecioUnitario { get; set; }
        [Required]
        public bool Activo { get; set; }
        [Required]
        public int idMarca { get; set; }
        [ForeignKey("idMarca")]
        public Marca Marca { get; set; }
        [Required]
        public int idCategoria { get; set; }
        [ForeignKey("idCategoria")]
        public Categoria Categoria { get;set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Marca
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idMarca { get; set; }

        [Required]
        [MaxLength(60)]
        public string Nombre { get; set; }

        [Required]
        [MaxLength(200)]
        public string Descripcion { get; set; }
    }
}

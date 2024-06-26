﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class MetodoPago
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idMetodoPago { get; set; }
        [Required]
        [MaxLength(60)]
        public string FormaDePago { get; set;}
        [Required]
        public bool Estado {  get; set;}
    }
}

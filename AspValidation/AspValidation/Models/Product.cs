using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspValidation.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        [NameRestriction]
        public string Name { get; set; }

        [Required]
        [Range(0, 10000)]
        public int Price { get; set; }
    }
}

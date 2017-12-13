using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ICT13580024B3.Api.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(200)]
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal UnitPrice { get; set; }
        public string ImagePath { get; set; }
    }
}

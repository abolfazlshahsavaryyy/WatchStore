using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WatchStor.Models.Enum;


namespace WatchStor.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Brand { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public Gender Gender { get; set; } // E.g., "Male", "Female", "Unisex"
        [Required]
        public TypeWatch WatchType { get; set; } // E.g., "Watch", "Accessories", etc.
        public string? ImageURL {  get; set; }
    }

}

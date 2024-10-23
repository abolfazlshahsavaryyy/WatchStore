using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WatchStor.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        
        public int? WatchId { get; set; } // Assuming this is linked to a product (watch)
        [Required]
        public int Number { get; set; } // Quantity of items ordered
        [Required]
        public DateTime TimeOfPurchase { get; set; }
        [Required]
        public DateTime? TimeOfSend { get; set; } // Nullable in case it hasn't been sent yet

        // Navigation property to link to the Product (Watch)
        [ForeignKey("WatchId")]
        public Product? Watch { get; set; }
    }

}

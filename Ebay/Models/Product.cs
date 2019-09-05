using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ebay.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Product Name is required")]
        [MinLength(2, ErrorMessage ="2 character minimum")]
        [MaxLength(25, ErrorMessage ="25 characters maximum")]
        public string ProductName { get; set; }
        [Required(ErrorMessage = "Product Discription is required")]
        [MinLength(2, ErrorMessage = "2 character minimum")]
        [MaxLength(200, ErrorMessage = "200 characters maximum")]
        public string ProductDscription { get; set; }
        [Required]
        public int Qty { get; set; }
        [Required]
        public decimal price { get; set; }
        public decimal? Discount { get; set; }
        public byte[] Image { get; set; }
        public virtual List<Order> Orders { get; set; }
    }
}

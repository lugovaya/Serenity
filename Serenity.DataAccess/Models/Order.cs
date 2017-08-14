using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Serenity.DataAccess.Models
{
    public class Order : BaseEntity
    {
        public Order()
        {
            Products = new List<ProductOrder>();
        }
        
        [Required]
        public DateTime OrderTime { get; set; } = DateTime.Now;
        
        [Required]
        public string DeliveryAdress { get; set; }
        
        public string Comment { get; set; }

        public decimal Discount { get; set; }
        
        [Required]
        public decimal Bill { get; set; }
        
        [Required]
        public ICollection<ProductOrder> Products { get; set; }
    }
}
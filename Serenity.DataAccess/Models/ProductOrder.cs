using System.ComponentModel.DataAnnotations;

namespace Serenity.DataAccess.Models
{
    public class ProductOrder
    {
        public int OrderId { get; set; }
        
        public int ProductId { get; set; }
        
        [Required]
        public virtual Product Product { get; set; }
        
        [Required]
        public virtual Order Order { get; set; }
    }
}
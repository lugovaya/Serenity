using System.ComponentModel.DataAnnotations;

namespace Serenity.DataAccess.Models
{
    public class ProductImage
    {
        public int ImageId { get; set; }
        
        public int ProductId { get; set; }
        
        [Required]
        public virtual Image Image { get; set; }
        
        [Required]
        public virtual Product Product { get; set; }
    }
}
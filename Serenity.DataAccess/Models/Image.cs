using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Serenity.DataAccess.Models
{
    public class Image : BaseEntity
    {
        [Required]
        public string Reference { get; set; }
        
        public long Size { get; set; }
        
        public ICollection<ProductImage> Products { get; set; }
    }
}
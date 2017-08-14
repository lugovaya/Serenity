using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Serenity.DataAccess.Models
{
    public enum ProductType
    {
        Aquariums,
        TropicalFishes,
        ExoticAnimals,
        Plants,
        Equipment,
        Nutrition,
        Decoration
    }
    
    public class Product : BaseEntity
    { 
        public Product()
        {
            Orders = new List<ProductOrder>();
            Gallery = new List<ProductImage>();
        }
        
        [Required]
        public string Title { get; set; }
        
        [Required]
        public ProductType ProductType { get; set; }
        
        [Required]
        public string Description { get; set; }
        
        [Required]
        public decimal Price { get; set; }
        
        [Required]
        public int AvaliableCount { get; set; }
        
        [Required]
        public ICollection<ProductOrder> Orders { get; set; }
        
        [Required]
        public ICollection<ProductImage> Gallery { get; set; }
    }
}
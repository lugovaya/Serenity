using System;
using Microsoft.EntityFrameworkCore;
using Serenity.DataAccess.Models;

namespace Serenity.DataAccess
{
    public partial class ApplicationDbContext
    {
        public DbSet<Client> Clients { get; set; }
        
        public DbSet<Product> Products { get; set; }
        
        public DbSet<Order> Orders { get; set; }
        
        public DbSet<Image> ImagesStorage { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            modelBuilder.Entity<ProductOrder>().HasKey(entity => new {entity.ProductId, entity.OrderId});
            modelBuilder.Entity<ProductImage>().HasKey(entity => new {entity.ProductId, entity.ImageId});
        }

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Integrated Security=true;");
//        }
    }
}
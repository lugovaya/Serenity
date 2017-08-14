using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Serenity.DataAccess.Models
{
    public class Client : IdentityUser
    {
        public Client()
        {
            Orders = new List<Order>();
        }
        
        public string FirstName { get; set; }
        
        public string LastName { get; set; }
        
        public string Adress { get; set; }
        
        [Required]
        public ICollection<Order> Orders { get; set; }

        [NotMapped]
        public string FullName => $"{FirstName} {LastName}";
    }
}
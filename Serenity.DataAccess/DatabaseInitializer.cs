using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Serenity.DataAccess.Models;
using Serenity.Utils;
using Generator = GenFu.GenFu;

namespace Serenity.DataAccess
{
    public class DatabaseInitializer
    {
        public static void Load(ApplicationDbContext context)
        {
            if (context.Clients.Any())
                return;

            Setup(context.Clients);

            Setup(context.Orders);

            Setup(context.Products);

            Setup(context.ImagesStorage);

            context.SaveChanges();
        }

        private static void Setup<T>(DbSet<T> dbSet) where T : BaseEntity, new()
        {
            Generator.Configure<T>().Fill(x => x.Id, 0);

            var collection = Generator.ListOf<T>().DistinctBy(x => x.Id);

            foreach (var entity in collection)
            {
                dbSet.Add(entity);
            }
        }

        private static void Setup(DbSet<Client> dbSet)
        {
            var collection = new List<Client>
            {
                GetClient("first", "first@com.net"),
                GetClient("second", "2nd@hand.com")
            };

            foreach (var entity in collection)
            {
                dbSet.Add(entity);
            }
        }

        private static Client GetClient(string name, string email)
        {
            return new Client
            {
                UserName = name,
                Email = email
            };
        }
    }
}
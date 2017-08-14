using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Generator = GenFu.GenFu;

namespace Serenity.DataAccess
{
    public class DatabaseInitializer
    {
        public static void Load(ApplicationDbContext context)
        {
            Setup(context.Clients);

            Setup(context.Orders);
            
            Setup(context.Products);
            
            Setup(context.ImagesStorage);

            context.SaveChanges();
        }

        private static void Setup<T>(DbSet<T> dbSet) where T : class, new()
        {
            var collection = Generator.ListOf<T>();
            
            foreach (var entity in collection)
            {
                dbSet.Add(entity);
            }
        }
    }
}
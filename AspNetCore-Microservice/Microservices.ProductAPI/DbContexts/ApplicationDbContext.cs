using Microservices.ProductAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace Microservices.ProductAPI.DbContexts
{
    public class ApplicationDbContext:DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
    }
}

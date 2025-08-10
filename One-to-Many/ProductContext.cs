using Microsoft.EntityFrameworkCore;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CodeFirstEF.Models
{

    // Inherit from the base DbContext class
    public class ProductContext : DbContext
    {

        // List of products for Product entity referred as Dbset
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        // Constructor to pass options to the base DbContext

        public ProductContext(DbContextOptions<ProductContext> options)
            : base(options)
        {
        }

        // called during migration
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("data source = JAGADISH; database = practice; integrated security = true; trustservercertificate = true; ");
        }
    }
}

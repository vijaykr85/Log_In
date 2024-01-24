using Microsoft.EntityFrameworkCore;

namespace Log_In.Models
{
    public class ProductContext:DbContext
    {
        public ProductContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Product> productDetails { get; set; }
    }
}

using Microsoft.EntityFrameworkCore;

namespace razorpages.Data
{
    public class ProductContext : DbContext
    {
        public ProductContext (
            DbContextOptions<ProductContext> options)
            : base(options)
        {
        }

        public DbSet<razorpages.Models.Product> Product { get; set; }
    }
}
using EShoppingEntity;
using Microsoft.EntityFrameworkCore;

namespace EShoppingApi
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Product> Product { get; set; }
        public DbSet<SalesVoucher> SalesVoucher { get; set; }
    }
}

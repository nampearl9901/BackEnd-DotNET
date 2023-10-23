using Microsoft.EntityFrameworkCore;

namespace MyWebApi.Data
{
    public class MilkShopContext : DbContext
    {
        public MilkShopContext(DbContextOptions<MilkShopContext> opt) : base (opt) {
        }
        public DbSet<Products>? Products { get; set; }
        public DbSet<Categorys>? Categories { get; set; }
    }
}

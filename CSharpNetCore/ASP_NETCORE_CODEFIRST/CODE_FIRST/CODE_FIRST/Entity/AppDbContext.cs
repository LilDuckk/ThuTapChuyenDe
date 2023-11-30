using CODE_FIRST.Models;
using Microsoft.EntityFrameworkCore;

namespace CODE_FIRST.Entity
{
    public class AppDbContext :DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}

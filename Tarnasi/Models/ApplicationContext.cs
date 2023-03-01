using Microsoft.EntityFrameworkCore;

namespace Tarnasi.Models
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base (options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Category> categories { get; set; }
        public DbSet<Article> articles { get; set; }
    }
}

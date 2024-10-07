using Microsoft.EntityFrameworkCore;
using ProductsCRUD.WebUI.Models;

namespace ProductsCRUD.WebUI.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }

        public DbSet<ProductEntity> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductEntity>()
                .HasIndex(x => x.Name)
                .IsUnique();

            base.OnModelCreating(modelBuilder);
        }
    }
}

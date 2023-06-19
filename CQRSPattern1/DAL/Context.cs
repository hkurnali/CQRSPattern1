using Microsoft.EntityFrameworkCore;

namespace CQRSPattern1.DAL
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-H080ONB\\SQLEXPRESS01;initial Catalog=CQRSdb; integrated security=true");
        }

        public DbSet<Product> Products { get; set; }
    }
}

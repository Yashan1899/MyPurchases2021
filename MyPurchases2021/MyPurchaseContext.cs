using Microsoft.EntityFrameworkCore;

namespace MyPurchases2021
{
    public class MyPurcaseContext : DbContext
    {
        public DbSet<MyPurchase> MyPurchases { get; set; }

        public MyPurcaseContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=mypurchase2021appdb;Trusted_Connection=True;");
        }
    }
}


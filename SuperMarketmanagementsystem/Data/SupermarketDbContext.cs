using Microsoft.EntityFrameworkCore;
using SuperMarketmanagementsystem.Models;

namespace SuperMarketmanagementsystem.Data
{
    public class SupermarketDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Supplier> Suppliers { get; set; }

        public DbSet<Stock> Stocks { get; set; }

        public DbSet<Sale> Sales { get; set; }

        public DbSet<SaleItem> SaleItems { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=(localdb)\ProjectModels;Database=SupermarketDB;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }
}
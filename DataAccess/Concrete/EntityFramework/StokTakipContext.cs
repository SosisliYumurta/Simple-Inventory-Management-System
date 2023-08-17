using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class StokTakipContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //string dbName = "stokTakipDb.db"; // Veritabanı dosya adı
            //string dbFolderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Db"); // "Db" klasörünün yolu
            //string dbPath = Path.Combine(dbFolderPath, dbName); // "Db" klasörünün içindeki veritabanı yolu
            optionsBuilder.UseSqlite(@"Data Source=C:\Users\Casper\Desktop\StokTakip\Db\stokTakipDb.db");

            //optionsBuilder.UseSqlite("DataSource=.\\Db\\stokTakipDb.db");
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<SaleDetails> SalesDetails { get; set; }
    }
}

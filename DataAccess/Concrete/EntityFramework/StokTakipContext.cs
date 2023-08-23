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

            //optionsBuilder.UseSqlite(@"Data Source=C:\Users\Casper\Desktop\StokTakip\Db\stokTakipDb.db");
            string appFolderPath = Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);
            string dbPath = Path.Combine(appFolderPath, "DataBase/stokTakipDb.db"); // SQLite veritabanı dosyasının yolu ve adı

            optionsBuilder.UseSqlite($"Data Source={dbPath}");

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<SaleDetails> SalesDetails { get; set; }
    }
}

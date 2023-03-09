using Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class BrandContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB; database=ReaDb;Trusted_Connection=false");
        }
            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                    modelBuilder.Entity<Category>()
              .HasData(
                  new Category() { Id = 1, Name = "Elektronik" },
                  new Category() { Id = 2, Name = "İndirimliElektronik" },
                  new Category() { Id = 3, Name = "SonKalanElektronikler" }
                      );


            modelBuilder.Entity<Product>()
                .HasData(
                    new Product() { Id = 1, CategoryId = 1, ProductName = "Asus", Description = "Oyuncu Notebook", Price = 19500 },
                    new Product() { Id = 2, CategoryId = 1, ProductName = "HP", Description = "Probook Notebook", Price = 22250 },
                    new Product() { Id = 3, CategoryId = 1, ProductName = "Dell", Description = "Server Bilgisayarı", Price = 233200 },
                    new Product() { Id = 4, CategoryId = 1, ProductName = "Xaomi", Description = "Kablosuz Q klavye", Price = 150 },
                    new Product() { Id = 5, CategoryId = 2, ProductName = "Vestel", Description = "IPS Ekran Monitör", Price = 6000 },
                    new Product() { Id = 6, CategoryId = 2, ProductName = "ARÇELİK", Description = "kahve öğütücü", Price = 6000 },
                    new Product() { Id = 7, CategoryId = 2, ProductName = "ARÇELİK", Description = "tost makinesi", Price = 5000 },
                    new Product() { Id = 8, CategoryId = 2, ProductName = "Grunding", Description = "IPS Ekran Televizyon", Price = 5000 },
                    new Product() { Id = 9, CategoryId = 2, ProductName = "Grunding", Description = "Geniş Ekran Monitör", Price = 4500 }


                );
            
            
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}

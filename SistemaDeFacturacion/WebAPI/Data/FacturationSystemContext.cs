using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Reflection.Metadata;
using WebAPI.Models.Clases;

namespace WebAPI.Data
{
    public class FacturationSystemContext : DbContext
    {
        public FacturationSystemContext(DbContextOptions<FacturationSystemContext> options) : base(options) { }
        public DbSet<Invoice> Facturas { get; set; }
        public DbSet<Description> Description { get; set; }
        public DbSet<Categories> Categories { get; set; }
        public DbSet<Waiters> Waiters { get; set; }
        public DbSet<Historical> Historical { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<Tables> Tables { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Waiters>()
                .HasMany(e => e.Tables)
                .WithOne()
                .HasForeignKey(e => e.WaitersId)
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Historical>()
                .HasMany(e=> e.Invoices)
                .WithOne(e=> e.Historical)
                .HasForeignKey(e => e.HistoricalId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Categories>()
                .HasMany(e => e.Products)
                .WithOne()
                .HasForeignKey(e => e.CategoriesId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Products>()
                .HasMany(e => e.Descriptions)
                .WithOne()
                .HasForeignKey(e => e.ProductsId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Invoice>()
                .HasOne(e => e.Tables)
                .WithMany(e => e.Invoices)
                .HasForeignKey(e => e.TableId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Invoice>()
                .HasOne(e => e.Waiters)
                .WithMany(e => e.Invoices)
                .HasForeignKey(e => e.WaitersId)
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Invoice>()
                            .HasMany(e => e.Descriptions)
                            .WithMany(e => e.Invoices)
                            .UsingEntity<InvoiceDescription>(
                                l => l.HasOne<Description>(e => e.Description).WithMany(e => e.InvoicesDescription),
                                r => r.HasOne<Invoice>(e => e.Invoice).WithMany(e => e.InvoicesDescription));

            modelBuilder.Entity<Waiters>().HasData(
                new Waiters() { WaitersId = 1, WaitersFullName = "Katou Megumi", DateAdmission = DateTime.Now, Birthday = new DateTime(2003, 9, 17) },
                new Waiters() { WaitersId = 2, WaitersFullName = "Leon Scott Kennedy", DateAdmission = DateTime.Now, Birthday = new DateTime(2005, 2, 19) }
                );
            modelBuilder.Entity<Tables>().HasData(
                new Tables() { TableId = 1, WaitersId = 1 },
                new Tables() { TableId = 2, WaitersId = 2 },
                new Tables() { TableId = 3, WaitersId = 1 },
                new Tables() { TableId = 4, WaitersId = 2 },
                new Tables() { TableId = 5, WaitersId = 1 },
                new Tables() { TableId = 6, WaitersId = 2 }
                );
            modelBuilder.Entity<Categories>().HasData(
                new Categories() { CategoriesId = 1, CategoryName = "Bebida" },
                new Categories() { CategoriesId = 2, CategoryName = "Comida" }
                );
            modelBuilder.Entity<Products>().HasData(
                new Products() { ProductsId = 1, Name = "Café Caliente", CategoriesId = 1, UnitPrice = 10 },
                new Products() { ProductsId = 2, Name = "Café Helado", CategoriesId = 1, UnitPrice = 20 },
                new Products() { ProductsId = 3, Name = "Frapuccino", CategoriesId = 1, UnitPrice = 30 },
                new Products() { ProductsId = 4, Name = "Té de Limon", CategoriesId = 1, UnitPrice = 15 },
                new Products() { ProductsId = 5, Name = "Limonada", CategoriesId = 1, UnitPrice = 20 },
                new Products() { ProductsId = 6, Name = "Té Caliente", CategoriesId = 1, UnitPrice = 10 },
                new Products() { ProductsId = 7, Name = "Rosquillas y Viejitas Somoteñas", CategoriesId = 2, UnitPrice = 20 },
                new Products() { ProductsId = 8, Name = "Panini de Queso", CategoriesId = 2, UnitPrice = 25 },
                new Products() { ProductsId = 9, Name = "Panqueques", CategoriesId = 2, UnitPrice = 50 },
                new Products() { ProductsId = 10, Name = "Slice de Torta Marmoleada", CategoriesId = 2, UnitPrice = 20 },
                new Products() { ProductsId = 11, Name = "Gomitas de Café", CategoriesId = 2, UnitPrice = 15 },
                new Products() { ProductsId = 12, Name = "Papitas Fritas", CategoriesId = 2, UnitPrice = 35 }
                );
        }
    }
}

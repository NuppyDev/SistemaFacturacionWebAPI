using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;
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
                .HasForeignKey(e => e.EmployeeId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Historical>()
                .HasMany(e => e.Invoices)
                .WithOne()
                .HasForeignKey(e => e.HistoricalId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Categories>()
                .HasMany(e => e.Products)
                .WithOne()
                .HasForeignKey(e => e.CategoriesId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Description>()
                .HasOne(e => e.Products)
                .WithOne(e => e.Description)
                .HasForeignKey<Products>(e => e.DescriptionId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Invoice>()
            .HasOne(e => e.Tables)
            .WithMany(e => e.Invoices)
            .HasForeignKey(e => e.TableId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Invoice>()
            .HasOne(e => e.Employees)
            .WithMany(e => e.Invoices)
            .HasForeignKey(e => e.EmployeeId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Description>()
            .HasOne(e => e.Invoice)
            .WithMany(e => e.Descriptions)
            .HasForeignKey(e => e.InvoiceId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Waiters>().HasData(
                new Waiters() { EmployeeId = 1, EmployeeFullName = "Stephanie Tenorio", DateAdmission = DateTime.Now, Birthday = Convert.ToDateTime("19/02/2005") },
                new Waiters() { EmployeeId = 2, EmployeeFullName = "Carolina Orozco", DateAdmission = DateTime.Now, Birthday = Convert.ToDateTime("19/02/2005") }
                );
            modelBuilder.Entity<Tables>().HasData(
                new Tables() { TableId = 1, EmployeeId = 1 },
                new Tables() { TableId = 2, EmployeeId = 2 },
                new Tables() { TableId = 3, EmployeeId = 1 },
                new Tables() { TableId = 4, EmployeeId = 2 },
                new Tables() { TableId = 5, EmployeeId = 1 },
                new Tables() { TableId = 6, EmployeeId = 2 }
                );
        }
    }
}

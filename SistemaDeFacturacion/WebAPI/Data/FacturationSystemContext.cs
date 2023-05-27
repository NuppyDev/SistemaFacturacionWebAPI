using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;
using WebAPI.Models;

namespace WebAPI.Data
{
    public class FacturationSystemContext : DbContext
    {
        public DbSet<Invoice> facturas { get; set; }
        public DbSet<Description> description { get; set; }
        public DbSet<Categories> categories { get; set; }
        public DbSet<Employees> employees { get; set; }
        public DbSet<Historical> historical { get; set; }
        public DbSet<Products> products { get; set; }
        public DbSet<Tables> tables { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["constring"].ToString());
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Description>()
                .HasOne(e => e.Products)
                .WithOne(e => e.Description)
                .HasForeignKey<Products>(e => e.DescriptionId)
                .IsRequired();
        }
    }
}

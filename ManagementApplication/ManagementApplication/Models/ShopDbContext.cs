using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace ManagementApplication.Models
{
    public class ShopDbContext : DbContext
    {
        public ShopDbContext(DbContextOptions<ShopDbContext> options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Billing> Billings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure relationships between entities
            modelBuilder.Entity<Item>()
                .HasOne(i => i.Category) // Each item belongs to one category
                .WithMany(c => c.Items) // Each category can have many items
                .HasForeignKey(i => i.CatCode) // Foreign key property in the Item class
                .OnDelete(DeleteBehavior.Cascade); // Example: Item belongs to one Category

            modelBuilder.Entity<Billing>()
                .HasOne(b => b.Customer)// Each billing belongs to one customer
                .WithMany(c => c.Billings) // Each customer can have many billings
                .HasForeignKey(b => b.CustCode) // Foreign key property in the Billing class
                .OnDelete(DeleteBehavior.Cascade); // Example: Billing belongs to one Customer
        }
    }
}

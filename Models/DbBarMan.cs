using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace BarMan.Models
{
    public class InventoryContext : DbContext
    {
        // سازنده برای استفاده در زمان طراحی (Migration)
        public InventoryContext()
        {
        }

        // سازنده برای استفاده در زمان اجرا
        public InventoryContext(DbContextOptions<InventoryContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Suppliers> Suppliers { get; set; }
        public DbSet<Driver> Driver { get; set; }

        // تنظیمات مربوط به پایگاه داده
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=localhost;Database=DbBarMan;Trusted_Connection=True;");
              
            }
            
        }
    }
}

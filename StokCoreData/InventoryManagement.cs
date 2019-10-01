using Microsoft.EntityFrameworkCore;
using StokCoreModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace StokData
{
    public class InventoryManagement : DbContext
    {
        public InventoryManagement()
        {

        }
        public InventoryManagement(DbContextOptions<InventoryManagement> options)
         : base(options)
        {

        }
        override protected void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("data source =.; initial catalog = InventoryManagement; integrated security = True; MultipleActiveResultSets = True; App = EntityFramework");
        }

        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<CompanyAddress> CompanyAddresses { get; set; }
        public virtual DbSet<CompanyLogo> CompanyLogoes { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Menu> Menus { get; set; }
        public virtual DbSet<Message> Messages { get; set; }
        public virtual DbSet<ProductImage> ProductImages { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Staff> Staffs { get; set; }
        public virtual DbSet<Store> Stores { get; set; }

    }
    
}

using MGM.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore;

namespace MGM.Data
{
    public class ApplicationDbContext : DbContext //IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) //Model Relationships
        {
            base.OnModelCreating(modelBuilder);


            //Crop and CustomerOrderDetail
            modelBuilder.Entity<CustomerOrderDetail>()
                .HasOne(p => p.Crop);

            //CustomerOrderDetail and CustomerOrder
            modelBuilder.Entity<CustomerOrderDetail>()
                .HasOne(p => p.CustomerOrder);

            //Crop and Inventory
            //modelBuilder.Entity<Crop>()
            //    .HasOne(p => p.)
            //    .WithMany(p => p.Products)
            //    .HasForeignKey(p => p.CategoryId)
            //    .HasConstraintName("FK_Products_CategoryID");



        }

        public DbSet<CostQty> costQties { get; set; }
        public DbSet<Crop> Crops { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<CustomerOrder> CustomerOrders { get; set; }
        public DbSet<CustomerOrderDetail> CustomerOrderDetails { get; set; }
        public DbSet<GrowMedia> GrowMedia { get; set; }
        public DbSet<GrowPlan> GrowPlans { get; set; }
        public DbSet<Inventory> Inventories { get; set; }
        public DbSet<Lighting> Lightings { get; set; }
        public DbSet<MileStoneDate> MileStoneDates { get; set; }
        public DbSet<Shelving> Shelvings { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Tray> Trays { get; set; }
        public DbSet<Package> Packages { get; set; }

    }
}

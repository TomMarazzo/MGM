using MGM.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MGM.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<CostQty> costQties { get; set; }
        public DbSet<Crop> Crops { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<CustomerOrder> CustomerOrders { get; set; }
        public DbSet<CustomerOrderDetail> CustomerOrderDetails { get; set; }
        public DbSet<GrowMedia> GrowMedias { get; set; }
        public DbSet<GrowPlan> GrowPlans { get; set; }
        public DbSet<Inventory> Inventories { get; set; }
        public DbSet<Lighting> Lightings { get; set; }
        public DbSet<MileStoneDate> MileStoneDates { get; set; }
        public DbSet<Shelving> Shelvings { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Tray> Trays { get; set; }

    }
}

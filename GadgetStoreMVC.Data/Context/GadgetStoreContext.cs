using GadgetStoreMVC.Data.Configurations;
using GadgetStoreMVC.Models.Models;
using Microsoft.EntityFrameworkCore;

namespace GadgetStoreMVC.Data.Context
{
    public class GadgetStoreContext : DbContext
    {
        public GadgetStoreContext(DbContextOptions<GadgetStoreContext> options)
            : base(options)
        {
        }

        public virtual DbSet<GadgetModel> Gadgets { get; set; }
        public virtual DbSet<OrderModel> Orders { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new GadgetConfiguration());
            modelBuilder.ApplyConfiguration(new OrderConfiguration());
        }

    }
}

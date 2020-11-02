using GadgetStoreMVC.Data.Configurations;
using GadgetStoreMVC.Models.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GadgetStoreMVC.Data.Context
{
    public class PostgresContext : IdentityDbContext<User>
    {
        public PostgresContext()
        {
        }

        public PostgresContext(DbContextOptions<PostgresContext> options)
            : base(options)
        {
        }

        public virtual DbSet<GadgetModel> Gadgets { get; set; }
        public virtual DbSet<OrderModel> Orders { get; set; }

        // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        // {
        //     if (!optionsBuilder.IsConfigured)
        //     {
        //         optionsBuilder.UseNpgsql(
        //             //"Server=localhost;User Id=postgres;Password=postgres;Database=GadgetStoreDatabase;"
        //
        //         );
        //     }
        // }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new GadgetConfiguration());
            modelBuilder.ApplyConfiguration(new OrderConfiguration());
            modelBuilder
                .Entity<User>()
                .HasKey(e => e.Id);

            base.OnModelCreating(modelBuilder);
        }
    }
}
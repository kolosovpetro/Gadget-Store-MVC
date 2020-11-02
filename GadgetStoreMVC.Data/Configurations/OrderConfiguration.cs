using GadgetStoreMVC.Models.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GadgetStoreMVC.Data.Configurations
{
    public class OrderConfiguration : IEntityTypeConfiguration<OrderModel>
    {
        public void Configure(EntityTypeBuilder<OrderModel> entity)
        {
            entity.HasKey(e => e.OrderId)
                .HasName("order_pkey");

            entity.ToTable("Orders");

            entity.Property(e => e.GadgetId)
                .HasColumnName("GadgetId");

            entity.Property(e => e.UserId)
                .HasColumnName("UserId")
                .HasColumnType("text");

            entity.Property(e => e.Address)
                .HasColumnName("Address")
                .HasColumnType("character varying");

            entity.Property(e => e.PhoneNumber)
                .HasColumnName("PhoneNumber")
                .HasColumnType("character varying");

            entity.HasData(
                new OrderModel
                {
                    OrderId = 4,
                    GadgetId = 2,
                    UserId = "b348feb0-037d-40c9-941e-afc111648c6e",
                    Address = "ul. Polweiska 27, 3130, Poznan, PL",
                    PhoneNumber = "+123-456-789-022"
                },
                new OrderModel
                {
                    OrderId = 5,
                    GadgetId = 3,
                    UserId = "b348feb0-037d-40c9-941e-afc111648c6e",
                    Address = "ul. Polweiska 27, 3130, Poznan, PL",
                    PhoneNumber = "+123-456-789-022"
                },
                new OrderModel
                {
                    OrderId = 6,
                    GadgetId = 4,
                    UserId = "b348feb0-037d-40c9-941e-afc111648c6e",
                    Address = "ul. Polweiska 27, 3130, Poznan, PL",
                    PhoneNumber = "+123-456-789-022"
                },
                new OrderModel
                {
                    OrderId = 7,
                    GadgetId = 5,
                    UserId = "b348feb0-037d-40c9-941e-afc111648c6e",
                    Address = "ul. Polweiska 27, 3130, Poznan, PL",
                    PhoneNumber = "+123-456-789-022"
                }
            );
        }
    }
}
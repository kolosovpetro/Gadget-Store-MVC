﻿// <auto-generated />
using System;
using GadgetStoreMVC.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace GadgetStoreMVC.Data.Migrations
{
    [DbContext(typeof(PostgresContext))]
    partial class PostgresContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityByDefaultColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.0-rc.2.20475.6");

            modelBuilder.Entity("GadgetStoreMVC.Models.Models.GadgetModel", b =>
                {
                    b.Property<int>("GadgetId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<string>("Description")
                        .HasColumnType("character varying")
                        .HasColumnName("Description");

                    b.Property<string>("Image")
                        .HasColumnType("character varying")
                        .HasColumnName("Image");

                    b.Property<string>("Name")
                        .HasColumnType("character varying")
                        .HasColumnName("Name");

                    b.Property<float>("Price")
                        .HasColumnType("real")
                        .HasColumnName("Price");

                    b.HasKey("GadgetId")
                        .HasName("Gadget_pkey");

                    b.ToTable("Gadgets");

                    b.HasData(
                        new
                        {
                            GadgetId = 1,
                            Description = "Android 4.4 KitKat Tablet PC, Cortex A8 1.2 GHz Dual Core Processor,512MB / 4GB,Dual Camera,G-Sensor (Black)",
                            Image = "prontotec.jpg",
                            Name = "ProntoTec 7",
                            Price = 46.99f
                        },
                        new
                        {
                            GadgetId = 2,
                            Description = "Android 4.4 Kit Kat OS, 1.2 GHz quad-core processor",
                            Image = "samsung-galaxy.jpg",
                            Name = "Samsung Galaxy",
                            Price = 120.95f
                        },
                        new
                        {
                            GadgetId = 3,
                            Description = "NeuTab N7 Pro tablet features the amazing powerful, Quad Core processor performs approximately Double multitasking running speed, and is more reliable than ever",
                            Image = "neutab.jpg",
                            Name = "NeuTab® N7 Pro 7",
                            Price = 59.99f
                        },
                        new
                        {
                            GadgetId = 4,
                            Description = "Dragon Touch Y88X tablet featuring the incredible powerful Allwinner Quad Core A33, up to four times faster CPU, ensures faster multitasking speed than ever. With the super-portable size, you get a robust power in a device that can be taken everywhere",
                            Image = "dragon-touch.jpg",
                            Name = "Dragon Touch® Y88X 7",
                            Price = 54.99f
                        },
                        new
                        {
                            GadgetId = 5,
                            Description = "This Alldaymall tablet featuring the incredible powerful Allwinner Quad Core A33, up to four times faster CPU, ensures faster multitasking speed than ever. With the super-portable size, you get a robust power in a device that can be taken everywhere",
                            Image = "Alldaymall.jpg",
                            Name = "Alldaymall A88X 7",
                            Price = 47.99f
                        },
                        new
                        {
                            GadgetId = 6,
                            Description = "Pad 7 ME170CX-A1-BK 7-Inch 16GB Tablet. Dual-Core Intel Atom Z2520 1.2GHz CPU",
                            Image = "asus-memo.jpg",
                            Name = "ASUS MeMO",
                            Price = 94.99f
                        },
                        new
                        {
                            GadgetId = 7,
                            Description = "Latest Generation Intel Dual Core Celeron 2.16 GHz Processor (turbo to 2.41 GHz)",
                            Image = "asus-latest.jpg",
                            Name = "ASUS 15.6-Inch",
                            Price = 249.5f
                        },
                        new
                        {
                            GadgetId = 8,
                            Description = "This Certified Refurbished product is manufacturer refurbished, shows limited or no wear, and includes all original accessories plus a 90-day warranty",
                            Image = "hp-pavilion.jpg",
                            Name = "HP Pavilion 15-r030wm",
                            Price = 299.95f
                        },
                        new
                        {
                            GadgetId = 9,
                            Description = "Intel Celeron N2830 Processor, 15.6-Inch Screen, Intel HD Graphics",
                            Image = "dell-inspiron.jpg",
                            Name = "Dell Inspiron 15.6-Inch",
                            Price = 308f
                        },
                        new
                        {
                            GadgetId = 10,
                            Description = "15.6 HD Active Matrix TFT Color LED (1366 x 768) 16:9 CineCrystal Display",
                            Image = "acer-aspire.jpg",
                            Name = "Acer Aspire E Notebook",
                            Price = 299.95f
                        },
                        new
                        {
                            GadgetId = 11,
                            Description = "Intel Celeron N2840 Processor. 2 GB DDR3L SDRAM, 32 GB Solid-State Drive and 1TB OneDrive Cloud Storage for one year",
                            Image = "hp-stream.jpg",
                            Name = "HP Stream 13",
                            Price = 202.99f
                        },
                        new
                        {
                            GadgetId = 12,
                            Description = "T-Mobile Cell Phone 4G - White. 5MP Camera - Snap creative photos with built-in digital lenses",
                            Image = "nokia-lumia.jpg",
                            Name = "Nokia Lumia 521",
                            Price = 63.99f
                        },
                        new
                        {
                            GadgetId = 13,
                            Description = "13 MP Rear Facing BSI Camera / 5 MP Front Facing",
                            Image = "htc-desire.jpg",
                            Name = "HTC Desire 816",
                            Price = 177.99f
                        },
                        new
                        {
                            GadgetId = 14,
                            Description = "Uniquely designed 3G-enabled messaging phone with side-flipping QWERTY keyboard and external glow-thru OLED dial pad that 'disappears' when not in use",
                            Image = "sanyo-innuendo.jpg",
                            Name = "Sanyo Innuendo",
                            Price = 54.99f
                        },
                        new
                        {
                            GadgetId = 15,
                            Description = "Unlocked world GSM phone. 3G-850/2100, 2G -850/900/1800/1900",
                            Image = "ulefone.jpg",
                            Name = "Ulefone N9000",
                            Price = 133.99f
                        });
                });

            modelBuilder.Entity("GadgetStoreMVC.Models.Models.OrderModel", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<string>("Address")
                        .HasColumnType("character varying")
                        .HasColumnName("Address");

                    b.Property<int>("GadgetId")
                        .HasColumnType("integer")
                        .HasColumnName("GadgetId");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("character varying")
                        .HasColumnName("PhoneNumber");

                    b.Property<string>("UserId")
                        .HasColumnType("text")
                        .HasColumnName("UserId");

                    b.HasKey("OrderId")
                        .HasName("order_pkey");

                    b.ToTable("Orders");

                    b.HasData(
                        new
                        {
                            OrderId = 4,
                            Address = "ul. Polweiska 27, 3130, Poznan, PL",
                            GadgetId = 2,
                            PhoneNumber = "+123-456-789-022",
                            UserId = "b348feb0-037d-40c9-941e-afc111648c6e"
                        },
                        new
                        {
                            OrderId = 5,
                            Address = "ul. Polweiska 27, 3130, Poznan, PL",
                            GadgetId = 3,
                            PhoneNumber = "+123-456-789-022",
                            UserId = "b348feb0-037d-40c9-941e-afc111648c6e"
                        },
                        new
                        {
                            OrderId = 6,
                            Address = "ul. Polweiska 27, 3130, Poznan, PL",
                            GadgetId = 4,
                            PhoneNumber = "+123-456-789-022",
                            UserId = "b348feb0-037d-40c9-941e-afc111648c6e"
                        },
                        new
                        {
                            OrderId = 7,
                            Address = "ul. Polweiska 27, 3130, Poznan, PL",
                            GadgetId = 5,
                            PhoneNumber = "+123-456-789-022",
                            UserId = "b348feb0-037d-40c9-941e-afc111648c6e"
                        });
                });

            modelBuilder.Entity("GadgetStoreMVC.Models.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<int>("Year")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("text");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .HasColumnType("text");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("GadgetStoreMVC.Models.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("GadgetStoreMVC.Models.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GadgetStoreMVC.Models.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("GadgetStoreMVC.Models.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}

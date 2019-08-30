﻿// <auto-generated />
using System;
using DemoMarketShopSprinta.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DemoMarketShopSprinta.Migrations
{
    [DbContext(typeof(ShopContext))]
    [Migration("20190830093931_AddedProductToShoppingCart")]
    partial class AddedProductToShoppingCart
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DemoMarketShopSprinta.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("DemoMarketShopSprinta.Models.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CustomerCity");

                    b.Property<string>("CustomerEmail");

                    b.Property<string>("CustomerFirstName");

                    b.Property<string>("CustomerLastName");

                    b.Property<string>("CustomerPhone");

                    b.Property<string>("CustomerPostCode");

                    b.Property<DateTime>("CustomerRegDate");

                    b.Property<string>("CustomerStreetAddress");

                    b.HasKey("CustomerId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("DemoMarketShopSprinta.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CustomerId");

                    b.Property<string>("OrderCity");

                    b.Property<string>("OrderCountry");

                    b.Property<string>("OrderShipName");

                    b.Property<string>("OrderStreetAddress");

                    b.Property<int>("OrderTrackingNumber");

                    b.HasKey("OrderId");

                    b.HasIndex("CustomerId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("DemoMarketShopSprinta.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId");

                    b.Property<int>("OrderId");

                    b.Property<string>("ProductDescription");

                    b.Property<string>("ProductImage");

                    b.Property<string>("ProductName");

                    b.Property<double>("ProductPrice");

                    b.Property<int>("ProductQuantity");

                    b.HasKey("ProductId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("OrderId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("DemoMarketShopSprinta.Models.ShoppingCart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ProductId");

                    b.Property<string>("ProductName");

                    b.Property<int?>("Quantity");

                    b.Property<int?>("ShoppingCartId");

                    b.HasKey("Id");

                    b.ToTable("ShoppingCarts");
                });

            modelBuilder.Entity("DemoMarketShopSprinta.Models.Order", b =>
                {
                    b.HasOne("DemoMarketShopSprinta.Models.Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DemoMarketShopSprinta.Models.Product", b =>
                {
                    b.HasOne("DemoMarketShopSprinta.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DemoMarketShopSprinta.Models.Order", "Order")
                        .WithMany("Products")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}

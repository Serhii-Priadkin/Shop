// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Shop.Data;

#nullable disable

namespace Shop.Migrations
{
    [DbContext(typeof(AppDBContent))]
    [Migration("20220824080914_ShopCart")]
    partial class ShopCart
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Shop.Data.Models.Car", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<bool>("available")
                        .HasColumnType("bit");

                    b.Property<int>("categoryID")
                        .HasColumnType("int");

                    b.Property<string>("img")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("isFavorite")
                        .HasColumnType("bit");

                    b.Property<string>("longDesc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("price")
                        .HasColumnType("int");

                    b.Property<string>("shortDesc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("categoryID");

                    b.ToTable("Car");
                });

            modelBuilder.Entity("Shop.Data.Models.Category", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<string>("categoryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("desc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("Shop.Data.Models.Order", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<string>("address")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<DateTime>("orderTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("phone")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("surname")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("id");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("Shop.Data.Models.OrderDetail", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<int>("carID")
                        .HasColumnType("int");

                    b.Property<int>("orderID")
                        .HasColumnType("int");

                    b.Property<long>("price")
                        .HasColumnType("bigint");

                    b.HasKey("id");

                    b.HasIndex("carID");

                    b.HasIndex("orderID");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("Shop.Data.Models.ShopCartItem", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<string>("ShopCartId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("carid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("carid");

                    b.ToTable("ShopCartItem");
                });

            modelBuilder.Entity("Shop.Data.Models.Car", b =>
                {
                    b.HasOne("Shop.Data.Models.Category", "Category")
                        .WithMany("Cars")
                        .HasForeignKey("categoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Shop.Data.Models.OrderDetail", b =>
                {
                    b.HasOne("Shop.Data.Models.Car", "car")
                        .WithMany()
                        .HasForeignKey("carID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Shop.Data.Models.Order", "order")
                        .WithMany("orderDetails")
                        .HasForeignKey("orderID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("car");

                    b.Navigation("order");
                });

            modelBuilder.Entity("Shop.Data.Models.ShopCartItem", b =>
                {
                    b.HasOne("Shop.Data.Models.Car", "car")
                        .WithMany()
                        .HasForeignKey("carid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("car");
                });

            modelBuilder.Entity("Shop.Data.Models.Category", b =>
                {
                    b.Navigation("Cars");
                });

            modelBuilder.Entity("Shop.Data.Models.Order", b =>
                {
                    b.Navigation("orderDetails");
                });
#pragma warning restore 612, 618
        }
    }
}

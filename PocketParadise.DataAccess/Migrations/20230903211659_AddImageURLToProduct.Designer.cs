﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PocketParadise.DataAccess.Data;

#nullable disable

namespace PocketParadise.DataAccess.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230903211659_AddImageURLToProduct")]
    partial class AddImageURLToProduct
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0-preview.7.23375.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PocketParadise.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DisplayOrder = 1,
                            Name = "Halloween"
                        },
                        new
                        {
                            Id = 2,
                            DisplayOrder = 2,
                            Name = "Christmas"
                        },
                        new
                        {
                            Id = 3,
                            DisplayOrder = 3,
                            Name = "Valentine's Day"
                        },
                        new
                        {
                            Id = 4,
                            DisplayOrder = 4,
                            Name = "Easter"
                        },
                        new
                        {
                            Id = 5,
                            DisplayOrder = 5,
                            Name = "Special"
                        });
                });

            modelBuilder.Entity("PocketParadise.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 2,
                            Description = "Its a cute pikachu HUH",
                            ImageUrl = "",
                            Price = 70.00m,
                            Quantity = 2,
                            Title = "Pikachu Cube"
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 2,
                            Description = "Latest 5G smartphone with three cameras",
                            ImageUrl = "",
                            Price = 40.00m,
                            Quantity = 3,
                            Title = "Alolan Vulpix Dome"
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 3,
                            Description = "Ergonomic chair with lumbar support",
                            ImageUrl = "",
                            Price = 20.00m,
                            Quantity = 1,
                            Title = "Vaporeon Mini Cube"
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 1,
                            Description = "Noise-cancelling over-the-ear headphones",
                            ImageUrl = "",
                            Price = 500.00m,
                            Quantity = 1,
                            Title = "Eeveelutions Big Boy"
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 4,
                            Description = "Waterproof smartwatch with heart rate monitor",
                            ImageUrl = "",
                            Price = 15.00m,
                            Quantity = 4,
                            Title = "Mitsu Charm"
                        });
                });

            modelBuilder.Entity("PocketParadise.Models.Product", b =>
                {
                    b.HasOne("PocketParadise.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });
#pragma warning restore 612, 618
        }
    }
}

﻿// <auto-generated />
using System;
using Lombard.API;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Lombard.API.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085");

            modelBuilder.Entity("Lombard.API.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<double>("Price");

                    b.Property<int>("Quantity");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new { Id = 1, Name = "Opona", Price = 10.0, Quantity = 30 },
                        new { Id = 2, Name = "Felga", Price = 50.0, Quantity = 5 },
                        new { Id = 3, Name = "Klucz", Price = 3.0, Quantity = 100 },
                        new { Id = 4, Name = "Sruba", Price = 1.0, Quantity = 500 }
                    );
                });

            modelBuilder.Entity("Lombard.API.Models.ProductHistory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<double>("Price");

                    b.Property<int>("Quantity");

                    b.Property<int>("TransactionId");

                    b.HasKey("Id");

                    b.HasIndex("TransactionId");

                    b.ToTable("ProductsHistory");

                    b.HasData(
                        new { Id = 1, Name = "Opona", Price = 10.0, Quantity = 35, TransactionId = 1 },
                        new { Id = 2, Name = "Felga", Price = 50.0, Quantity = 10, TransactionId = 1 },
                        new { Id = 3, Name = "Klucz", Price = 3.0, Quantity = 105, TransactionId = 1 },
                        new { Id = 4, Name = "Sruba", Price = 1.0, Quantity = 510, TransactionId = 1 },
                        new { Id = 5, Name = "Opona", Price = 12.0, Quantity = 5, TransactionId = 2 },
                        new { Id = 6, Name = "Felga", Price = 51.0, Quantity = 5, TransactionId = 2 },
                        new { Id = 7, Name = "Klucz", Price = 4.0, Quantity = 5, TransactionId = 2 },
                        new { Id = 8, Name = "Sruba", Price = 1.25, Quantity = 10, TransactionId = 2 }
                    );
                });

            modelBuilder.Entity("Lombard.API.Models.Transaction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("TransactionDate");

                    b.Property<int>("TransactionType");

                    b.HasKey("Id");

                    b.ToTable("Transactions");

                    b.HasData(
                        new { Id = 1, TransactionDate = new DateTime(2019, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), TransactionType = 0 },
                        new { Id = 2, TransactionDate = new DateTime(2019, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), TransactionType = 1 }
                    );
                });

            modelBuilder.Entity("Lombard.API.Models.ProductHistory", b =>
                {
                    b.HasOne("Lombard.API.Models.Transaction", "Transaction")
                        .WithMany("ProductHistory")
                        .HasForeignKey("TransactionId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}

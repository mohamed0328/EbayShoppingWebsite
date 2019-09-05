﻿// <auto-generated />
using System;
using Ebay.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Ebay.Migrations
{
    [DbContext(typeof(EbayDbContext))]
    [Migration("20190312171722_Max error")]
    partial class Maxerror
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Ebay.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal?>("Discount");

                    b.Property<int?>("ProductId");

                    b.Property<int>("Qty");

                    b.Property<decimal>("TotalCost");

                    b.Property<decimal>("TotalPaid");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("orders");
                });

            modelBuilder.Entity("Ebay.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal?>("Discount");

                    b.Property<byte[]>("Image");

                    b.Property<string>("ProductDscription")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasMaxLength(25);

                    b.Property<int>("Qty");

                    b.Property<decimal>("price");

                    b.HasKey("Id");

                    b.ToTable("products");
                });

            modelBuilder.Entity("Ebay.Models.Order", b =>
                {
                    b.HasOne("Ebay.Models.Product", "Product")
                        .WithMany("Orders")
                        .HasForeignKey("ProductId");
                });
#pragma warning restore 612, 618
        }
    }
}
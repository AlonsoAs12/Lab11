﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Lab11.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240601180115_v1_alonso")]
    partial class v1_alonso
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.19")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Customer", b =>
                {
                    b.Property<int>("idCustomers")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idCustomers"));

                    b.Property<string>("DocumentNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idCustomers");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("Detail", b =>
                {
                    b.Property<int>("idDetails")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idDetails"));

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int>("Invoices_idInvoices")
                        .HasColumnType("int");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.Property<int>("Products_idProducts")
                        .HasColumnType("int");

                    b.Property<float>("SubTotal")
                        .HasColumnType("real");

                    b.HasKey("idDetails");

                    b.HasIndex("Invoices_idInvoices");

                    b.HasIndex("Products_idProducts");

                    b.ToTable("Details");
                });

            modelBuilder.Entity("Invoice", b =>
                {
                    b.Property<int>("idInvoices")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idInvoices"));

                    b.Property<int>("Customers_idCustomers")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("InvoiceNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Total")
                        .HasColumnType("real");

                    b.HasKey("idInvoices");

                    b.HasIndex("Customers_idCustomers");

                    b.ToTable("Invoices");
                });

            modelBuilder.Entity("Product", b =>
                {
                    b.Property<int>("idProducts")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idProducts"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.HasKey("idProducts");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Detail", b =>
                {
                    b.HasOne("Invoice", "Invoice")
                        .WithMany("Details")
                        .HasForeignKey("Invoices_idInvoices")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Product", "Product")
                        .WithMany("Details")
                        .HasForeignKey("Products_idProducts")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Invoice");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Invoice", b =>
                {
                    b.HasOne("Customer", "Customer")
                        .WithMany("Invoices")
                        .HasForeignKey("Customers_idCustomers")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("Customer", b =>
                {
                    b.Navigation("Invoices");
                });

            modelBuilder.Entity("Invoice", b =>
                {
                    b.Navigation("Details");
                });

            modelBuilder.Entity("Product", b =>
                {
                    b.Navigation("Details");
                });
#pragma warning restore 612, 618
        }
    }
}
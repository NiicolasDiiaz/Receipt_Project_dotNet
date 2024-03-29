﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Proyecto_Factura_V3.DataAccess;

namespace Proyecto_Factura_V3.Migrations
{
    [DbContext(typeof(DDBBContext))]
    [Migration("20210724210835_NewMigrationV2")]
    partial class NewMigrationV2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.8")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Proyecto_Factura_V3.Models.Branch", b =>
                {
                    b.Property<int>("BranchId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmailAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Phone")
                        .HasColumnType("int");

                    b.HasKey("BranchId");

                    b.HasIndex("CompanyId");

                    b.ToTable("Branches");
                });

            modelBuilder.Entity("Proyecto_Factura_V3.Models.Company", b =>
                {
                    b.Property<int>("CompanyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Nit")
                        .HasColumnType("int");

                    b.HasKey("CompanyId");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("Proyecto_Factura_V3.Models.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Cellphone")
                        .HasColumnType("int");

                    b.Property<string>("EmailAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HomeAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("Proyecto_Factura_V3.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Manufacturer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TaxRateId")
                        .HasColumnType("int");

                    b.Property<double>("UnitPrice")
                        .HasColumnType("float");

                    b.HasKey("ProductId");

                    b.HasIndex("TaxRateId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Proyecto_Factura_V3.Models.Receipt", b =>
                {
                    b.Property<int>("ReceiptId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("ReceiptHeadId")
                        .HasColumnType("int");

                    b.HasKey("ReceiptId");

                    b.HasIndex("ReceiptHeadId");

                    b.ToTable("Receipts");
                });

            modelBuilder.Entity("Proyecto_Factura_V3.Models.ReceiptDetail", b =>
                {
                    b.Property<int>("ReceiptDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int?>("ReceiptId")
                        .HasColumnType("int");

                    b.Property<double>("TaxRate")
                        .HasColumnType("float");

                    b.Property<double>("TotalValue")
                        .HasColumnType("float");

                    b.Property<double>("UnitValue")
                        .HasColumnType("float");

                    b.HasKey("ReceiptDetailId");

                    b.HasIndex("ProductId");

                    b.HasIndex("ReceiptId");

                    b.ToTable("ReceiptDetails");
                });

            modelBuilder.Entity("Proyecto_Factura_V3.Models.ReceiptHead", b =>
                {
                    b.Property<int>("ReceiptHeadId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BranchId")
                        .HasColumnType("int");

                    b.Property<int?>("CompanyId")
                        .HasColumnType("int");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.HasKey("ReceiptHeadId");

                    b.HasIndex("BranchId");

                    b.HasIndex("CompanyId");

                    b.HasIndex("CustomerId");

                    b.ToTable("ReceiptHeads");
                });

            modelBuilder.Entity("Proyecto_Factura_V3.Models.TaxRate", b =>
                {
                    b.Property<int>("TaxRateId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Category")
                        .HasColumnType("int");

                    b.Property<double>("Rate")
                        .HasColumnType("float");

                    b.HasKey("TaxRateId");

                    b.ToTable("TaxRates");
                });

            modelBuilder.Entity("Proyecto_Factura_V3.Models.Branch", b =>
                {
                    b.HasOne("Proyecto_Factura_V3.Models.Company", "Company")
                        .WithMany("Branches")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");
                });

            modelBuilder.Entity("Proyecto_Factura_V3.Models.Product", b =>
                {
                    b.HasOne("Proyecto_Factura_V3.Models.TaxRate", "TaxRate")
                        .WithMany()
                        .HasForeignKey("TaxRateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TaxRate");
                });

            modelBuilder.Entity("Proyecto_Factura_V3.Models.Receipt", b =>
                {
                    b.HasOne("Proyecto_Factura_V3.Models.ReceiptHead", "ReceiptHead")
                        .WithMany()
                        .HasForeignKey("ReceiptHeadId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ReceiptHead");
                });

            modelBuilder.Entity("Proyecto_Factura_V3.Models.ReceiptDetail", b =>
                {
                    b.HasOne("Proyecto_Factura_V3.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Proyecto_Factura_V3.Models.Receipt", null)
                        .WithMany("ReceiptDetails")
                        .HasForeignKey("ReceiptId");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Proyecto_Factura_V3.Models.ReceiptHead", b =>
                {
                    b.HasOne("Proyecto_Factura_V3.Models.Branch", "Branch")
                        .WithMany()
                        .HasForeignKey("BranchId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Proyecto_Factura_V3.Models.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId");

                    b.HasOne("Proyecto_Factura_V3.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Branch");

                    b.Navigation("Company");

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("Proyecto_Factura_V3.Models.Company", b =>
                {
                    b.Navigation("Branches");
                });

            modelBuilder.Entity("Proyecto_Factura_V3.Models.Receipt", b =>
                {
                    b.Navigation("ReceiptDetails");
                });
#pragma warning restore 612, 618
        }
    }
}

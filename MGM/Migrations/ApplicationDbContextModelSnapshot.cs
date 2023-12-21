﻿// <auto-generated />
using System;
using MGM.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MGM.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Proxies:ChangeTracking", false)
                .HasAnnotation("Proxies:CheckEquality", false)
                .HasAnnotation("Proxies:LazyLoading", true)
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MGM.Models.Crop", b =>
                {
                    b.Property<Guid>("CropId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("BlackOutDays")
                        .HasColumnType("int");

                    b.Property<int>("ExpectedYield")
                        .HasColumnType("int");

                    b.Property<int>("GerminationDays")
                        .HasColumnType("int");

                    b.Property<Guid?>("GrowPlanId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("InventoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SeedDensity")
                        .HasColumnType("int");

                    b.Property<int>("SoakHours")
                        .HasColumnType("int");

                    b.Property<int>("StackDays")
                        .HasColumnType("int");

                    b.Property<int>("TotalGrowthDays")
                        .HasColumnType("int");

                    b.Property<int>("WeightedDays")
                        .HasColumnType("int");

                    b.HasKey("CropId");

                    b.HasIndex("GrowPlanId");

                    b.HasIndex("InventoryId");

                    b.ToTable("Crops");
                });

            modelBuilder.Entity("MGM.Models.Customer", b =>
                {
                    b.Property<Guid>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Region")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerId");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("MGM.Models.CustomerOrder", b =>
                {
                    b.Property<Guid>("CustomerOrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CustomerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Qty")
                        .HasColumnType("int");

                    b.Property<float>("Total")
                        .HasColumnType("real");

                    b.HasKey("CustomerOrderId");

                    b.HasIndex("CustomerId");

                    b.ToTable("CustomerOrder");
                });

            modelBuilder.Entity("MGM.Models.CustomerOrderDetail", b =>
                {
                    b.Property<Guid>("CustomerOrderDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CropId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CustomerOrderId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("CustomerOrderDetailId");

                    b.HasIndex("CropId");

                    b.HasIndex("CustomerOrderId");

                    b.ToTable("CustomerOrderDetails");
                });

            modelBuilder.Entity("MGM.Models.GrowMedia", b =>
                {
                    b.Property<Guid>("GrowMediaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateOnly>("Date")
                        .HasColumnType("date");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<Guid>("SupplierId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<float>("Tax")
                        .HasColumnType("real");

                    b.Property<float>("Total")
                        .HasColumnType("real");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Volume")
                        .HasColumnType("real");

                    b.HasKey("GrowMediaId");

                    b.HasIndex("SupplierId");

                    b.ToTable("GrowMedia");
                });

            modelBuilder.Entity("MGM.Models.GrowPlan", b =>
                {
                    b.Property<Guid>("GrowPlanId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("GrowPlanId");

                    b.ToTable("GrowPlans");
                });

            modelBuilder.Entity("MGM.Models.Inventory", b =>
                {
                    b.Property<Guid>("InventoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("InventoryType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("InventoryId");

                    b.ToTable("Inventories");
                });

            modelBuilder.Entity("MGM.Models.InventoryProduct", b =>
                {
                    b.Property<Guid>("InventoryProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateOnly>("Date")
                        .HasColumnType("date");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.Property<int>("Qty")
                        .HasColumnType("int");

                    b.Property<Guid>("SupplierId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("InventoryProductId");

                    b.HasIndex("SupplierId");

                    b.ToTable("InventoryProducts");
                });

            modelBuilder.Entity("MGM.Models.Lighting", b =>
                {
                    b.Property<Guid>("LightingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Size")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LightingId");

                    b.ToTable("Lightings");
                });

            modelBuilder.Entity("MGM.Models.MileStoneDate", b =>
                {
                    b.Property<Guid>("MileStoneDateId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateOnly>("DeliveryDay")
                        .HasColumnType("date");

                    b.Property<Guid?>("GrowPlanId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateOnly>("HarvestDay")
                        .HasColumnType("date");

                    b.Property<DateOnly>("SewDay")
                        .HasColumnType("date");

                    b.HasKey("MileStoneDateId");

                    b.HasIndex("GrowPlanId");

                    b.ToTable("MileStoneDates");
                });

            modelBuilder.Entity("MGM.Models.Package", b =>
                {
                    b.Property<Guid>("PackageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<float>("CurrentTotal")
                        .HasColumnType("real");

                    b.Property<DateOnly>("Date")
                        .HasColumnType("date");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("QtyofPackages")
                        .HasColumnType("int");

                    b.Property<float>("RemainingTotal")
                        .HasColumnType("real");

                    b.Property<string>("Size")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Subtotal")
                        .HasColumnType("real");

                    b.Property<Guid>("SupplierId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<float>("TotalQty")
                        .HasColumnType("real");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PackageId");

                    b.HasIndex("SupplierId");

                    b.ToTable("Packages");
                });

            modelBuilder.Entity("MGM.Models.Shelving", b =>
                {
                    b.Property<Guid>("ShelvingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Column")
                        .HasColumnType("int");

                    b.Property<int>("Row")
                        .HasColumnType("int");

                    b.Property<int>("TotalGrowSpaces")
                        .HasColumnType("int");

                    b.HasKey("ShelvingId");

                    b.ToTable("Shelvings");
                });

            modelBuilder.Entity("MGM.Models.Supplier", b =>
                {
                    b.Property<Guid>("SupplierId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("CropId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("LightingId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Region")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("ShelvingId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("SupplierId");

                    b.HasIndex("CropId");

                    b.HasIndex("LightingId");

                    b.HasIndex("ShelvingId");

                    b.ToTable("Suppliers");
                });

            modelBuilder.Entity("MGM.Models.Tray", b =>
                {
                    b.Property<Guid>("TrayId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CropId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TrayId");

                    b.HasIndex("CropId");

                    b.ToTable("Trays");
                });

            modelBuilder.Entity("MGM.Models.Crop", b =>
                {
                    b.HasOne("MGM.Models.GrowPlan", null)
                        .WithMany("Crops")
                        .HasForeignKey("GrowPlanId");

                    b.HasOne("MGM.Models.Inventory", null)
                        .WithMany("Crops")
                        .HasForeignKey("InventoryId");
                });

            modelBuilder.Entity("MGM.Models.CustomerOrder", b =>
                {
                    b.HasOne("MGM.Models.Customer", "Customer")
                        .WithMany("CustomerOrder")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("MGM.Models.CustomerOrderDetail", b =>
                {
                    b.HasOne("MGM.Models.Crop", "Crop")
                        .WithMany()
                        .HasForeignKey("CropId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MGM.Models.CustomerOrder", "CustomerOrder")
                        .WithMany()
                        .HasForeignKey("CustomerOrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Crop");

                    b.Navigation("CustomerOrder");
                });

            modelBuilder.Entity("MGM.Models.GrowMedia", b =>
                {
                    b.HasOne("MGM.Models.Supplier", "Supplier")
                        .WithMany("GrowMedia")
                        .HasForeignKey("SupplierId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Supplier");
                });

            modelBuilder.Entity("MGM.Models.InventoryProduct", b =>
                {
                    b.HasOne("MGM.Models.Supplier", "Supplier")
                        .WithMany()
                        .HasForeignKey("SupplierId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Supplier");
                });

            modelBuilder.Entity("MGM.Models.MileStoneDate", b =>
                {
                    b.HasOne("MGM.Models.GrowPlan", null)
                        .WithMany("MileStoneDates")
                        .HasForeignKey("GrowPlanId");
                });

            modelBuilder.Entity("MGM.Models.Package", b =>
                {
                    b.HasOne("MGM.Models.Supplier", "Supplier")
                        .WithMany("Packages")
                        .HasForeignKey("SupplierId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Supplier");
                });

            modelBuilder.Entity("MGM.Models.Supplier", b =>
                {
                    b.HasOne("MGM.Models.Crop", null)
                        .WithMany("Suppliers")
                        .HasForeignKey("CropId");

                    b.HasOne("MGM.Models.Lighting", null)
                        .WithMany("Suppliers")
                        .HasForeignKey("LightingId");

                    b.HasOne("MGM.Models.Shelving", null)
                        .WithMany("Suppliers")
                        .HasForeignKey("ShelvingId");
                });

            modelBuilder.Entity("MGM.Models.Tray", b =>
                {
                    b.HasOne("MGM.Models.Crop", null)
                        .WithMany("Trays")
                        .HasForeignKey("CropId");
                });

            modelBuilder.Entity("MGM.Models.Crop", b =>
                {
                    b.Navigation("Suppliers");

                    b.Navigation("Trays");
                });

            modelBuilder.Entity("MGM.Models.Customer", b =>
                {
                    b.Navigation("CustomerOrder");
                });

            modelBuilder.Entity("MGM.Models.GrowPlan", b =>
                {
                    b.Navigation("Crops");

                    b.Navigation("MileStoneDates");
                });

            modelBuilder.Entity("MGM.Models.Inventory", b =>
                {
                    b.Navigation("Crops");
                });

            modelBuilder.Entity("MGM.Models.Lighting", b =>
                {
                    b.Navigation("Suppliers");
                });

            modelBuilder.Entity("MGM.Models.Shelving", b =>
                {
                    b.Navigation("Suppliers");
                });

            modelBuilder.Entity("MGM.Models.Supplier", b =>
                {
                    b.Navigation("GrowMedia");

                    b.Navigation("Packages");
                });
#pragma warning restore 612, 618
        }
    }
}

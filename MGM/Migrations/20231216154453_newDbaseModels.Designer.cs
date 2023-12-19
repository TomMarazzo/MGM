﻿// <auto-generated />
using System;
using MGM.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MGM.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20231216154453_newDbaseModels")]
    partial class newDbaseModels
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Proxies:ChangeTracking", false)
                .HasAnnotation("Proxies:CheckEquality", false)
                .HasAnnotation("Proxies:LazyLoading", true)
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MGM.Models.CostQty", b =>
                {
                    b.Property<Guid>("CostQtyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("GrowMediaId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<float>("Qty")
                        .HasColumnType("real");

                    b.Property<Guid?>("SupplierId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("CostQtyId");

                    b.HasIndex("GrowMediaId");

                    b.HasIndex("SupplierId");

                    b.ToTable("costQties");
                });

            modelBuilder.Entity("MGM.Models.Crop", b =>
                {
                    b.Property<Guid>("CropId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CustomerOrderId")
                        .HasColumnType("uniqueidentifier");

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

                    b.Property<int>("TotalGrowthDays")
                        .HasColumnType("int");

                    b.Property<int>("WeightedDays")
                        .HasColumnType("int");

                    b.HasKey("CropId");

                    b.HasIndex("CustomerOrderId");

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

                    b.Property<Guid?>("CustomerOrderId")
                        .HasColumnType("uniqueidentifier");

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

                    b.HasIndex("CustomerOrderId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("MGM.Models.CustomerOrder", b =>
                {
                    b.Property<Guid>("CustomerOrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Comments")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("OrderStatus")
                        .HasColumnType("int");

                    b.Property<int>("Qty")
                        .HasColumnType("int");

                    b.Property<float>("Total")
                        .HasColumnType("real");

                    b.HasKey("CustomerOrderId");

                    b.ToTable("CustomerOrders");
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

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GrowMediaId");

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

                    b.Property<Guid?>("GrowMediaId")
                        .HasColumnType("uniqueidentifier");

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

                    b.HasIndex("GrowMediaId");

                    b.HasIndex("LightingId");

                    b.HasIndex("ShelvingId");

                    b.ToTable("Suppliers");
                });

            modelBuilder.Entity("MGM.Models.Tray", b =>
                {
                    b.Property<Guid>("TrayId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CostQtyId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CropId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TrayId");

                    b.HasIndex("CostQtyId");

                    b.HasIndex("CropId");

                    b.ToTable("Trays");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("MGM.Models.CostQty", b =>
                {
                    b.HasOne("MGM.Models.GrowMedia", null)
                        .WithMany("CostQties")
                        .HasForeignKey("GrowMediaId");

                    b.HasOne("MGM.Models.Supplier", null)
                        .WithMany("CostQties")
                        .HasForeignKey("SupplierId");
                });

            modelBuilder.Entity("MGM.Models.Crop", b =>
                {
                    b.HasOne("MGM.Models.CustomerOrder", null)
                        .WithMany("Crops")
                        .HasForeignKey("CustomerOrderId");

                    b.HasOne("MGM.Models.GrowPlan", null)
                        .WithMany("Crops")
                        .HasForeignKey("GrowPlanId");

                    b.HasOne("MGM.Models.Inventory", null)
                        .WithMany("Crops")
                        .HasForeignKey("InventoryId");
                });

            modelBuilder.Entity("MGM.Models.Customer", b =>
                {
                    b.HasOne("MGM.Models.CustomerOrder", null)
                        .WithMany("Customers")
                        .HasForeignKey("CustomerOrderId");
                });

            modelBuilder.Entity("MGM.Models.CustomerOrderDetail", b =>
                {
                    b.HasOne("MGM.Models.Crop", "Crop")
                        .WithMany()
                        .HasForeignKey("CropId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MGM.Models.CustomerOrder", "CustomerOrder")
                        .WithMany("CustomerOrderDetails")
                        .HasForeignKey("CustomerOrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Crop");

                    b.Navigation("CustomerOrder");
                });

            modelBuilder.Entity("MGM.Models.MileStoneDate", b =>
                {
                    b.HasOne("MGM.Models.GrowPlan", null)
                        .WithMany("MileStoneDates")
                        .HasForeignKey("GrowPlanId");
                });

            modelBuilder.Entity("MGM.Models.Supplier", b =>
                {
                    b.HasOne("MGM.Models.Crop", null)
                        .WithMany("Suppliers")
                        .HasForeignKey("CropId");

                    b.HasOne("MGM.Models.GrowMedia", null)
                        .WithMany("Suppliers")
                        .HasForeignKey("GrowMediaId");

                    b.HasOne("MGM.Models.Lighting", null)
                        .WithMany("Suppliers")
                        .HasForeignKey("LightingId");

                    b.HasOne("MGM.Models.Shelving", null)
                        .WithMany("Suppliers")
                        .HasForeignKey("ShelvingId");
                });

            modelBuilder.Entity("MGM.Models.Tray", b =>
                {
                    b.HasOne("MGM.Models.CostQty", "CostQty")
                        .WithMany()
                        .HasForeignKey("CostQtyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MGM.Models.Crop", null)
                        .WithMany("Trays")
                        .HasForeignKey("CropId");

                    b.Navigation("CostQty");
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
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
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

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MGM.Models.Crop", b =>
                {
                    b.Navigation("Suppliers");

                    b.Navigation("Trays");
                });

            modelBuilder.Entity("MGM.Models.CustomerOrder", b =>
                {
                    b.Navigation("Crops");

                    b.Navigation("CustomerOrderDetails");

                    b.Navigation("Customers");
                });

            modelBuilder.Entity("MGM.Models.GrowMedia", b =>
                {
                    b.Navigation("CostQties");

                    b.Navigation("Suppliers");
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
                    b.Navigation("CostQties");
                });
#pragma warning restore 612, 618
        }
    }
}

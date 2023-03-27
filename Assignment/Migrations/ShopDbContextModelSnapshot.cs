﻿// <auto-generated />
using System;
using Assignment.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Assignment.Migrations
{
    [DbContext(typeof(ShopDbContext))]
    partial class ShopDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("_1.DAL.Models.Account", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Account");
                });

            modelBuilder.Entity("_1.DAL.Models.Bill", b =>
                {
                    b.Property<Guid>("IdBill")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("IdCustomer")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdStaff")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("PaymentedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("PointsUsed")
                        .HasColumnType("int");

                    b.Property<DateTime>("ReceivedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ShipDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("IdBill");

                    b.HasIndex("IdCustomer");

                    b.HasIndex("IdStaff");

                    b.ToTable("bills");
                });

            modelBuilder.Entity("_1.DAL.Models.BillDetail", b =>
                {
                    b.Property<Guid>("IdMDetail")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<Guid>("IdBill")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdMaterial")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("MaterialName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal");

                    b.HasKey("IdMDetail");

                    b.HasIndex("IdBill");

                    b.HasIndex("IdMaterial");

                    b.ToTable("billDetailss");
                });

            modelBuilder.Entity("_1.DAL.Models.Customer", b =>
                {
                    b.Property<Guid>("IdCustomer")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("BirthOfDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("IdCustomer");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("_1.DAL.Models.Material", b =>
                {
                    b.Property<Guid>("IdMaterial")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("SoLuongTon")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("IdMaterial");

                    b.ToTable("Materials");
                });

            modelBuilder.Entity("_1.DAL.Models.MaterialDetail", b =>
                {
                    b.Property<Guid>("IdMDetail")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<Guid>("IdMaterial")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdProducer")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("ImportPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Unit")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("IdMDetail");

                    b.HasIndex("IdMaterial");

                    b.HasIndex("IdProducer");

                    b.ToTable("MaterialDetails");
                });

            modelBuilder.Entity("_1.DAL.Models.Position", b =>
                {
                    b.Property<Guid>("IdPosition")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("IdPosition");

                    b.ToTable("Positions");
                });

            modelBuilder.Entity("_1.DAL.Models.Producer", b =>
                {
                    b.Property<Guid>("IdProducer")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("IdProducer");

                    b.ToTable("Producers");
                });

            modelBuilder.Entity("_1.DAL.Models.Staff", b =>
                {
                    b.Property<Guid>("IdStaff")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("BirthOfDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("IdPosition")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdStore")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<decimal>("Wage")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("IdStaff");

                    b.HasIndex("IdPosition");

                    b.HasIndex("IdStore");

                    b.ToTable("Staffs");
                });

            modelBuilder.Entity("_1.DAL.Models.Store", b =>
                {
                    b.Property<Guid>("IdStore")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Nation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("IdStore");

                    b.ToTable("Stores");
                });

            modelBuilder.Entity("_1.DAL.Models.Bill", b =>
                {
                    b.HasOne("_1.DAL.Models.Customer", "Customer")
                        .WithMany("Bills")
                        .HasForeignKey("IdCustomer")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_KH");

                    b.HasOne("_1.DAL.Models.Staff", "Staff")
                        .WithMany("Bills")
                        .HasForeignKey("IdStaff")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_NV");

                    b.Navigation("Customer");

                    b.Navigation("Staff");
                });

            modelBuilder.Entity("_1.DAL.Models.BillDetail", b =>
                {
                    b.HasOne("_1.DAL.Models.Bill", "Bill")
                        .WithMany("BillDetails")
                        .HasForeignKey("IdBill")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_HD");

                    b.HasOne("_1.DAL.Models.Material", "Material")
                        .WithMany("BillDetails")
                        .HasForeignKey("IdMaterial")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_SP");

                    b.Navigation("Bill");

                    b.Navigation("Material");
                });

            modelBuilder.Entity("_1.DAL.Models.MaterialDetail", b =>
                {
                    b.HasOne("_1.DAL.Models.Material", "Material")
                        .WithMany("MaterialDetails")
                        .HasForeignKey("IdMaterial")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_SP2");

                    b.HasOne("_1.DAL.Models.Producer", "Producer")
                        .WithMany("MaterialDetails")
                        .HasForeignKey("IdProducer")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_Nsx");

                    b.Navigation("Material");

                    b.Navigation("Producer");
                });

            modelBuilder.Entity("_1.DAL.Models.Staff", b =>
                {
                    b.HasOne("_1.DAL.Models.Position", "Position")
                        .WithMany("Staffs")
                        .HasForeignKey("IdPosition")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_CV");

                    b.HasOne("_1.DAL.Models.Store", "Store")
                        .WithMany("Staffs")
                        .HasForeignKey("IdStore")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_CH");

                    b.Navigation("Position");

                    b.Navigation("Store");
                });

            modelBuilder.Entity("_1.DAL.Models.Bill", b =>
                {
                    b.Navigation("BillDetails");
                });

            modelBuilder.Entity("_1.DAL.Models.Customer", b =>
                {
                    b.Navigation("Bills");
                });

            modelBuilder.Entity("_1.DAL.Models.Material", b =>
                {
                    b.Navigation("BillDetails");

                    b.Navigation("MaterialDetails");
                });

            modelBuilder.Entity("_1.DAL.Models.Position", b =>
                {
                    b.Navigation("Staffs");
                });

            modelBuilder.Entity("_1.DAL.Models.Producer", b =>
                {
                    b.Navigation("MaterialDetails");
                });

            modelBuilder.Entity("_1.DAL.Models.Staff", b =>
                {
                    b.Navigation("Bills");
                });

            modelBuilder.Entity("_1.DAL.Models.Store", b =>
                {
                    b.Navigation("Staffs");
                });
#pragma warning restore 612, 618
        }
    }
}
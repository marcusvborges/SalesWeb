﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SalesWeb.Data;

#nullable disable

namespace SalesWeb.Migrations
{
    [DbContext(typeof(SalesWebContext))]
    [Migration("20240926152826_intialMigrationAfterUpdateDbConfig")]
    partial class intialMigrationAfterUpdateDbConfig
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.33")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("SalesWeb.Models.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("SalesWeb.Models.SalesRecord", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<double>("Amount")
                        .HasColumnType("double");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("Satatus")
                        .HasColumnType("int");

                    b.Property<int?>("SellerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SellerId");

                    b.ToTable("SalesRecord");
                });

            modelBuilder.Entity("SalesWeb.Models.Seller", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<double>("BaseSalary")
                        .HasColumnType("double");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime(6)");

                    b.Property<int?>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Seller");
                });

            modelBuilder.Entity("SalesWeb.Models.SalesRecord", b =>
                {
                    b.HasOne("SalesWeb.Models.Seller", "Seller")
                        .WithMany("Sales")
                        .HasForeignKey("SellerId");

                    b.Navigation("Seller");
                });

            modelBuilder.Entity("SalesWeb.Models.Seller", b =>
                {
                    b.HasOne("SalesWeb.Models.Department", "Department")
                        .WithMany("Sellers")
                        .HasForeignKey("DepartmentId");

                    b.Navigation("Department");
                });

            modelBuilder.Entity("SalesWeb.Models.Department", b =>
                {
                    b.Navigation("Sellers");
                });

            modelBuilder.Entity("SalesWeb.Models.Seller", b =>
                {
                    b.Navigation("Sales");
                });
#pragma warning restore 612, 618
        }
    }
}

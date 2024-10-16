﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using QLBH;

#nullable disable

namespace QLBH.Migrations
{
    [DbContext(typeof(EFDbContext))]
    [Migration("20240428114429_migration2")]
    partial class migration2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("QLBH.Models.Customer", b =>
                {
                    b.Property<long>("CustomerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("CustomerID"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<DateTime>("BirthDay")
                        .HasColumnType("date");

                    b.Property<string>("Email")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool?>("Gender")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("CustomerID");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            CustomerID = 1L,
                            Address = "111/2 Lê Lợi, P5, Q1, TP. Hồ Chí Minh",
                            BirthDay = new DateTime(1990, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "caulyqua@gmail.com",
                            Gender = false,
                            Name = "Lý Qua Cầu",
                            Phone = "0123456789",
                            Status = true
                        },
                        new
                        {
                            CustomerID = 2L,
                            Address = "2/10 Lý Thái Tổ, P1, Q2, TP. Hồ Chí Minh",
                            BirthDay = new DateTime(2000, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "sontranvan@gmail.com",
                            Gender = true,
                            Name = "Trần Văn Sơn",
                            Phone = "0923456789",
                            Status = true
                        },
                        new
                        {
                            CustomerID = 3L,
                            Address = "9/2 Hoàng Diệu, P4, Q5, TP.Hồ Chí Minh",
                            BirthDay = new DateTime(1980, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "mochoangduocthao@gmail.com",
                            Name = "Hoàng Dược Thảo Mộc",
                            Phone = "0723456789",
                            Status = true
                        },
                        new
                        {
                            CustomerID = 4L,
                            Address = "666/3 Nguyễn Trãi, P1, Tân An,Long An",
                            BirthDay = new DateTime(1991, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "trangcaothu@gmail.com",
                            Gender = false,
                            Name = "Cao Thu Trang",
                            Phone = "0623456789",
                            Status = true
                        },
                        new
                        {
                            CustomerID = 5L,
                            Address = "466/3 Nguyễn Du, P6, Gò Dầu, Tây Ninh",
                            BirthDay = new DateTime(1982, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "kieunguyen@gmail.com",
                            Gender = false,
                            Name = "Nguyễn Kiểu",
                            Phone = "0823456789",
                            Status = true
                        });
                });
#pragma warning restore 612, 618
        }
    }
}

﻿// <auto-generated />
using System;
using CourseStore.Infrastructures.DataAccess.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CourseStore.Infrastructures.DataAccess.Migrations
{
    [DbContext(typeof(CourseStoreContext))]
    [Migration("20190501213001_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CourseStore.Core.Domain.Entities.Course", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("LicensingModel");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Courses");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            LicensingModel = 1,
                            Name = "کارگاه DDD"
                        },
                        new
                        {
                            Id = 2L,
                            LicensingModel = 2,
                            Name = "دوره آموزشی NoSQLهای پرکاربرد"
                        },
                        new
                        {
                            Id = 3L,
                            LicensingModel = 2,
                            Name = "دوره آموزش ASP.NET Core 3.0 پیشرفته "
                        });
                });

            modelBuilder.Entity("CourseStore.Core.Domain.Entities.Customer", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<decimal>("MoneySpent");

                    b.Property<int>("Status");

                    b.Property<DateTime?>("StatusExpirationDate");

                    b.HasKey("Id");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Email = "mlotfi@gmail.com",
                            FirstName = "محمد",
                            LastName = "لطفی",
                            MoneySpent = 200000m,
                            Status = 2,
                            StatusExpirationDate = new DateTime(2019, 5, 17, 2, 0, 1, 383, DateTimeKind.Local).AddTicks(3375)
                        },
                        new
                        {
                            Id = 2L,
                            Email = "a.Azhdari@gmail.com",
                            FirstName = "آرش",
                            LastName = "اژدری",
                            MoneySpent = 20000m,
                            Status = 1
                        });
                });

            modelBuilder.Entity("CourseStore.Core.Domain.Entities.PurchasedCourse", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("CourseId");

                    b.Property<long>("CustomerId");

                    b.Property<DateTime?>("ExpirationDate");

                    b.Property<decimal>("Price");

                    b.Property<DateTime>("PurchaseDate");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("CustomerId");

                    b.ToTable("PurchasedCourses");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            CourseId = 1L,
                            CustomerId = 1L,
                            ExpirationDate = new DateTime(2019, 5, 3, 2, 0, 1, 386, DateTimeKind.Local).AddTicks(3746),
                            Price = 20000m,
                            PurchaseDate = new DateTime(2019, 5, 1, 2, 0, 1, 386, DateTimeKind.Local).AddTicks(4366)
                        },
                        new
                        {
                            Id = 2L,
                            CourseId = 2L,
                            CustomerId = 1L,
                            Price = 80000m,
                            PurchaseDate = new DateTime(2019, 4, 22, 2, 0, 1, 386, DateTimeKind.Local).AddTicks(4884)
                        },
                        new
                        {
                            Id = 3L,
                            CourseId = 3L,
                            CustomerId = 1L,
                            Price = 100000m,
                            PurchaseDate = new DateTime(2019, 5, 1, 2, 0, 1, 386, DateTimeKind.Local).AddTicks(4893)
                        },
                        new
                        {
                            Id = 4L,
                            CourseId = 1L,
                            CustomerId = 1L,
                            ExpirationDate = new DateTime(2019, 5, 3, 2, 0, 1, 386, DateTimeKind.Local).AddTicks(4897),
                            Price = 20000m,
                            PurchaseDate = new DateTime(2019, 5, 1, 2, 0, 1, 386, DateTimeKind.Local).AddTicks(4899)
                        });
                });

            modelBuilder.Entity("CourseStore.Core.Domain.Entities.PurchasedCourse", b =>
                {
                    b.HasOne("CourseStore.Core.Domain.Entities.Course", "Course")
                        .WithMany()
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CourseStore.Core.Domain.Entities.Customer")
                        .WithMany("PurchasedCourses")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}

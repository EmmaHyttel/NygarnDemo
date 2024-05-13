﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NygarnDemo.EFDbContext;

#nullable disable

namespace NygarnDemo.Migrations.UserDb
{
    [DbContext(typeof(UserDbContext))]
    partial class UserDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.18")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("NygarnDemo.Models.User", b =>
                {
                    b.Property<string>("UserName")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("nvarchar(8)");

                    b.HasKey("UserName");

                    b.ToTable("Users", (string)null);

                    b.HasData(
                        new
                        {
                            UserName = "EmmaStrikker123",
                            Address = "Vejgade 1",
                            Email = "emmastrikker@garn.dk",
                            Id = 1,
                            LastName = "Hyttel",
                            Name = "Emma",
                            Password = "maiv",
                            Phone = "12345678"
                        },
                        new
                        {
                            UserName = "MaiStrikker123",
                            Address = "Vejgade 2",
                            Email = "maistrikker@garn.dk",
                            Id = 2,
                            LastName = "Dinh",
                            Name = "Mai",
                            Password = "maiv",
                            Phone = "23456789"
                        },
                        new
                        {
                            UserName = "NannaHækler123",
                            Address = "Vejgade 3",
                            Email = "nannahækler@garn.dk",
                            Id = 3,
                            LastName = "Rister",
                            Name = "Nanna",
                            Password = "maiv",
                            Phone = "34567891"
                        });
                });

            modelBuilder.Entity("NygarnDemo.Models.Yarn", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Color")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("KnittingTension")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("MachineWash")
                        .HasColumnType("bit");

                    b.Property<int>("Material")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Size")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("Weight")
                        .HasColumnType("int");

                    b.Property<string>("Yardage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("UserName");

                    b.ToTable("Yarn");
                });

            modelBuilder.Entity("NygarnDemo.Models.Yarn", b =>
                {
                    b.HasOne("NygarnDemo.Models.User", null)
                        .WithMany("YarnWishList")
                        .HasForeignKey("UserName");
                });

            modelBuilder.Entity("NygarnDemo.Models.User", b =>
                {
                    b.Navigation("YarnWishList");
                });
#pragma warning restore 612, 618
        }
    }
}

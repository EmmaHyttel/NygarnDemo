﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NygarnDemo.EFDbContext;

#nullable disable

namespace NygarnDemo.Migrations
{
    [DbContext(typeof(NygarnDbContext))]
    [Migration("20240611200656_NygarnDemoFifth")]
    partial class NygarnDemoFifth
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.18")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("NygarnDemo.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductId"));

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ProductImage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProductId");

                    b.ToTable("Product");

                    b.UseTptMappingStrategy();
                });

            modelBuilder.Entity("NygarnDemo.Models.ShoppingCartLine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<decimal>("ProductPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("UserId");

                    b.ToTable("ShoppingCartLine");
                });

            modelBuilder.Entity("NygarnDemo.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

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
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("nvarchar(8)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.ToTable("User", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "En sej gade",
                            Email = "nem_hard@garn.dk",
                            LastName = "HARD",
                            Name = "NEM",
                            Password = "AQAAAAIAAYagAAAAECRLU8ujstE0u2/++eeXDCkzRWdMutap+cSD5l0kkKI8uFxfvPLTNJq4PKY8GZUjXg==",
                            Phone = "69696969",
                            UserName = "admin"
                        },
                        new
                        {
                            Id = 2,
                            Address = "Vejgade 1",
                            Email = "emmastrikker@garn.dk",
                            LastName = "Hyttel",
                            Name = "Emma",
                            Password = "AQAAAAIAAYagAAAAEBkTranZcOUfbK1auOEB3QBkKD7//o7+tux+7aRFyNQGiuH0DCle0IfG+mcLr41QVA==",
                            Phone = "12345678",
                            UserName = "EmmaStrikker123"
                        },
                        new
                        {
                            Id = 3,
                            Address = "Vejgade 2",
                            Email = "maistrikker@garn.dk",
                            LastName = "Dinh",
                            Name = "Mai",
                            Password = "AQAAAAIAAYagAAAAEMsM2Zu6xAQp5LOZ1/lwUE999ogvFcBYoQG6nGlG8GTpvRXtvqHHglD4ZwNtxkCzag==",
                            Phone = "23456789",
                            UserName = "MaiStrikker123"
                        },
                        new
                        {
                            Id = 4,
                            Address = "Vejgade 3",
                            Email = "nannahækler@garn.dk",
                            LastName = "Rister",
                            Name = "Nanna",
                            Password = "AQAAAAIAAYagAAAAEBuvbDYrGuSmKNZOSMdQn6GZJsd88RggEcb6UMnI0/cQyFT9IpNcIvadyf5pirs/BA==",
                            Phone = "34567891",
                            UserName = "NannaHækler123"
                        });
                });

            modelBuilder.Entity("NygarnDemo.Models.CrochetHook", b =>
                {
                    b.HasBaseType("NygarnDemo.Models.Product");

                    b.Property<int>("Material")
                        .HasColumnType("int");

                    b.Property<bool>("Set")
                        .HasColumnType("bit");

                    b.Property<int>("Size")
                        .HasColumnType("int");

                    b.ToTable("CrochetHook", (string)null);

                    b.HasData(
                        new
                        {
                            ProductId = 12,
                            Brand = "PetitKnit",
                            Description = "Gode til alt",
                            Name = "Knyt",
                            Price = 49m,
                            ProductImage = "",
                            Material = 0,
                            Set = true,
                            Size = 7
                        },
                        new
                        {
                            ProductId = 13,
                            Brand = "PetitKnit",
                            Description = "Gode til alt",
                            Name = "KnitPro",
                            Price = 149m,
                            ProductImage = "",
                            Material = 0,
                            Set = false,
                            Size = 3
                        },
                        new
                        {
                            ProductId = 14,
                            Brand = "PetitKnit",
                            Description = "",
                            Name = "NeedlePickled",
                            Price = 599m,
                            ProductImage = "",
                            Material = 0,
                            Set = false,
                            Size = 9
                        });
                });

            modelBuilder.Entity("NygarnDemo.Models.KnittingNeedle", b =>
                {
                    b.HasBaseType("NygarnDemo.Models.Product");

                    b.Property<int>("Material")
                        .HasColumnType("int");

                    b.Property<bool>("Set")
                        .HasColumnType("bit");

                    b.Property<int>("Size")
                        .HasColumnType("int");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.ToTable("KnittingNeedle", (string)null);

                    b.HasData(
                        new
                        {
                            ProductId = 9,
                            Brand = "KnitPro",
                            Description = "Gode til alt",
                            Name = "KnitPro",
                            Price = 149m,
                            ProductImage = "",
                            Material = 0,
                            Set = true,
                            Size = 3,
                            Type = 1
                        },
                        new
                        {
                            ProductId = 10,
                            Brand = "KnitPro",
                            Description = "Dejlig store",
                            Name = "Hot",
                            Price = 499m,
                            ProductImage = "",
                            Material = 2,
                            Set = true,
                            Size = 5,
                            Type = 3
                        },
                        new
                        {
                            ProductId = 11,
                            Brand = "KnitPro",
                            Description = "Gode til alt",
                            Name = "KnitPro",
                            Price = 140m,
                            ProductImage = "",
                            Material = 0,
                            Set = true,
                            Size = 3,
                            Type = 1
                        });
                });

            modelBuilder.Entity("NygarnDemo.Models.Tool", b =>
                {
                    b.HasBaseType("NygarnDemo.Models.Product");

                    b.Property<string>("Size")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("Tool", (string)null);

                    b.HasData(
                        new
                        {
                            ProductId = 6,
                            Brand = "PetitKnit",
                            Description = "Rigtig fine små knapper, der passer perfekt til lukningen på en bodystocking",
                            Name = "Babyknap",
                            Price = 30m,
                            ProductImage = "",
                            Size = "5 mm",
                            Type = "Knapper"
                        },
                        new
                        {
                            ProductId = 7,
                            Brand = "PetitKnit",
                            Description = "Fuldstændig præcis målebånd",
                            Name = "Målebånd",
                            Price = 25m,
                            ProductImage = "",
                            Size = "100 cm",
                            Type = "Målebånd"
                        },
                        new
                        {
                            ProductId = 8,
                            Brand = "Sandnes",
                            Description = "Super blødt bamsefyld til dit næste hækleprojekt",
                            Name = "Bamsefyld",
                            Price = 40m,
                            ProductImage = "",
                            Size = "100 gram",
                            Type = "Fyld"
                        });
                });

            modelBuilder.Entity("NygarnDemo.Models.Yarn", b =>
                {
                    b.HasBaseType("NygarnDemo.Models.Product");

                    b.Property<int>("Color")
                        .HasColumnType("int");

                    b.Property<string>("KnittingTension")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("MachineWash")
                        .HasColumnType("bit");

                    b.Property<int>("Material")
                        .HasColumnType("int");

                    b.Property<string>("SuggestedNeedleSize")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Weight")
                        .HasColumnType("int");

                    b.Property<string>("Yardage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("Yarn", (string)null);

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            Brand = "Sandnes garn",
                            Description = "100% merinould uden superwashbehandling \nKan maskinvaskes på 30 grader uldprogram",
                            Name = "Double Sunday",
                            Price = 57m,
                            ProductImage = "",
                            Color = 10,
                            KnittingTension = "21-22 masker = 10 cm",
                            MachineWash = true,
                            Material = 7,
                            SuggestedNeedleSize = "pind 3.5-4",
                            Weight = 50,
                            Yardage = "108 m"
                        },
                        new
                        {
                            ProductId = 2,
                            Brand = "Sandnes garn",
                            Description = "57% mohair, 15% uld og 28% silke \nKan maskinvaskes ved 30 grader (uldprogram)",
                            Name = "Tynn Silk Mohair",
                            Price = 75m,
                            ProductImage = "",
                            Color = 9,
                            KnittingTension = "24 m x 18 p = 10 x 10 cm",
                            MachineWash = true,
                            Material = 2,
                            SuggestedNeedleSize = "pind 4-5",
                            Weight = 25,
                            Yardage = "212 m"
                        },
                        new
                        {
                            ProductId = 3,
                            Brand = "Sandnes garn",
                            Description = "57% mohair, 15% uld og 28% silke \nKan maskinvaskes ved 30 grader (uldprogram)",
                            Name = "Tynn Silk Mohair",
                            Price = 75m,
                            ProductImage = "",
                            Color = 5,
                            KnittingTension = "24 m x 18 p = 10 x 10 cm",
                            MachineWash = true,
                            Material = 2,
                            SuggestedNeedleSize = "pind 3-5",
                            Weight = 25,
                            Yardage = "212 m"
                        },
                        new
                        {
                            ProductId = 4,
                            Brand = "Petitknit",
                            Description = "Vildt lækkert alpakka garn til dit næste tørklæde",
                            Name = "MaLamaa",
                            Price = 69m,
                            ProductImage = "",
                            Color = 9,
                            KnittingTension = "knittingTension25mX10cm",
                            MachineWash = true,
                            Material = 0,
                            SuggestedNeedleSize = "pind 6-8",
                            Weight = 50,
                            Yardage = "Yardage300mPr50g"
                        },
                        new
                        {
                            ProductId = 5,
                            Brand = "Petitknit",
                            Description = "Vildt lækkert silke garn til dit næste hårbånd",
                            Name = "SlikkeSilke",
                            Price = 75m,
                            ProductImage = "",
                            Color = 0,
                            KnittingTension = "knittingTension30mX10cm",
                            MachineWash = false,
                            Material = 1,
                            SuggestedNeedleSize = "pind 4-5",
                            Weight = 50,
                            Yardage = "Yardage400mPr50g"
                        });
                });

            modelBuilder.Entity("NygarnDemo.Models.ShoppingCartLine", b =>
                {
                    b.HasOne("NygarnDemo.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NygarnDemo.Models.User", null)
                        .WithMany("ShoppingCartLines")
                        .HasForeignKey("UserId");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("NygarnDemo.Models.CrochetHook", b =>
                {
                    b.HasOne("NygarnDemo.Models.Product", null)
                        .WithOne()
                        .HasForeignKey("NygarnDemo.Models.CrochetHook", "ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("NygarnDemo.Models.KnittingNeedle", b =>
                {
                    b.HasOne("NygarnDemo.Models.Product", null)
                        .WithOne()
                        .HasForeignKey("NygarnDemo.Models.KnittingNeedle", "ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("NygarnDemo.Models.Tool", b =>
                {
                    b.HasOne("NygarnDemo.Models.Product", null)
                        .WithOne()
                        .HasForeignKey("NygarnDemo.Models.Tool", "ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("NygarnDemo.Models.Yarn", b =>
                {
                    b.HasOne("NygarnDemo.Models.Product", null)
                        .WithOne()
                        .HasForeignKey("NygarnDemo.Models.Yarn", "ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("NygarnDemo.Models.User", b =>
                {
                    b.Navigation("ShoppingCartLines");
                });
#pragma warning restore 612, 618
        }
    }
}
﻿// <auto-generated />
using System;
using System.Collections.Generic;
using Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20240426052539_UpdateProductListInReceiptEntity")]
    partial class UpdateProductListInReceiptEntity
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Core.Entity.LoyaltyCardEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<double>("Balance")
                        .HasColumnType("double precision");

                    b.Property<List<double>>("BonusHistory")
                        .HasColumnType("double precision[]");

                    b.Property<string>("HolderName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<List<int>>("ReceiptIDs")
                        .HasColumnType("integer[]");

                    b.HasKey("Id");

                    b.ToTable("loyaltyCards");
                });

            modelBuilder.Entity("Core.Entity.ProductEntity", b =>
                {
                    b.Property<string>("ProductCode")
                        .HasColumnType("text");

                    b.Property<bool>("AgeLimit")
                        .HasColumnType("boolean");

                    b.Property<int>("Category")
                        .HasColumnType("integer");

                    b.Property<double?>("Count")
                        .HasColumnType("double precision");

                    b.Property<DateTime?>("ExpirationDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<double?>("Price")
                        .HasColumnType("double precision");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<double>("Volume")
                        .HasColumnType("double precision");

                    b.HasKey("ProductCode");

                    b.ToTable("products");
                });

            modelBuilder.Entity("Core.Entity.ReceiptEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<bool>("AgeLimitConfirmed")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("CancelDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("CancelReason")
                        .HasColumnType("integer");

                    b.Property<bool>("Canceled")
                        .HasColumnType("boolean");

                    b.Property<bool>("Closed")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("ClosedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<double?>("LoyaltyBonusAdded")
                        .HasColumnType("double precision");

                    b.Property<int?>("LoyaltyCardID")
                        .HasColumnType("integer");

                    b.Property<int?>("PayMethod")
                        .HasColumnType("integer");

                    b.Property<DateTime>("PaymentDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int?[]>("ProductCategories")
                        .IsRequired()
                        .HasColumnType("integer[]");

                    b.Property<List<string>>("ProductCodes")
                        .HasColumnType("text[]");

                    b.Property<List<double?>>("ProductCount")
                        .IsRequired()
                        .HasColumnType("double precision[]");

                    b.Property<List<string>>("ProductNames")
                        .IsRequired()
                        .HasColumnType("text[]");

                    b.Property<List<double?>>("ProductPrices")
                        .IsRequired()
                        .HasColumnType("double precision[]");

                    b.Property<string>("Seller")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<double>("Total")
                        .HasColumnType("double precision");

                    b.HasKey("Id");

                    b.ToTable("receipts");
                });

            modelBuilder.Entity("Core.Entity.UserEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("FIO")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("LastModifiedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Role")
                        .HasColumnType("integer");

                    b.Property<string>("Token")
                        .HasColumnType("text");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("users");
                });
#pragma warning restore 612, 618
        }
    }
}

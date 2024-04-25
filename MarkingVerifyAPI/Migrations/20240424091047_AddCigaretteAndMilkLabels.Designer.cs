﻿// <auto-generated />
using System;
using MarkingVerifyAPI.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace MarkingVerifyAPI.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20240424091047_AddCigaretteAndMilkLabels")]
    partial class AddCigaretteAndMilkLabels
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("MarkingVerifyAPI.Core.Entity.AlcoholLabelEntity", b =>
                {
                    b.Property<string>("Label")
                        .HasColumnType("text");

                    b.Property<int>("AlcoholCode")
                        .HasColumnType("integer");

                    b.Property<DateTime>("ExpirationDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<double>("Price")
                        .HasColumnType("double precision");

                    b.Property<double>("Volume")
                        .HasColumnType("double precision");

                    b.HasKey("Label");

                    b.HasIndex("Label")
                        .IsUnique();

                    b.ToTable("alcohollabels");
                });

            modelBuilder.Entity("MarkingVerifyAPI.Core.Entity.CigaretteLabelEntity", b =>
                {
                    b.Property<string>("Label")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<double>("Price")
                        .HasColumnType("double precision");

                    b.HasKey("Label");

                    b.HasIndex("Label")
                        .IsUnique();

                    b.ToTable("cigarettelabels");
                });
#pragma warning restore 612, 618
        }
    }
}

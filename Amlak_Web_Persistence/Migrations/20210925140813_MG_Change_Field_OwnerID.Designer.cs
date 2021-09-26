﻿// <auto-generated />
using System;
using Amlak_Web_Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Amlak_Web_Persistence.Migrations
{
    [DbContext(typeof(DataBaseContext))]
    [Migration("20210925140813_MG_Change_Field_OwnerID")]
    partial class MG_Change_Field_OwnerID
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Amlak_Web_Domain.Entity.Ground.Ground", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Area")
                        .HasColumnType("int");

                    b.Property<DateTime>("InsertDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsRemoved")
                        .HasColumnType("bit");

                    b.Property<int>("OwnerID")
                        .HasColumnType("int");

                    b.Property<string>("Possition")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdateTime")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.HasIndex("OwnerID");

                    b.ToTable("Ground");
                });

            modelBuilder.Entity("Amlak_Web_Domain.Entity.Owner.Owner", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("InsertDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsRemoved")
                        .HasColumnType("bit");

                    b.Property<string>("Tel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdateTime")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.ToTable("Owners");
                });

            modelBuilder.Entity("Amlak_Web_Domain.Entity.Ground.Ground", b =>
                {
                    b.HasOne("Amlak_Web_Domain.Entity.Owner.Owner", "Owner")
                        .WithMany("Ground")
                        .HasForeignKey("OwnerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Owner");
                });

            modelBuilder.Entity("Amlak_Web_Domain.Entity.Owner.Owner", b =>
                {
                    b.Navigation("Ground");
                });
#pragma warning restore 612, 618
        }
    }
}
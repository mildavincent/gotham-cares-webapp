﻿// <auto-generated />
using System;
using GothamCares.DataServices.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace GothamCares.DataServices.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20201204072723_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityByDefaultColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("GothamCares.Data.FoodPacket", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<int>("FoodPacketType")
                        .HasColumnType("integer");

                    b.Property<int?>("OutletId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("OutletId");

                    b.ToTable("FoodPackets");
                });

            modelBuilder.Entity("GothamCares.Data.Outlet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<string>("Landmark")
                        .HasMaxLength(300)
                        .HasColumnType("character varying(300)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<DateTime>("OpeningDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("StreetName")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("character varying(300)");

                    b.HasKey("Id");

                    b.ToTable("Outlets");
                });

            modelBuilder.Entity("GothamCares.Data.FoodPacket", b =>
                {
                    b.HasOne("GothamCares.Data.Outlet", null)
                        .WithMany("FoodPackets")
                        .HasForeignKey("OutletId");
                });

            modelBuilder.Entity("GothamCares.Data.Outlet", b =>
                {
                    b.Navigation("FoodPackets");
                });
#pragma warning restore 612, 618
        }
    }
}

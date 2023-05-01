﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Nothing.Nauta.App.Data;

#nullable disable

namespace Nothing.Nauta.App.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230501004646_Add_RemainingTime_And_ResetDateTime_To_AccountInfo")]
    partial class Add_RemainingTime_And_ResetDateTime_To_AccountInfo
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.16");

            modelBuilder.Entity("Nothing.Nauta.App.Data.AccountInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AccountType")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Password")
                        .HasColumnType("TEXT");

                    b.Property<TimeSpan>("RemainingTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("Username")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("Username", "AccountType")
                        .IsUnique();

                    b.ToTable("Accounts");
                });
#pragma warning restore 612, 618
        }
    }
}

﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Nothing.Nauta.App.Data;

#nullable disable

namespace Nothing.Nauta.App.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AppDbContext.cs" company="Stone Assemblies">
// Copyright © 2021 - 2023 Stone Assemblies. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Nothing.Nauta.App.Data;

using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public AppDbContext()
    {
        var folder = Environment.SpecialFolder.LocalApplicationData;
        var path = Environment.GetFolderPath(folder);
        this.DbPath = Path.Join(path, "data.db");
    }

    public DbSet<AccountInfo>? Accounts { get; set; }

    public string DbPath { get; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite($"Data Source={this.DbPath}");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AccountInfo>().HasIndex(c => new { c.Username, c.AccountType }).IsUnique();
    }
}
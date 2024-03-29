﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AppDbContextFactory.cs" company="Stone Assemblies">
// Copyright © 2021 - 2023 Stone Assemblies. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Nothing.Nauta.App.Models;

using Microsoft.EntityFrameworkCore.Design;

using Nothing.Nauta.App.Data;

public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
{
    public AppDbContext CreateDbContext(string[] args)
    {
        return new AppDbContext();
    }
}
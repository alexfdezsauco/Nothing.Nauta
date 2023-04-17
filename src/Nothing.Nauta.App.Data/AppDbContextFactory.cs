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
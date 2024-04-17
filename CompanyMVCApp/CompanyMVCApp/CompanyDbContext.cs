using CompanyMVCApp;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

public class CompanyDbContext : DbContext
{
    public DbSet<Company> Companies { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("YourConnectionStringHere");
    }
}

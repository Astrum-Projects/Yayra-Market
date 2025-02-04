using Microsoft.EntityFrameworkCore;
using System;



public class ApplicationDbContext : DbContext
{

    // public DbSet<CommonProperty> CommonProperties{get; set; }
   
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    
    }

    // Remove OnConfiguring if using dependency injection for configuration
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Username=postgres;Password=1234;Database=Yayra-Market");
    }
}


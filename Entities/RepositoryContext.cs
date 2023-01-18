using Microsoft.EntityFrameworkCore;
using Entities.Models;
using Entities.Configurations;

namespace Entities;

public class RepositoryContext : DbContext
{
    public RepositoryContext(DbContextOptions options)
        : base(options) {}
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfiguration(new AirportConfiguration());
    }

    //public DbSet<Airliner>? Airliners {get;set;} 
    public DbSet<Airport>? Airports {get;set;}
    //public DbSet<City>? Cities {get;set;}
    public DbSet<Flight>? Flights {get;set;}

}
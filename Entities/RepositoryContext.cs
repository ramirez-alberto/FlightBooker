using Microsoft.EntityFrameworkCore;
using Entities.Models;

namespace Entities;

public class RepositoryContext : DbContext
{
    public RepositoryContext(DbContextOptions options)
        : base(options) {}

    public DbSet<Airliner>? Airliners {get;set;} 
    public DbSet<Airport>? Airports {get;set;}
    public DbSet<City>? Cities {get;set;}
    public DbSet<Flight>? Flights {get;set;}

}
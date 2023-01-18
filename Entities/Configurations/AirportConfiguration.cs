using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Entities.Models;

namespace Entities.Configurations;

public class AirportConfiguration : IEntityTypeConfiguration<Airport>
{
    public void Configure(EntityTypeBuilder<Airport> builder)
    {
        builder.HasData(
            new Airport
            {
                Name = "Aeropuerto Tijuana",
                CityId = 001,
                AirportCode = "TIJ"
            },            
            new Airport
            {
                Name = "Aeropuerto Guadalajara",
                CityId = 002,
                AirportCode = "GDL"
            },            
            new Airport
            {
                Name = "Aeropuerto Ciudad de Mexico",
                CityId = 003,
                AirportCode = "CDMX"
            }

        );
    }

}
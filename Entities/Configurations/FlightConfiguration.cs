using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Entities.Models;

namespace Entities.Configurations;

public class FlightConfiguration : IEntityTypeConfiguration<Flight>
{
    public void Configure(EntityTypeBuilder<Flight> builder)
    {
        builder.HasData(
            new Flight
            {
                ArrivalAirportId = 001,
                DepartureAirportId = 003,
                EstimatedArrivalDate = new DateTime(2020,01,01,10,20,00),
                EstimatedDepartureDate = new DateTime(2020,01,01,11,30,00),
                AirlinerId = 001,
                TotalSeats = 50
            },
            new Flight
            {
                ArrivalAirportId = 002,
                DepartureAirportId = 001,
                EstimatedArrivalDate = new DateTime(2020,01,01,10,20,00),
                EstimatedDepartureDate = new DateTime(2020,01,01,11,30,00),
                AirlinerId = 002,
                TotalSeats = 12
            },
            new Flight
            {
                ArrivalAirportId = 003,
                DepartureAirportId = 002,
                EstimatedArrivalDate = new DateTime(2020,01,01,10,20,00),
                EstimatedDepartureDate = new DateTime(2020,01,01,11,30,00),
                AirlinerId = 003,
                TotalSeats = 34
            }

        );
    }

}
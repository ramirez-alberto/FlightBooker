namespace Entities.Models;

public class Flight
{
    public int FlightId {get;set;}
    public int FromAirportId {get;set;}
    public int ToAirportId {get;set;}
    public DateTime? EstimatedArrivalDate {get;set;}
    public DateTime? EstimatedDepartureDate {get;set;}
    public int AirlinerId {get;set;}
    public int TotalSeats {get;set;}

}
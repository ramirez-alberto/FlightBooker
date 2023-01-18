using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace Entities.Models;

[Table("flight")]
public class Flight
{
    public int FlightId {get;set;}
    
    [Required]
    public int ArrivalAirportId {get;set;}
    
    [Required]
    public int DepartureAirportId {get;set;}

    
    [DataType(DataType.DateTime)]
    public DateTime? EstimatedArrivalDate {get;set;}
    
    [DataType(DataType.DateTime)]
    public DateTime? EstimatedDepartureDate {get;set;}
    
    [Required]
    public int AirlinerId {get;set;}
    
    [Required]
    public int TotalSeats {get;set;}

    public Airport Airport {get;set;}

}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Entities.Models;

[Table("airport")]
public class Airport
{
    public int AirportId {get;set;}
    
    [Required]
    public string Name {set;get;}
    
    [Required]
    public int CityId {get;set;}

    [Required]
    [StringLength(4)]
    public string AirportCode {get;set;}
}
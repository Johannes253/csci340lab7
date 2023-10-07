using System.ComponentModel.DataAnnotations;

namespace RazorPagesCountry.Models;

public class Country
{
    public int Id { get; set; }
    public string? Name { get; set; }
    [DataType(DataType.Date)]
    public DateTime FormationDate { get; set; }
    public string? BestFood { get; set; }
    public decimal PopulationinMillion { get; set; }
}
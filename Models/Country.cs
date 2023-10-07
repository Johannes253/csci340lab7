using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPagesCountry.Models;

public class Country
{
    public int Id { get; set; }
    public string? Name { get; set; }
    [DataType(DataType.Date)]
    [Display(Name = "Formation Date")]
    public DateTime FormationDate { get; set; }
    [Display(Name = "Best Food")]
    public string? BestFood { get; set; }
    [Display(Name = "Population in Million")]
    public decimal PopulationinMillion { get; set; }
}
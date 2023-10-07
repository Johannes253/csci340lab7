using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPagesCountry.Models;

public class Country
{
    public int Id { get; set; }
    [StringLength(60, MinimumLength = 3)]
    public string? Name { get; set; }
    [DataType(DataType.Date)]
    [Display(Name = "Formation Date")]
    public DateTime FormationDate { get; set; }
    [Display(Name = "Best Food")]
    [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$"), Required, StringLength(30)]
    public string? BestFood { get; set; }
    [Display(Name = "Population in Million")]
    public decimal PopulationinMillion { get; set; }

     [Display(Name = "Known for")]
    public string Knownfor { get; set; } = string.Empty;
}
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WineCellarAPI.Models;

//this is a data model(table) for sqlite
public class Wine
{
    public int Id { get; set; }

    [MaxLength(100)]
    public string? Name { get; set; }

    [Required]
    [MaxLength(100)]
    public string? Maker { get; set; }

    [MaxLength(4)]
    public int? Year { get; set; }

    [Required]
    public WineColor Color { get; set; } = WineColor.NoSelection;
    [Required]
    public WineBody Body { get; set; } = WineBody.NoSelection;
    public bool? IsDessertWine { get; set; } = false;
    public bool? IsSparkling { get; set; } = false;

    [MaxLength(240)]
    public string? Description { get; set; }

    public ICollection<GrapeVariety>? GrapeVarieties { get; set; }

    public ICollection<Aroma>? Aromas { get; set; }


}
public enum WineColor
{
    NoSelection, Red, White, Rosé, Orange,
}

public enum WineBody
{
    NoSelection, Light, LightToMedium, Medium, MediumToFull, Full,
}



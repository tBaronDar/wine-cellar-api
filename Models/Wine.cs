using System.ComponentModel.DataAnnotations;

namespace WineCellarAPI.Models;

//this is a data model(table) for sqlite
public class Wine
{
    public int Id { get; set; }

    [Required]
    [MaxLength(100)]
    public string? Name { get; set; }

    [MaxLength(4)]
    public int? Year { get; set; }

    public ICollection<Aroma>? Aromas { get; set; }
}
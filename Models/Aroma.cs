using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

// namespace WineCellarAPI.Models;

//this is a data model
public class Aroma
{
    public int Id { get; set; }
    [Required]
    [MaxLength(50)]
    public string? Name { get; set; }

    [JsonIgnore]
    public ICollection<Wine>? Wines { get; set; }
}
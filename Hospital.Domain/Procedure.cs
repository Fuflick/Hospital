using System.ComponentModel.DataAnnotations;

namespace Hospital.Domain;

public class Procedure
{
    [Key]
    public int Id { get; set; }

    public string? Name { get; set; }

    public int? Cost { get; set; }
    
}
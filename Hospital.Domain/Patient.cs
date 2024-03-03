using System.ComponentModel.DataAnnotations;

namespace Hospital.Domain;

public class Patient
{
    [Key] 
    public int Id { get; set; }

    public string? Name { get; set; }

    public long Phone { get; set; }

    public int? Age { get; set; }

    public string? Gender { get; set; }
}
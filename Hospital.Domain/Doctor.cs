using System.ComponentModel.DataAnnotations;

namespace Hospital.Domain;

public class Doctor
{
    [Key] 
    public int Id { get; set; }

    public string? Name { get; set; }

    public List<Specialities>? Specification { get; set; }
    
}
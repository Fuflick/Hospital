using System.ComponentModel.DataAnnotations;

namespace Hospital.Domain;

public class Diagnose
{
    [Key] 
    public int Id { get; set; }
    
    public string? Code { get; set; }

    public string? Body { get; set; }
}
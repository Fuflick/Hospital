using System.ComponentModel.DataAnnotations;

namespace Hospital.Domain;

public class PatDiagnose
{
    [Key] 
    public int Id { get; set; }

    public int? PatId { get; set; }

    public int? DiagId { get; set; }
}
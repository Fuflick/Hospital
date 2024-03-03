using System.ComponentModel.DataAnnotations;

namespace Hospital.Domain;

public class ParProcedure
{
    [Key]
    public int Id { get; set; }
    
    public int? PatId { get; set; }

    public int? ProcId { get; set; }
}
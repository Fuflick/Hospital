using System.ComponentModel.DataAnnotations;

namespace Hospital.Domain;

public class DocProcedure
{
    [Key]
    public int Id { get; set; }

    public int? DocId { get; set; }

    public int? ProcId { get; set; }
}
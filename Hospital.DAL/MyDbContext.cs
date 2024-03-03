using Hospital.Domain;
using Microsoft.EntityFrameworkCore;

namespace Hospital.DAL;

public class MyDbContext : DbContext
{
    public DbSet<Diagnose> Diagnoses { get; set; } = null!;

    public DbSet<Doctor> Doctors { get; set; } = null!;
    
    public DbSet<Patient> Patients { get; set; } = null!;
    
    public DbSet<Procedure> Procedures { get; set; } = null!;
    
    public DbSet<PatDiagnose> PatDiagnoses { get; set; } = null!;
    
    public DbSet<DocProcedure> DocProcedures { get; set; } = null!;
    
    public DbSet<ParProcedure> ParProcedures { get; set; } = null!;


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Host=localhost;Username=postgres;Password=1234;Database=Hospital");
    }
}
using System;
using Hospital.DAL;
using Hospital.Domain;

namespace Hospital
{
    public static class Program
    {
        public static void Main()
        {
            using (MyDbContext dbContext = new MyDbContext())
            {
                var patient = new Patient() { Name = "Sam", Gender = "male", Age = 15, Phone = 8999999999 }; //пациент
                dbContext.Patients.Add(patient);
                var doc = new Doctor() { Name = "Iriska", Specification = new List<Specialities>() {Specialities.Lor}}; //врач
                dbContext.Doctors.Add(doc);
                var diagnose = new Diagnose() { Body = "Ну чё, оглох" }; //диагноз
                dbContext.Diagnoses.Add(diagnose);
                var procedure = new Procedure() { Name = "clear ears", Cost = 10000}; //процедура
                dbContext.Procedures.Add(procedure);
                var patDiag = new PatDiagnose() { PatId = patient.Id, DiagId = diagnose.Id}; //диагноз-пациент
                dbContext.PatDiagnoses.Add(patDiag);
                var patProcedure = new ParProcedure() { PatId = patient.Id, ProcId = procedure.Id}; //пациент-процедура
                dbContext.ParProcedures.Add(patProcedure);
                var docProcedure = new DocProcedure() { DocId = doc.Id, ProcId = procedure.Id }; //врач-процедура
                dbContext.DocProcedures.Add(docProcedure);
                
                dbContext.SaveChanges();
            }
        }
    }
}


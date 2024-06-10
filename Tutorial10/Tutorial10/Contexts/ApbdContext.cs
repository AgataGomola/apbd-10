using Microsoft.EntityFrameworkCore;
using Tutorial10.Models;

namespace Tutorial10.Contexts;

public class ApbdContext : DbContext
{
    public ApbdContext()
    {
    }
    public ApbdContext(DbContextOptions options) : base(options)
    {
    }
    public DbSet<Doctor> Doctors { get; set; }
    public DbSet<Medicament> Medicaments { get; set; }
    public DbSet<Patient> Patients{ get; set; }
    public DbSet<Prescription> Prescriptions { get; set; }
    public DbSet<PrescriptionMedicament> PrescriptionMedicaments { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        
        modelBuilder.Entity<Doctor>().HasData(new List<Doctor>
        {
            new Doctor {
                IdDoctor = 1,
                FirstName = "Jan",
                LastName = "Kowalski",
                Email = "kowalski.jan@gmail.com"
            },
            new Doctor {
                IdDoctor = 2,
                FirstName = "Adam",
                LastName = "Kwiatkowski",
                Email = "kwiatkowski.a@gmail.com"
            },
        });
        
        modelBuilder.Entity<Medicament>().HasData(new List<Medicament>
        {
            new Medicament {
                IdMedicament = 1,
                Name = "Ibuprofen",
                Description = "Drug used for pain relief.",
                Type = "Analgesic"
            },
            new Medicament {
                IdMedicament = 2,
                Name = "Amoxicillin",
                Description = "Antibiotic used to treat bacterial infections.",
                Type = "Antibiotic"
            }
        });

        modelBuilder.Entity<Patient>().HasData(new List<Patient>
        {
            new Patient {
                IdPatient = 1,
                FirstName = "Maria",
                LastName = "Nowak",
                Birthdate = new DateTime(1980, 1, 1)
            },
            new Patient {
                IdPatient = 2,
                FirstName = "Piotr",
                LastName = "Zieliński",
                Birthdate = new DateTime(1990, 2, 2)
            },
        });

        modelBuilder.Entity<Prescription>().HasData(new List<Prescription>
        {
            new Prescription {
                IdPrescription = 1,
                Date = DateTime.Now,
                DueDate = DateTime.Now.AddDays(30),
                IdPatient = 1,
                IdDoctor = 1
            },
            new Prescription {
                IdPrescription = 2,
                Date = DateTime.Now,
                DueDate = DateTime.Now.AddDays(30),
                IdPatient = 2,
                IdDoctor = 2
            },
        });

        modelBuilder.Entity<PrescriptionMedicament>().HasData(new List<PrescriptionMedicament>
        {
            new PrescriptionMedicament {
                IdMedicament = 1,
                IdPrescription = 1,
                Dose = 2,
                Details = "Take twice a day after meal"
            },
            new PrescriptionMedicament {
                IdMedicament = 2,
                IdPrescription = 2,
                Dose = 1,
                Details = "Take once a day before bed"
            },
        });
    }
}

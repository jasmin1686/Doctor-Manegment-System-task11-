using Doctor_Manegment_System_task11_.Models;
using Microsoft.EntityFrameworkCore;

namespace Doctor_Manegment_System_task11_.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Specialization> Specializations { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=DoctorSystem;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            modelBuilder.Entity<Specialization>().HasData(
    new Specialization { Id = 1, Name = "Cardiology" },
    new Specialization { Id = 2, Name = "Dermatology" },
    new Specialization { Id = 4, Name = "Pediatrics" },
    new Specialization { Id = 5, Name = "Psychiatry" },
    new Specialization { Id = 6, Name = "Dentistry" }
);


            modelBuilder.Entity<Doctor>().HasData(
                new Doctor
                {
                    Id = 1,
                    Name = "DrAhmedHassan",
                    Descraption = "Specialist in Cardiology with 10 years of experience.",
                    Email = "ahmed.hassan@example.com",
                    ImageUrl = "doctor1.jpg",
                    phone = "01012345678",
                    SpecializationId = 1
                },
    new Doctor
    {
        Id = 2,
        Name = "DrGamalMahmoud",
        Descraption = "Dermatologist focusing on skin and hair treatments.",
        Email = "gamal.mahmoud@example.com",
        ImageUrl = "doctor2.jpg",
        phone = "01098765432",
        SpecializationId = 2
    },
    
    new Doctor
    {
        Id = 4,
        Name = "DrNourEldin",
        Descraption = "Pediatrician with expertise in child nutrition and growth.",
        Email = "nour.eldin@example.com",
        ImageUrl = "doctor4.jpg",
        phone = "01234567890",
        SpecializationId = 4
    },
    new Doctor
    {
        Id = 5,
        Name = "DrKhaledNour",
        Descraption = "Psychiatrist specialized in cognitive behavioral therapy.",
        Email = "huda.khaled@example.com",
        ImageUrl = "doctor5.jpg",
        phone = "01555667788",
        SpecializationId = 5
    },
    new Doctor
    {
        Id = 6,
        Name = "DrKarimMostafa",
        Descraption = "Dentist focusing on cosmetic and restorative dentistry.",
        Email = "karim.mostafa@example.com",
        ImageUrl = "doctor6.jpg",
        phone = "01044455566",
        SpecializationId = 6
    }
            );

            modelBuilder.Entity<Patient>().HasData(
                new Patient { Id = 9, Name = "OmarYoussef", phone = "01011112222", Email = "omar.youssef@example.com", BirthDate = new DateTime(1995, 5, 12), DoctorId = 1 },
                new Patient { Id = 8, Name = "MonaAli", phone = "01033334444", Email = "mona.ali@example.com", BirthDate = new DateTime(1990, 8, 20), DoctorId = 2 },
                new Patient { Id = 7, Name = "KhaledMostafa", phone = "01155556666", Email = "khaled.mostafa@example.com", BirthDate = new DateTime(1987, 3, 15), DoctorId = 4 },
                new Patient { Id = 10, Name = "LaylaIbrahim", phone = "01277778888", Email = "layla.ibrahim@example.com", BirthDate = new DateTime(2000, 11, 2), DoctorId = 4 },
                new Patient { Id = 11, Name = "HassanFathy", phone = "01599990000", Email = "hassan.fathy@example.com", BirthDate = new DateTime(1982, 7, 7), DoctorId = 5 },
                new Patient { Id = 12, Name = "SalmaAdel", phone = "01012121212", Email = "salma.adel@example.com", BirthDate = new DateTime(1998, 9, 25), DoctorId = 6 }
            );
            modelBuilder.Entity<Appointment>()
        .HasOne(a => a.Patient)
        .WithMany(p => p.Appointments)
        .HasForeignKey(a => a.PatientId)
        .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Appointment>()
                .HasOne(a => a.Doctor)
                .WithMany(d => d.Appointments)
                .HasForeignKey(a => a.DoctorId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}

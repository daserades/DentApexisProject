using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DentApexis.MODEL.Entity;


namespace DentApexis.DAL.Context
{
    public class DentApexisDBContext: DbContext
    {
        public DentApexisDBContext()
        {


            Database.Connection.ConnectionString = "server=.;database=DentApexis;uid=sa;pwd=123";
            


        }

        public DbSet<Appointment> Appointments { get; set; }
      
        public DbSet<Doctor> Doctors { get; set; }
        
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Treatment> Treatments { get; set; }
        public DbSet<TreatmentPlan> TreatmentPlans { get; set; }
        
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<OnlineAppointment> OnlineAppointments { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {          
            modelBuilder.Entity<Appointment>().Property(x => x.PatientName).HasMaxLength(20).IsOptional();
            modelBuilder.Entity<Appointment>().Property(x => x.PatientSurname).HasMaxLength(20);
            modelBuilder.Entity<Appointment>().Property(x => x.CreatedDate).HasColumnType("datetime").IsOptional();
            modelBuilder.Entity<AppUser>().Property(x => x.CreatedDate).HasColumnType("datetime").IsOptional();
            modelBuilder.Entity<AppUser>().Property(x => x.Salary).IsOptional();
            modelBuilder.Entity<Doctor>().Property(x => x.Name).HasMaxLength(20);
            modelBuilder.Entity<Doctor>().Property(x => x.Surname).HasMaxLength(20);
            modelBuilder.Entity<Doctor>().Property(x => x.Salary).HasColumnType("money").IsOptional();
            modelBuilder.Entity<Doctor>().Property(x => x.AmountOfTurnover).HasColumnType("money").IsOptional();
            modelBuilder.Entity<Doctor>().Property(x => x.CreatedDate).HasColumnType("datetime").IsOptional();
            modelBuilder.Entity<Patient>().Property(x => x.IdentityNumber).HasMaxLength(11).IsOptional();
            modelBuilder.Entity<Patient>().Property(x => x.PhoneNumber).HasMaxLength(11).IsOptional();
            modelBuilder.Entity<Patient>().Property(x => x.BloodGroup).HasMaxLength(20).IsOptional();
            modelBuilder.Entity<Patient>().Property(x => x.InfectiousDisease).HasMaxLength(50).IsOptional();
            modelBuilder.Entity<Patient>().Property(x => x.Adress).HasMaxLength(100).IsOptional();
            modelBuilder.Entity<Patient>().Property(d => d.Birthdate).IsOptional();
            modelBuilder.Entity<Patient>().Property(x => x.Gender).HasMaxLength(10).IsOptional();
            modelBuilder.Entity<Patient>().Property(x => x.Reference).HasMaxLength(30).IsOptional();
            modelBuilder.Entity<Patient>().Property(x => x.TreatingDoctor).HasMaxLength(20).IsOptional();
            modelBuilder.Entity<Patient>().Property(d => d.CreatedDate).HasColumnType("datetime2").IsOptional();
            modelBuilder.Entity<Patient>().Property(x => x.EMailAddress).HasMaxLength(50).IsOptional();
            modelBuilder.Entity<Patient>().Property(x => x.Description).HasMaxLength(500).IsOptional();
            modelBuilder.Entity<Patient>().Property(x => x.ContractWorkplace).IsOptional();           
            modelBuilder.Entity<Patient>().Property(x => x.isActive).IsOptional();
            
            base.OnModelCreating(modelBuilder);
        }

    }
}

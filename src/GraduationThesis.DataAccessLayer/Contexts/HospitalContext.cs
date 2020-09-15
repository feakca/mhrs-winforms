using GraduationThesis.DataAccessLayer.FluentMap;
using GraduationThesis.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraduationThesis.DataAccessLayer.Contexts
{
    public class HospitalContext : DbContext
    {
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Hospital> Hospitals { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<AppointmentTime> AppointmentTimes { get; set; }
        public DbSet<Medicine> Medicines { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<County> Counties { get; set; }

        public HospitalContext() : base("GraduationThesis")
        {
            Database.SetInitializer(new DatabaseInitialization());
            Database.Initialize(true);
            Configuration.LazyLoadingEnabled = false;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new DoctorMap());
            modelBuilder.Configurations.Add(new HospitalMap());
            modelBuilder.Configurations.Add(new AdminMap());
            modelBuilder.Configurations.Add(new MemberMap());
            modelBuilder.Configurations.Add(new AppointmentMap());
            modelBuilder.Configurations.Add(new AppointmentTimeMap());
            modelBuilder.Configurations.Add(new MedicineMap());
            modelBuilder.Configurations.Add(new CityMap());
            modelBuilder.Configurations.Add(new CountyMap());
        }
    }
}

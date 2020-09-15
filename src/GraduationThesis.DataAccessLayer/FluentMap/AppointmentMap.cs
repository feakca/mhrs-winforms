using GraduationThesis.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraduationThesis.DataAccessLayer.FluentMap
{
    public class AppointmentMap : EntityTypeConfiguration<Appointment>
    {
        public AppointmentMap()
        {
            #region table
            this.ToTable("Appointment");
            this.HasKey(I => I.Id);
            #endregion

            #region property
            this.Property(I => I.Id)
                .HasColumnName("Id")
                .HasColumnOrder(0)
                .HasColumnType("uniqueidentifier");
            this.Property(I => I.Time)
                .HasColumnName("Time")
                .HasColumnOrder(1)
                .HasColumnType("smalldatetime")
                .IsRequired();
            this.Property(I => I.MemberId)
                .HasColumnName("MemberId")
                .HasColumnOrder(2)
                .HasColumnType("uniqueidentifier");
            this.Property(I => I.DoctorId)
                .HasColumnName("DoctorId")
                .HasColumnOrder(3)
                .HasColumnType("uniqueidentifier");
            this.Property(I => I.HospitalId)
                .HasColumnName("HospitalId")
                .HasColumnOrder(4)
                .HasColumnType("uniqueidentifier");
            this.Property(I => I.Description)
                .HasColumnName("Description")
                .HasColumnOrder(5)
                .HasColumnType("nvarchar(MAX)")
                .IsOptional();
            this.Property(I => I.State)
                .HasColumnName("State")
                .HasColumnOrder(6)
                .IsRequired();
            this.Property(I => I.CreateTime)
                .HasColumnName("CreateTime")
                .HasColumnOrder(7)
                .HasColumnType("datetime")
                .IsRequired();
            this.Property(I => I.UpdateTime)
                .HasColumnName("UpdateTime")
                .HasColumnOrder(8)
                .HasColumnType("datetime")
                .IsOptional();
            this.Property(I => I.DeleteTime)
                .HasColumnName("DeleteTime")
                .HasColumnOrder(9)
                .HasColumnType("datetime")
                .IsOptional();
            this.Property(I => I.IsActive)
                .HasColumnName("IsActive")
                .HasColumnOrder(10)
                .HasColumnType("bit")
                .IsRequired();
            #endregion

            #region relation
            this.HasRequired(I => I.Member)
                .WithMany(I => I.Appointments)
                .HasForeignKey(I => I.MemberId)
                .WillCascadeOnDelete(false);
            this.HasRequired(I => I.Doctor)
                .WithMany(I => I.Appointments)
                .HasForeignKey(I => I.DoctorId)
                .WillCascadeOnDelete(false);
            this.HasRequired(I => I.Hospital)
                .WithMany(I => I.Appointments)
                .HasForeignKey(I => I.HospitalId)
                .WillCascadeOnDelete(false);
            this.HasMany(I => I.Medicines)
                .WithMany(I => I.Appointments)
                .Map(I =>
                {
                    I.MapLeftKey("AppointmentId");
                    I.MapRightKey("MedicineId");
                    I.ToTable("Prescription");
                });
            #endregion
        }
    }
}

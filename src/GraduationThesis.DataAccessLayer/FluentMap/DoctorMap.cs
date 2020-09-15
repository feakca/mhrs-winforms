using GraduationThesis.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraduationThesis.DataAccessLayer.FluentMap
{
    public class DoctorMap : EntityTypeConfiguration<Doctor>
    {
        public DoctorMap()
        {
            #region table
            this.ToTable("Doctor");
            this.HasKey(I => I.Id);
            //this.HasIndex(I => I.Ssn).IsUnique();
            //this.HasIndex(I => I.Phone).IsUnique();
            //this.HasIndex(I => I.Mail).IsUnique();
            this.Ignore(I => I.Age);
            #endregion

            #region property
            this.Property(I => I.Id)
                .HasColumnName("Id")
                .HasColumnOrder(0)
                .HasColumnType("uniqueidentifier");
            this.Property(I => I.Ssn)
                .HasColumnName("Ssn")
                .HasColumnOrder(1)
                .HasColumnType("nvarchar")
                .HasMaxLength(11)
                .IsRequired();
            this.Property(I => I.Appellation)
                .HasColumnName("Appellation")
                .HasColumnOrder(2)
                .IsRequired();
            this.Property(I => I.Expertise)
                .HasColumnName("Expertise")
                .HasColumnOrder(3)
                .IsRequired();
            this.Property(I => I.AgeRange)
                .HasColumnName("AgeRange")
                .HasColumnOrder(4)
                .IsRequired();
            this.Property(I => I.Name)
                .HasColumnName("Name")
                .HasColumnOrder(5)
                .HasColumnType("nvarchar")
                .HasMaxLength(30)
                .IsRequired();
            this.Property(I => I.Surname)
                .HasColumnName("Surname")
                .HasColumnOrder(6)
                .HasColumnType("nvarchar")
                .HasMaxLength(30)
                .IsRequired();
            this.Property(I => I.Birthday)
                .HasColumnName("Birthday")
                .HasColumnOrder(7)
                .HasColumnType("date")
                .IsRequired();
            this.Property(I => I.Phone)
                .HasColumnName("Phone")
                .HasColumnOrder(8)
                .HasColumnType("nvarchar")
                .HasMaxLength(19)
                .IsOptional();
            this.Property(I => I.Mail)
                .HasColumnName("Mail")
                .HasColumnOrder(9)
                .HasColumnType("nvarchar")
                .HasMaxLength(60)
                .IsOptional();
            this.Property(I => I.City)
                .HasColumnName("City")
                .HasColumnOrder(10)
                .HasColumnType("nvarchar")
                .HasMaxLength(255)
                .IsOptional();
            this.Property(I => I.County)
                .HasColumnName("County")
                .HasColumnOrder(11)
                .HasColumnType("nvarchar")
                .HasMaxLength(255)
                .IsOptional();
            this.Property(I => I.Picture)
                .HasColumnName("Picture")
                .HasColumnOrder(12)
                .HasColumnType("varbinary(MAX)")
                .IsRequired();
            this.Property(I => I.Password)
                .HasColumnName("Password")
                .HasColumnOrder(13)
                .HasColumnType("nvarchar")
                .HasMaxLength(128)
                .IsRequired();
            this.Property(I => I.CreateTime)
                .HasColumnName("CreateTime")
                .HasColumnOrder(14)
                .HasColumnType("datetime")
                .IsRequired();
            this.Property(I => I.UpdateTime)
                .HasColumnName("UpdateTime")
                .HasColumnOrder(15)
                .HasColumnType("datetime")
                .IsOptional();
            this.Property(I => I.DeleteTime)
                .HasColumnName("DeleteTime")
                .HasColumnOrder(16)
                .HasColumnType("datetime")
                .IsOptional();
            this.Property(I => I.IsActive)
                .HasColumnName("IsActive")
                .HasColumnOrder(17)
                .HasColumnType("bit")
                .IsRequired();
            this.Property(I => I.HospitalId)
                .HasColumnName("HospitalId")
                .HasColumnOrder(18)
                .HasColumnType("uniqueidentifier");
            #endregion

            #region relation
            //1-N
            this.HasRequired(I => I.Hospital)
                .WithMany(I => I.Doctors)
                .HasForeignKey(I => I.HospitalId)
                .WillCascadeOnDelete(false);
            #endregion
        }
    }
}

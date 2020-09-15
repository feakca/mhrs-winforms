using GraduationThesis.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraduationThesis.DataAccessLayer.FluentMap
{
    public class HospitalMap : EntityTypeConfiguration<Hospital>
    {
        public HospitalMap()
        {
            #region table
            this.ToTable("Hospital");
            this.HasKey(I => I.Id);
            //this.HasIndex(I => I.Name).IsUnique();
            //this.HasIndex(I => I.PhoneI).IsUnique();
            //this.HasIndex(I => I.PhoneII).IsUnique();
            //this.HasIndex(I => I.PhoneIII).IsUnique();
            //this.HasIndex(I => I.Mail).IsUnique();
            //this.HasIndex(I => I.Address).IsUnique();
            #endregion

            #region property
            this.Property(I => I.Id)
                .HasColumnName("Id")
                .HasColumnOrder(0)
                .HasColumnType("uniqueidentifier");
            this.Property(I => I.Name)
                .HasColumnName("Name")
                .HasColumnOrder(1)
                .HasColumnType("nvarchar")
                .HasMaxLength(40)
                .IsRequired();
            this.Property(I => I.NumberOfBed)
                .HasColumnName("NumberOfBed")
                .HasColumnOrder(2)
                .HasColumnType("int")
                .IsOptional();
            this.Property(I => I.PhoneI)
                .HasColumnName("PhoneI")
                .HasColumnOrder(3)
                .HasColumnType("nvarchar")
                .HasMaxLength(19)
                .IsOptional();
            this.Property(I => I.PhoneII)
                .HasColumnName("PhoneII")
                .HasColumnOrder(4)
                .HasColumnType("nvarchar")
                .HasMaxLength(19)
                .IsOptional();
            this.Property(I => I.PhoneIII)
                .HasColumnName("PhoneIII")
                .HasColumnOrder(5)
                .HasColumnType("nvarchar")
                .HasMaxLength(19)
                .IsOptional();
            this.Property(I => I.Mail)
                .HasColumnName("Mail")
                .HasColumnOrder(6)
                .HasColumnType("nvarchar")
                .HasMaxLength(40)
                .IsOptional();
            this.Property(I => I.Website)
                .HasColumnName("Website")
                .HasColumnOrder(7)
                .HasColumnType("nvarchar")
                .HasMaxLength(40)
                .IsOptional();
            this.Property(I => I.City)
                .HasColumnName("City")
                .HasColumnOrder(8)
                .HasColumnType("nvarchar")
                .HasMaxLength(255)
                .IsRequired();
            this.Property(I => I.County)
                .HasColumnName("County")
                .HasColumnOrder(9)
                .HasColumnType("nvarchar")
                .HasMaxLength(255)
                .IsRequired();
            this.Property(I => I.Address)
                .HasColumnName("Address")
                .HasColumnOrder(10)
                .HasColumnType("nvarchar")
                .HasMaxLength(500)
                .IsOptional();
            this.Property(I => I.Picture)
                .HasColumnName("Picture")
                .HasColumnOrder(11)
                .HasColumnType("varbinary(MAX)")
                .IsRequired();
            this.Property(I => I.CreateTime)
                .HasColumnName("CreateTime")
                .HasColumnOrder(12)
                .HasColumnType("datetime")
                .IsRequired();
            this.Property(I => I.UpdateTime)
                .HasColumnName("UpdateTime")
                .HasColumnOrder(13)
                .HasColumnType("datetime")
                .IsOptional();
            this.Property(I => I.DeleteTime)
                .HasColumnName("DeleteTime")
                .HasColumnOrder(14)
                .HasColumnType("datetime")
                .IsOptional();
            this.Property(I => I.IsActive)
                .HasColumnName("IsActive")
                .HasColumnOrder(15)
                .HasColumnType("bit")
                .IsRequired();
            #endregion

            #region relation

            #endregion
        }
    }
}

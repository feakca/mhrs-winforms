﻿using GraduationThesis.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraduationThesis.DataAccessLayer.FluentMap
{
    public class MemberMap : EntityTypeConfiguration<Member>
    {
        public MemberMap()
        {
            #region table
            this.ToTable("Member");
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
            this.Property(I => I.Name)
                .HasColumnName("Name")
                .HasColumnOrder(2)
                .HasColumnType("nvarchar")
                .HasMaxLength(30)
                .IsRequired();
            this.Property(I => I.Surname)
                .HasColumnName("Surname")
                .HasColumnOrder(3)
                .HasColumnType("nvarchar")
                .HasMaxLength(30)
                .IsRequired();
            this.Property(I => I.Gender)
                .HasColumnName("Gender")
                .HasColumnOrder(4)
                .IsRequired();
            this.Property(I => I.Birthday)
                .HasColumnName("Birthday")
                .HasColumnOrder(5)
                .HasColumnType("date")
                .IsRequired();
            this.Property(I => I.Height)
                .HasColumnName("Height")
                .HasColumnOrder(6)
                .HasColumnType("int")
                .IsOptional();
            this.Property(I => I.Weight)
                .HasColumnName("Weight")
                .HasColumnOrder(7)
                .HasColumnType("float")
                .IsOptional();
            this.Property(I => I.DoesSmoke)
                .HasColumnName("DoesSmoke")
                .HasColumnOrder(8)
                .HasColumnType("bit")
                .IsOptional();
            this.Property(I => I.Phone)
                .HasColumnName("Phone")
                .HasColumnOrder(9)
                .HasColumnType("nvarchar")
                .HasMaxLength(19)
                .IsOptional();
            this.Property(I => I.Mail)
                .HasColumnName("Mail")
                .HasColumnOrder(10)
                .HasColumnType("nvarchar")
                .HasMaxLength(60)
                .IsOptional();
            this.Property(I => I.City)
                .HasColumnName("City")
                .HasColumnOrder(11)
                .HasColumnType("nvarchar")
                .HasMaxLength(255)
                .IsOptional();
            this.Property(I => I.County)
                .HasColumnName("County")
                .HasColumnOrder(12)
                .HasColumnType("nvarchar")
                .HasMaxLength(255)
                .IsOptional();
            this.Property(I => I.Picture)
                .HasColumnName("Picture")
                .HasColumnOrder(13)
                .HasColumnType("varbinary(max)")
                .IsRequired();
            this.Property(I => I.Password)
                .HasColumnName("Password")
                .HasColumnOrder(14)
                .HasColumnType("nvarchar")
                .HasMaxLength(128)
                .IsRequired();
            this.Property(I => I.CreateTime)
                .HasColumnName("CreateTime")
                .HasColumnOrder(15)
                .HasColumnType("datetime")
                .IsRequired();
            this.Property(I => I.UpdateTime)
                .HasColumnName("UpdateTime")
                .HasColumnOrder(16)
                .HasColumnType("datetime")
                .IsOptional();
            this.Property(I => I.DeleteTime)
                .HasColumnName("DeleteTime")
                .HasColumnOrder(17)
                .HasColumnType("datetime")
                .IsOptional();
            this.Property(I => I.IsActive)
                .HasColumnName("IsActive")
                .HasColumnOrder(18)
                .HasColumnType("bit")
                .IsRequired();
            #endregion
        }
    }
}
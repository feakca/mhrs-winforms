using GraduationThesis.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraduationThesis.DataAccessLayer.FluentMap
{
    public class MedicineMap : EntityTypeConfiguration<Medicine>
    {
        public MedicineMap()
        {
            #region table
            this.ToTable("Medicine");
            this.HasKey(I => I.Id);
            //this.HasIndex(I => I.Name).IsUnique();
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
                .HasMaxLength(50)
                .IsRequired();
            this.Property(I => I.Type)
                .HasColumnName("Type")
                .HasColumnOrder(2)
                .IsRequired();
            this.Property(I => I.Description)
                .HasColumnName("Description")
                .HasColumnOrder(3)
                .HasColumnType("nvarchar(MAX)")
                .IsOptional();
            this.Property(I => I.Ssi)
                .HasColumnName("Ssi")
                .HasColumnOrder(4)
                .HasColumnType("bit")
                .IsOptional();
            this.Property(I => I.CreateTime)
                .HasColumnName("CreateTime")
                .HasColumnOrder(5)
                .HasColumnType("datetime")
                .IsRequired();
            this.Property(I => I.UpdateTime)
                .HasColumnName("UpdateTime")
                .HasColumnOrder(6)
                .HasColumnType("datetime")
                .IsOptional();
            this.Property(I => I.DeleteTime)
                .HasColumnName("DeleteTime")
                .HasColumnOrder(7)
                .HasColumnType("datetime")
                .IsOptional();
            this.Property(I => I.IsActive)
                .HasColumnName("IsActive")
                .HasColumnOrder(8)
                .HasColumnType("bit")
                .IsRequired();
            #endregion
        }
    }
}

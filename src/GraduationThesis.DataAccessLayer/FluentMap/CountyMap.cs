using GraduationThesis.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraduationThesis.DataAccessLayer.FluentMap
{
    public class CountyMap : EntityTypeConfiguration<County>
    {
        public CountyMap()
        {
            #region table
            this.ToTable("County");
            this.HasKey(I => I.Id);
            #endregion

            #region property
            this.Property(I => I.Id)
                .HasColumnName("Id")
                .HasColumnOrder(0)
                .HasColumnType("int");
            this.Property(I => I.Name)
                .HasColumnName("Name")
                .HasColumnOrder(1)
                .HasColumnType("nvarchar")
                .HasMaxLength(255)
                .IsRequired();
            this.Property(I => I.CityId)
                .HasColumnName("CityId")
                .HasColumnOrder(2)
                .HasColumnType("int");
            #endregion

            #region relation
            this.HasRequired(I => I.City)
                .WithMany(I => I.Counties)
                .HasForeignKey(I => I.CityId)
                .WillCascadeOnDelete(false);
            #endregion
        }
    }
}

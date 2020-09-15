using GraduationThesis.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraduationThesis.DataAccessLayer.FluentMap
{
    public class CityMap : EntityTypeConfiguration<City>
    {
        public CityMap()
        {
            #region table
            this.ToTable("City");
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
            #endregion
        }
    }
}

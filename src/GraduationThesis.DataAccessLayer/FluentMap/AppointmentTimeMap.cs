using GraduationThesis.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraduationThesis.DataAccessLayer.FluentMap
{
    public class AppointmentTimeMap : EntityTypeConfiguration<AppointmentTime>
    {
        public AppointmentTimeMap()
        {
            #region table
            this.ToTable("AppointmentTime");
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
                .HasColumnType("time")
                .IsRequired();
            #endregion
        }
    }
}

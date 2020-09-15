using GraduationThesis.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraduationThesis.DataAccessLayer.FluentMap
{
    public class AdminMap : EntityTypeConfiguration<Admin>
    {
        public AdminMap()
        {
            #region table
            this.ToTable("Admin");
            this.HasKey(I => I.Id);
            //this.HasIndex(I => I.UserName).IsUnique();
            #endregion

            #region property
            this.Property(I => I.Id)
                .HasColumnName("Id")
                .HasColumnOrder(0)
                .HasColumnType("uniqueidentifier");
            this.Property(I => I.UserName)
                .HasColumnName("UserName")
                .HasColumnOrder(1)
                .HasColumnType("nvarchar")
                .HasMaxLength(11)
                .IsRequired();
            this.Property(I => I.Password)
                .HasColumnName("Password")
                .HasColumnOrder(2)
                .HasColumnType("nvarchar")
                .HasMaxLength(128)
                .IsRequired();
            #endregion
        }
    }
}

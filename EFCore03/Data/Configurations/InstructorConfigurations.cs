using EFCore03.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore03.Data.Configurations
{
    internal class InstructorConfigurations : IEntityTypeConfiguration<Instructor>
    {
        public void Configure(EntityTypeBuilder<Instructor> builder)
        {
            builder
                .HasKey(I => I.ID);
            builder
                .Property(I => I.ID).UseIdentityColumn(1, 1);
            builder
                .Property(I => I.Name).HasColumnType("varchar").HasMaxLength(11).IsRequired();
            builder
                .Property(I => I.HourRate).HasDefaultValue(20.0m).IsRequired().HasPrecision(10, 2);
            builder
               .Property(S => S.Address).HasColumnType("varchar").HasMaxLength(50);
            builder
                .Property(I => I.Salary).IsRequired().HasDefaultValue(3000);
            builder
                .Property(I => I.Bouns).IsRequired(false);
        }
    }
}

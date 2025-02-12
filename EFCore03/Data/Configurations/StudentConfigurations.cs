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
    internal class StudentConfigurations : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder
                .HasKey(S => S.ID);
            builder
                .Property(S => S.ID).UseIdentityColumn(1, 1);
            builder
                .Property(S => S.FName).HasColumnType("varchar").HasMaxLength(11).IsRequired();
            builder
                .Property(S => S.LName).HasColumnType("varchar").HasMaxLength(11).IsRequired();
            builder
                .Property(S => S.Address).HasColumnType("varchar").HasMaxLength(50);


        }
    }
}

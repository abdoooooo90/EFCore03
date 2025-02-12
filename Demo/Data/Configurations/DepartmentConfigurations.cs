using Demo.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Data.Configurations
{
    internal class DepartmentConfigurations : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder
                .HasKey(D => D.DeptId);
            builder
                .Property(p => p.DeptId).UseIdentityColumn(10, 10);
            builder
                .Property(p => p.Name)
                .HasColumnName("DepartmentName").HasColumnType("varchar").HasMaxLength(50);

            builder
                .Property(p => p.CreationDate)
                .HasDefaultValueSql("GETDATE()");
        }
    }
}

using EFCore03.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore03.Data.Configurations
{
    internal class Course_InstConfigurations : IEntityTypeConfiguration<Course_Inst>
    {
        public void Configure(EntityTypeBuilder<Course_Inst> builder)
        {
            builder.HasKey(ci=> new {ci.Course_ID, ci.Inst_ID});
        }
    }
}

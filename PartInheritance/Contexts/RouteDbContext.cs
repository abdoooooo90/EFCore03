using Microsoft.EntityFrameworkCore;
using PartInheritance.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartInheritance.Contexts
{
    internal class RouteDbContext : DbContext
    {
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Server = .; Database = RouteG03; Trusted_Connection = True; trustservercertificate = true;");
        //}
        //public DbSet<FullTimeEmployee> FulltimeEmployees { get; set; }
        //public DbSet<PartTimeEmployee> PartTimeEmployees { get; set; }
    }
}

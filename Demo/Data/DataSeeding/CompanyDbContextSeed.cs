using Demo.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Demo.Data.DataSeeding
{
    internal class CompanyDbContextSeed
    {
        public static void Seed(CompanyDbContext dbContext)
        {
            #region Department
            if (!dbContext.Departments.Any())
            {
                var departmentsData = File.ReadAllText("C:\\Users\\abdos\\OneDrive\\Desktop\\.net\\C#\\EFCore\\EFCore03\\Demo\\Data\\DataSeeding\\departments.json");
                var departments = JsonSerializer.Deserialize<List<Department>>(departmentsData);
                if (departments?.Count > 0)
                {
                    foreach (var department in departments)
                        dbContext.Departments.Add(department);
                    dbContext.SaveChanges();
                }
            }
            #endregion
            #region Employee
            if (!dbContext.Employees.Any())
            {
                var employeesData = File.ReadAllText("C:\\Users\\abdos\\OneDrive\\Desktop\\.net\\C#\\EFCore\\EFCore03\\Demo\\Data\\DataSeeding\\employees.json");
                var employees = JsonSerializer.Deserialize<List<Employee>>(employeesData);
                if (employees?.Count > 0)
                {
                    foreach (var employee in employees)
                        dbContext.Employees.Add(employee);
                    dbContext.SaveChanges();
                }
            }
            #endregion
        }
    }
}

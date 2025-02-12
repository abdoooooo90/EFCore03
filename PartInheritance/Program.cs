using Microsoft.EntityFrameworkCore.Diagnostics;
using PartInheritance.Contexts;
using PartInheritance.Entities;

namespace PartInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //using RouteDbContext dbContext = new RouteDbContext();
            //FullTimeEmployee fullTimeEmployee = new FullTimeEmployee()
            //{
            //    Name = "Abdelfatah",
            //    Salary = 20000,
            //    Age = 20,
            //    StartDate = DateTime.Now,
            //    Address = "Mansoura"
            //};
            //PartTimeEmployee partTimeEmployee = new PartTimeEmployee()
            //{
            //    Name = "Mohamed",
            //    HourRate = 100,
            //    Age = 20,
            //    CountIfHours = 2000,
            //    Address = "Mansoura"
            //};
            ////dbContext.FulltimeEmployees.Add(fullTimeEmployee);
            ////dbContext.PartTimeEmployees.Add(partTimeEmployee);
            ////dbContext.SaveChanges();
            //var FTE = from F in dbContext.FulltimeEmployees
            //          select F;
            //var PTE = from p in dbContext.PartTimeEmployees
            //          select p;
            //foreach (var employee in FTE)
            //    Console.WriteLine($"{employee.Name}-------{employee.Salary}");
            //Console.WriteLine("=======================");
            //foreach (var employee in PTE)
            //    Console.WriteLine($"{employee.Name}-------{employee.HourRate}");
        }
    }
}

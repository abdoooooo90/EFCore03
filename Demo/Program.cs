using Demo.Data;
using Demo.Data.DataSeeding;
using Demo.Data.Models;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using CompanyDbContext dbContext = new CompanyDbContext();
            //CompanyDbContextSeed.Seed(dbContext); // DataSeeding
            #region Navigational Properities
            #region Example01
            //var employee = (from E in dbContext.Employees
            //                where E.Code == 7
            //                select E).FirstOrDefault();
            //Console.WriteLine($"EmpName: {employee.Name}, Department: {employee.Department?.Name??"Not Found"}");
            #endregion

            #region Example 02
            //var department = (from D in dbContext.Departments
            //                  where D.DeptId == 10
            //                  select D).FirstOrDefault();
            //if(department is not null)
            //{
            //    Console.WriteLine($"DepartmentId: {department.DeptId}, DepartmentName: {department.Name}");
            //    foreach(var emp in department.Employee)
            //    {
            //        Console.WriteLine($"EmpCode = {emp.Code}, EmpName = {emp.Name}");
            //    }
            //}
            #endregion
            #endregion

            #region Explicict Loading
            #region Example01
            //var employee = (from E in dbContext.Employees
            //                where E.Code == 7
            //                select E).FirstOrDefault();
            //if (employee is not null)
            //{
            //    dbContext.Entry(employee).Reference(nameof(Employee.Department)).Load();
            //    Console.WriteLine($"EmpName: {employee.Name}, Department: {employee.Department.Name}");
            //}
            #endregion

            #region Example 02
            //var department = (from D in dbContext.Departments
            //                  where D.DeptId == 10
            //                  select D).FirstOrDefault();
            //if (department is not null)
            //{
            //    Console.WriteLine($"DepartmentId: {department.DeptId}, DepartmentName: {department.Name}");
            //    dbContext.Entry(department).Collection(nameof(Department.Employee)).Load();
            //    foreach (var emp in department.Employee)
            //    {
            //        Console.WriteLine($"EmpCode = {emp.Code}, EmpName = {emp.Name}");
            //    }
            //}
            #endregion
            #endregion

            #region Lazy Loading
            #region Example01
            //var employee = (from E in dbContext.Employees
            //                where E.Code == 7
            //                select E).FirstOrDefault();
            //Console.WriteLine($"EmpName: {employee.Name}, Department: {employee.Department?.Name ?? "Not Found"}");
            #endregion

            #region Example 02
            //var department = (from D in dbContext.Departments
            //                  where D.DeptId == 10
            //                  select D).FirstOrDefault();
            //if (department is not null)
            //{
            //    Console.WriteLine($"DepartmentId: {department.DeptId}, DepartmentName: {department.Name}");
            //    foreach (var emp in department.Employee)
            //    {
            //        Console.WriteLine($"EmpCode = {emp.Code}, EmpName = {emp.Name}");
            //    }
            //}
            #endregion
            #endregion



        }
    }
}

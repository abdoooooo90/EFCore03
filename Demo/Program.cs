using Demo.Data;
using Demo.Data.DataSeeding;
using Demo.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //using CompanyDbContext dbContext = new CompanyDbContext();
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

            #region EFCore04
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

            #region Eger Loading
            #region Example01
            //var employee = (from E in dbContext.Employees.Include(e => e.Department)
            //                where E.Code == 7
            //                select E).FirstOrDefault();
            //Console.WriteLine($"EmpName: {employee.Name}, Department: {employee.Department?.Name ?? "Not Found"}");
            #endregion

            #region Example 02
            //var department = (from D in dbContext.Departments.Include(d => d.Employee)
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

            #region Join
            //var Result = (from E in dbContext.Employees
            //              join D in dbContext.Departments
            //              on E.DepartmentDeptId equals D.DeptId
            //              select new
            //              {
            //                  D.DeptId,
            //                  D.Name,
            //                  EmployeeName=E.Name,
            //                  E.Code

            //              });
            //// Employess (Outer), Departments (inner)
            //Result = dbContext.Employees.Join(dbContext.Departments,
            //    E => E.DepartmentDeptId,  // Fk Outer
            //    D => D.DeptId,  // PK Inner
            //    (E, D) => new
            //    {
            //        D.DeptId,
            //        D.Name,
            //        EmployeeName = E.Name,
            //        E.Code
            //    });
            //foreach(var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Group Join
            //// Group => outer (Departments)
            //var Result = dbContext.Departments.GroupJoin(dbContext.Employees,
            //    D => D.DeptId,
            //    E => E.DepartmentDeptId,
            //   (D, E) => new
            //   {
            //       Department = D,
            //       Employee = E

            //   }).Where(X => X.Employee.Count() > 0);

            //Result = (from D in dbContext.Departments
            //          join E in dbContext.Employees
            //          on D.DeptId equals E.DepartmentDeptId
            //          into EmployeesInDept
            //          select new
            //          {
            //              Department = D
            //              ,
            //              Employee = EmployeesInDept
            //          }).Where(X => X.Employee.Count() > 0);
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item.Department.Name);
            //    foreach(var employee in item.Employee)
            //    {
            //        Console.WriteLine("*******" + employee.Name);
            //    }
            //}


            #endregion

            #region Left Outer Join
            //var Result = dbContext.Departments.GroupJoin(dbContext.Employees,
            //    D => D.DeptId,
            //    E => E.DepartmentDeptId,
            //    (Dept, Emp) => new
            //    {
            //        Dept,
            //        Emp = Emp.DefaultIfEmpty()
            //    }).SelectMany(X => X.Emp, (X, Emp) => new { X.Dept, Emp });

            //var Result01 = from D in dbContext.Departments
            //         join E in dbContext.Employees
            //         on D.DeptId equals E.DepartmentDeptId
            //         into Emp
            //         select new
            //         {
            //             D,
            //             Emp = Emp.DefaultIfEmpty()
            //         }
            //         into X
            //         from E in X.Emp
            //         select new
            //         {
            //             X.D,
            //             E
            //         };
            //foreach (var item in Result01)
            //{
            //    Console.WriteLine($"{item.D.DeptId}, {item.D.Name}, {item.E?.DepartmentDeptId?? 0}, {item.E?.Name?? "No Employee"}");
            //}
            #endregion

            #region Cross Join
            //// Query Syntax
            //var Result = from E in dbContext.Employees
            //             from D in dbContext.Departments
            //             select new
            //             {
            //                 Dpartment = D,
            //                 Employee = E
            //             };
            ////Fluent Syntax
            //Result = dbContext.Employees.SelectMany(
            //    E => dbContext.Departments.Select(
            //        D => new
            //        {
            //            Dpartment = D,
            //            Employee = E
            //        }));
            //foreach (var item in Result)
            //    Console.WriteLine($"{item.Dpartment.Name}, {item.Employee.Name}");
            #endregion
            #endregion

        }
    }
}

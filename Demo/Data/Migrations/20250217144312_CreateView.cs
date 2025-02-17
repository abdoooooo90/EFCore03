using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Demo.Data.Migrations
{
    /// <inheritdoc />
    public partial class CreateView : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"create view EmployeeDepartmentView
                                    with Encryption
                                    as
                                    select E.Code EmployeeId, E.Name EmployeeName, D.DeptId DepartmentId, D.DepartmentName DepartmentName
                                    from Employees E, Departments D
                                    where E.DepartmentDeptId = D.DeptId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("drop view EmployeeDepartmentView");
        }
    }
}

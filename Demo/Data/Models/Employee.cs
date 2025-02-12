using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Data.Models
{
    public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Identity(1, 1)
        public int Code { get; set; }
        [Column(TypeName = "varchar")]
        //[StringLength(50, MinimumLength = 10)]
        [StringLength(50)]
        public string? Name { get; set; }
        [Column(TypeName = "decimal(12, 2)")]
        public double Salary { get; set; }
        [Range(22, 60)]
        [AllowedValues(20, 21, 22, 23)]
        [DeniedValues(10, 15)]
        public int? Age { get; set; }
        //[DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string? EmailAddress { get; set; }
        //[DataType(DataType.PhoneNumber)]
        [Phone]
        public string? Phone { get; set; }
        [DataType(DataType.Password)]
        public string? Password { get; set; }
        #region Work
        //Navigational Property [One]
        [InverseProperty(nameof(Models.Department.Employee))]
        public virtual Department? Department { get; set; }
        [ForeignKey(nameof(Department))]
        public int? DepartmentDeptId { get; set; }
        // Set ForienKey For Department Table

        #endregion

        #region Manage
        [InverseProperty(nameof(Models.Department.Manager))]
        public virtual Department? ManageDepartment {  get; set; }
        #endregion
    }
}

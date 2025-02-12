using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Data.Models
{
    public class Department
    {
        public int DeptId { get; set; }
        public string? Name { get; set; }
        public DateOnly CreationDate { get; set; }
        #region Work
        //Navigational Property [Many]
        [InverseProperty(nameof(Models.Employee.Department))]
        public virtual ICollection<Employee> Employee { get; set; } = new HashSet<Employee>();
        #endregion

        #region Manage
        [InverseProperty(nameof(Models.Employee.ManageDepartment))]
        public virtual Employee Manager { get; set; }
        [ForeignKey(nameof(Manager))]
        public int? ManagerId { get; set; }
        #endregion
    }
}

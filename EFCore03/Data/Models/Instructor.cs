using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore03.Data.Models
{
    internal class Instructor
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int? Bouns { get; set; }
        public int Salary { get; set; }
        public string? Address { get; set; }
        public decimal HourRate { get; set; }
        #region Relations
        //1
        [InverseProperty(nameof(Models.Department.Instructor))]
        public ICollection<Department> departments { get; set; } = new HashSet<Department>();

        //2
        [InverseProperty(nameof(Models.Department.ManaIns))]
        public Department? Manager { get; set; }
        [ForeignKey(nameof(Manager))]
        public int? Dept_ID { get; set; }
        //3. Course_Inst
        [InverseProperty(nameof(Course_Inst.Instructor))]
        public ICollection<Course_Inst> course_Insts { get; set; } = new HashSet<Course_Inst>();
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore03.Data.Models
{
    internal class Student
    {
        public int ID { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Address { get; set; }
        [Range(20, 60)]
        public int? Age { get; set; }
        #region Relations
        //1
        [InverseProperty(nameof(Models.Department.Student))]
        public Department Department { get; set; }
        //set ForeignKey
        [ForeignKey(nameof(Department))]
        public int? Dept_ID { get; set; }
        // 2.StudentCourse
        [InverseProperty(nameof(Models.StudentCourse.Student))]
        public ICollection<StudentCourse> studentCourses { get; set; } = new HashSet<StudentCourse>();
        #endregion

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore03.Data.Models
{
    internal class StudentCourse
    {
        [ForeignKey("Course")]
        public int Course_ID { get; set; }
        [ForeignKey(nameof(Student))]
        public int Stud_ID { get; set; }
        [InverseProperty(nameof(Models.Course.Courses))]
        public Course Course { get; set; }
        [InverseProperty(nameof(Models.Student.studentCourses))]
        public Student Student { get; set; }
        public int Grade { get; set; }
    }
}

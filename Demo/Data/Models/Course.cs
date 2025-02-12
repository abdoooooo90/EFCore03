using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Data.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public virtual ICollection<StudentCourse> StudentCourses{ get; set; } = new HashSet<StudentCourse>();
    }
}

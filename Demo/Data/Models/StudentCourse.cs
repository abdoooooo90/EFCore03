using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Data.Models
{
    public class StudentCourse
    {
        [ForeignKey("Course")]
        public int CourseId { get; set; }
        [ForeignKey(nameof(Student))]
        public int StudentId { get; set; }
        public virtual Course Course { get; set; }
        public virtual Student Student { get; set; }
        public int Grade { get; set; }
    }
}

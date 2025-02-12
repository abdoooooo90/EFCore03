using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore03.Data.Models
{
    internal class Course_Inst
    {
        [InverseProperty(nameof(Course.CouIns))]
        public Course Course { get; set; }
        [ForeignKey(nameof(Course))]
        public int Course_ID { get; set; }
        [InverseProperty(nameof(Instructor.course_Insts))]
        public Instructor Instructor { get; set; }
        [ForeignKey(nameof(Instructor))]
        public int Inst_ID { get; set; }
        public int evaluate {  get; set; }
    }
}

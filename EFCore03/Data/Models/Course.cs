using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace EFCore03.Data.Models
{
    internal class Course
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        
        [Column(TypeName = "time")]
        public TimeSpan? Duration { get; set; }
        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public string Name { get; set; }
        [MaxLength(200)]
        [Column(TypeName = "varchar")]
        public string? Description { get; set; }
        #region Relations
        //1
        [InverseProperty(nameof(Models.Topic.Courses))]
        public Topic Topic { get; set; }
        [ForeignKey(nameof(Topic))]
        public int? Top_ID { get; set; }
        // 2.StudentCourse
        [InverseProperty(nameof(Models.StudentCourse.Course))]
        public ICollection<StudentCourse> Courses { get; set; } = new HashSet<StudentCourse>();
        //3. Course_Inst
        [InverseProperty(nameof(Course_Inst.Course))]
        public ICollection<Course_Inst> CouIns { get; set; } = new HashSet<Course_Inst>();
        #endregion

    }
}

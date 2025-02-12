using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore03.Data.Models
{
    internal class Department
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        [StringLength(50)]
        [Column(TypeName = "varchar")]
        public string Name { get; set; }
        [Required]
        [Column(TypeName = "date")]
        [DefaultValue("2025-02-07")]
        public DateOnly HiringDate { get; set; }
        #region Relations
        //1
        [InverseProperty(nameof(Models.Instructor.departments))]
        public Instructor? Instructor {  get; set; }
        [ForeignKey(nameof(Instructor))]
        public int? Ins_ID { get; set; }
        //2 instructor
        [InverseProperty(nameof(Models.Instructor.Manager))]
        public ICollection<Instructor> ManaIns{ get; set; } = new HashSet<Instructor>();
        
        //3 student
        [InverseProperty(nameof(Models.Student.Department))]
        public ICollection<Student> Student { get; set; } = new HashSet<Student>();
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore03.Data.Models
{
    internal class Topic
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        [StringLength(50)]
        [Column(TypeName = "varchar")]
        public string Name { get; set; }
        //Relations
        [InverseProperty(nameof(Models.Course.Topic))]
        public ICollection<Course> Courses { get; set; } = new HashSet<Course>();

    }
}

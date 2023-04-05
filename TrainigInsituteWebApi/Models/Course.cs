using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrainigInsituteWebApi.Models
{
    public class Course
    {
        public Course()
        {
            this.Skills = new HashSet<Skill>();
        }
        [Key]
        public int CourseId { get; set; }
        [StringLength(75)]
        public string? CourseName { get; set; }

        public virtual ICollection<Skill> Skills { get; set; }


    }
}

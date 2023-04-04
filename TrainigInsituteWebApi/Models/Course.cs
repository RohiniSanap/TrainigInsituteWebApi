using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrainigInsituteWebApi.Models
{
    public class Course
    {
        [Key]
        public int CourseId { get; set; }
        [StringLength(75)]
        public string? CourseName { get; set; }

        [ForeignKey("Skills")]
        public int SkillId { get; set; }
        public virtual Skill? Skills { get; set; }
    }
}

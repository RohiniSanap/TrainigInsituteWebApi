using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrainigInsituteWebApi.Models
{
    public class Skill
    {
        [Key]
        public int SkillId { get; set; }
        [StringLength(70)]
        public string SkillName { get; set; }

        [ForeignKey("Courses")]
        public int CourseId { get; set; }
        public virtual Course? Courses { get; set; }
        [ForeignKey("Trainers")]
        public int TrainerId { get; set; }
        public virtual Trainer? Trainers { get; set; }
    }
}

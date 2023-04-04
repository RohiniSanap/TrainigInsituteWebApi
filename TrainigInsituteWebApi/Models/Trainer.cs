using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrainigInsituteWebApi.Models
{
    public class Trainer
    {
        [Key]
        public int TrainerId { get; set; }
        [StringLength(50)]
        public string TrainerName { get; set; }
        [ForeignKey("Courses")]
        public int CourseId { get; set; }
        public virtual Course? Courses { get; set; }
        [ForeignKey("Skills")]
        public int SkillId { get; set; }
        public virtual Skill? Skills { get; set; }
    }
}

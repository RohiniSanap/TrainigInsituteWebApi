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
      
        public int CourseId { get; set; }
        [ForeignKey("CourseId")]
        public virtual Course? Courses { get; set; }
    }
}

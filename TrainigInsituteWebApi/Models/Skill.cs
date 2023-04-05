using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrainigInsituteWebApi.Models
{
    public class Skill
    {
    public Skill()
        {
            this.Courses = new HashSet<Course>();
        }
      
            
    
    [Key]
        public int SkillId { get; set; }
        [StringLength(70)]
        public string SkillName { get; set; }

    public virtual ICollection<Course> Courses { get; set; }

}
}

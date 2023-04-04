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

    }
}

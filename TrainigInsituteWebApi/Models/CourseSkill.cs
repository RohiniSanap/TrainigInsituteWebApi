﻿using System.ComponentModel.DataAnnotations.Schema;

namespace TrainigInsituteWebApi.Models
{
    public class CourseSkill
    {
       
        public int CourseId { get; set; }
        [ForeignKey("CourseId")]
        public virtual Course? Courses { get; set; }
       
        public int SkillId { get; set; }
        [ForeignKey("SkillId")]
        public virtual Skill? Skills { get; set; }
    }
}
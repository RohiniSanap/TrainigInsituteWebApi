using Microsoft.EntityFrameworkCore;

namespace TrainigInsituteWebApi.Models
{
    public class TrainerDbContext:DbContext
    {
       public TrainerDbContext(DbContextOptions options):base(options) { }
     public    DbSet<Trainer> Trainers { get;set; }
       public  DbSet<Course> Courses { get; set; }
     public   DbSet<Skill> Skills { get; set; }
        public DbSet<CourseSkill> CourseSkills { get; set; }
    }
}

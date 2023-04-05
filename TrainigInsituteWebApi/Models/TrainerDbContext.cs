using Microsoft.EntityFrameworkCore;

namespace TrainigInsituteWebApi.Models
{
    public class TrainerDbContext:DbContext
    {
       public TrainerDbContext(DbContextOptions options):base(options) { }
        DbSet<Trainer> Trainers { get;set; }
        DbSet<Course> Courses { get; set; }
        DbSet<Skill> Skills { get; set; }
    }
}

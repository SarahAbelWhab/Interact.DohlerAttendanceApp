using System;
using DohlerAttendanceApp.Core.Domain;
using DohlerAttendanceApp.DAL.Configuration;
using Microsoft.EntityFrameworkCore;

namespace DohlerAttendanceApp.DAL
{
    public class DohlerDBContext : DbContext
    {
        public DohlerDBContext(DbContextOptions<DohlerDBContext> options):base(options)
        {
        }

        public DbSet<Sector> Sectors { get; set; }
        public DbSet<Survey> Surveys { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<AudienceHistory> AudienceHistories { get; set; }
        public DbSet<TargetAudience> TargetAudiences { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Session> Sessions { get; set; }
        public DbSet<Trainer> Trainers { get; set; }
        public DbSet<TrainingImpact> TrainingImpacts { get; set; }
        public DbSet<Round> Rounds { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AudienceHistoryConfig());
            modelBuilder.ApplyConfiguration(new CategoryConfig());
            modelBuilder.ApplyConfiguration(new CourseConfig());
            modelBuilder.ApplyConfiguration(new DepartmentConfig());
            modelBuilder.ApplyConfiguration(new EmployeeConfig());
            modelBuilder.ApplyConfiguration(new RoundConfig());
            modelBuilder.ApplyConfiguration(new SectorConfig());
            modelBuilder.ApplyConfiguration(new SessionConfig());
            modelBuilder.ApplyConfiguration(new SurveyConfig());
            modelBuilder.ApplyConfiguration(new TargetAudienceConfig());
            modelBuilder.ApplyConfiguration(new TrainerConfig());
            modelBuilder.ApplyConfiguration(new TrainingImpactConfig());
        }
    }
}

using DiemDanhOTP.Core.Domain;
using DiemDanhOTP.Persistence.EntityConfiguration;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
namespace DiemDanhOTP.Persistence
{
    public class DiemDanhDBContext : IdentityDbContext<User>
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Session> Sessions { get; set; }
        public DbSet<SessionDetail> SessionDetails { get; set; }
        public DbSet<Study> Studies { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<GroupSubject> GroupSubjects { get; set; }


        public DiemDanhDBContext(DbContextOptions<DiemDanhDBContext> options)
           : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Adding configs
            builder.ApplyConfiguration(new UserConfiguration());
            builder.ApplyConfiguration(new StudentConfiguration());
            builder.ApplyConfiguration(new SessionConfiguration());
            builder.ApplyConfiguration(new GroupSubjectConfiguration());
            builder.ApplyConfiguration(new TeacherConfiguration());
            builder.ApplyConfiguration(new StudyConfiguration());





        }
    }
}

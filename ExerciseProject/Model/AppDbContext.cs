using ExerciseProject.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciseProject.Repository
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Schedule>(entity =>
            {
                entity.HasKey(e => new { e.ClassId, e.SubjectId });
                
                entity.HasOne(e => e.Class)
                .WithMany(e => e.Schedules);

                entity.HasOne(e => e.Subject)
                .WithMany(e => e.Schedules);
            });

            builder.Entity<Class>(entity =>
            {
                entity.HasKey(e => new { e.Id });
            });

            builder.Entity<Student>(entity =>
            {
                entity.HasKey(e => new { e.Id });
                entity.HasOne(e => e.Class)
                .WithMany(e => e.Students);
            });

            builder.Entity<Subject>(entity =>
            {
                entity.HasKey(e => new { e.Id });
            });
        }
    }
}

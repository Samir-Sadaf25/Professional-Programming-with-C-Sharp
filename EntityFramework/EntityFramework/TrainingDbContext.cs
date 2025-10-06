
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework
{
    public class TrainingDbContext : DbContext 
    {
        private readonly string _connectionString;
        public TrainingDbContext()
        {
            _connectionString = "Server=DESKTOP-3DSR15I;Database=CshrapB21;User Id=cshrapb21;Password=samirsadaf25;Trust Server Certificate = True";
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer(_connectionString);

            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Topic>().ToTable("Topics");
            modelBuilder.Entity<CourseStudent>().ToTable("CourseStudents");
            modelBuilder.Entity<CourseStudent>().HasKey(x => new { x.CourseId, x.StudentId });
            // one to many
            modelBuilder.Entity<Course>().HasMany(x => x.topics)
                .WithOne(x => x.Course).HasForeignKey(x => x.CourseId);

           // many to many relationship
            modelBuilder.Entity<CourseStudent>().HasOne<Course>(x => x.Course)
                .WithMany(x => x.Students).HasForeignKey(x => x.CourseId);
            modelBuilder.Entity<CourseStudent>().HasOne(x => x.Student).WithMany(x => x.Courses).HasForeignKey(x => x.StudentId);

            modelBuilder.Entity<Course>().HasData(new List<Course>() { 
             new Course {Id = -1,Name = "C#", Fees = 8000, ClassStartDate= new DateTime(2025,07,4), },
             new Course {Id = -2,Name = "Dot net", Fees = 30000, ClassStartDate= new DateTime(2026,02,4), }
            });
            
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Student> Student { get; set; }
        public DbSet<Course> Courses { get; set; }

    }
}

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfPractice
{
     public class SchoolContext : DbContext
    {
        private readonly string _connectionString;
        public SchoolContext()
        {
            _connectionString = "Server=DESKTOP-3DSR15I;Database=CourseManagement;User Id=Courses;Password=samirsadaf25;Trust Server Certificate = True";
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer(_connectionString);

            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           

            base.OnModelCreating(modelBuilder);
        }

    }
}

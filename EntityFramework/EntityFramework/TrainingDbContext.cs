
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

        public DbSet<Student> Student { get; set; }
    }
}

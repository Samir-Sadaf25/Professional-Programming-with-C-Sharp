using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework
{
    public class Topic
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Duration { get; set; }
        public int CourseId { get; set; }// Foreign key to Course
        public Course Course { get; set; }// Navigation property: each Topic belongs to one Course
    }
}

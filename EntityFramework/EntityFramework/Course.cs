using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Fees { get; set; }
        public int CourseId { get; set; }
        public DateTime ClassStartDate { get; set; }
        public List<Topic> topics { get; set; }  // Navigation property: one Course has many Topics

    }
}
/*
 This setup defines a one-to-many relationship:
One Course → many Topics
Each Topic → belongs to one Course
EF Core automatically detects this relationship using:
Course.topics (collection navigation)
Topic.CourseId + Topic.Course (foreign key + reference navigation)
 */
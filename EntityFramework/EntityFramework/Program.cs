using EntityFramework;

TrainingDbContext context = new TrainingDbContext();

Student student1 = new Student
{
    Name = "Sadaf",
    Cgpa = 3.35,
    dateOfBirth = new DateTime(2004, 6, 25)
};

//context.Student.Add(student1);
//context.SaveChanges();

List<Student> students = context.Student.ToList();

//foreach (Student student in students)
//    Console.WriteLine(student.Name);

// Getting items in different ways
//var r1 = context.Student.Where(x => x.Name.Contains("abd")).ToList();
//var r2 = context.Student.Where(x => x.Name.Contains("abd")).FirstOrDefault(); // no error
//var r3 = context.Student.Where(x => x.Name.Contains("abd")).First(); // error when no record found
//var r4 = context.Student.Where(x => x.Name.Contains("abd")).SingleOrDefault(); // error when more than 1 record found
//var r5 = context.Student.Where(x => x.Name.Contains("abd")).Single(); // error when more than 1 or no record found
                                                                      //var r6 = context.Students.Where(x => x.Name.Contains("aza")).LastOrDefault(); // opposite
                                                                      //var r7 = context.Students.Where(x => x.Name.Contains("aza")).Last(); // opposite

// Edited one item
//r2.Name = "abdul";
//context.SaveChanges();

// Deleted one item
//r2 = context.Students.Where(x => x.Name.Contains("abd")).FirstOrDefault();
//context.Remove(r2);
//context.SaveChanges();


#region one to many
Course course = new Course
{
    Name = "Mern",
    Fees = 5500,
    ClassStartDate = new DateTime(2025, 1, 1),
    topics = new List<Topic>
  {
     new Topic
     {
         Name = "Getting Started",
         Duration = 20,
     },
     new Topic
     {
         Name = "Html CSS JS",
         Duration = 80,
     },
     new Topic
     {
         Name = "React",
         Duration = 50,
     }

  }

};
context.Courses.Add(course);
context.SaveChanges();
#endregion
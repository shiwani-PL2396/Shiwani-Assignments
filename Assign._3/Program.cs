using System;
using Assign._3;

class StudentProgram
{
    static void Main()
    {
        Course course = new Course { CourseName = "C# Programming" };

        Student s1 = new Student { ID = 1, Name = "John" };
        Student s2 = new Student { ID = 2, Name = "Emily" };
        Student s3 = new Student { ID = 3, Name = "Steve" };
        Student s4 = new Student { ID = 4, Name = "Diana" };

        s1.EnrollCourse(course);
        s2.EnrollCourse(course);
        s3.EnrollCourse(course);
        s4.EnrollCourse(course); // Should fail (MAX = 3)

        Console.ReadLine();
    }
}

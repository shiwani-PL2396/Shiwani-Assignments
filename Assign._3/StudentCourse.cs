using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign._3
{
    public class Course
    {
        public static int EnrolledCount = 0;
        public const int MAX_AVAILABILITY = 3;
        public string CourseName { get; set; }
    }

    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Course Course { get; set; }

        public void EnrollCourse(Course course)
        {
            if (Course.EnrolledCount >= Course.MAX_AVAILABILITY)
            {
                Console.WriteLine($"Enrollment failed for {Name}. Course is full.");
            }
            else
            {
                Course = course;
                Course.EnrolledCount++;
                Console.WriteLine($"{Name} enrolled successfully in {course.CourseName}");
            }
        }
    }

}

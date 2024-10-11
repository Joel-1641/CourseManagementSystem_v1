using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagementSystem_v1
{
    internal class CourseManager
    {
        public List<Course> courses = new List<Course>();

        public void CreateCourse(string title, string duration, decimal price)
        {

            var courseObj = new Course((courses.Count + 1), title, duration, price);
            courses.Add(courseObj);

        }

        public void ReadCourses()
        {
            Console.WriteLine("--- Courses List ---\n");
            if (courses.Count > 0)
            {
                foreach (var course in courses)
                {
                    Console.WriteLine($"ID: {course.CourseId}, Title: {course.Price}, Duration: {course.Duration}, Price: {course.Price}");
                }
            }
            else
            {
                Console.WriteLine("Course Not Available..");
            }
        }
        public void UpdateCourse(int id, string title, string duration, decimal price)
        {
            var course = courses.Find(c => c.CourseId == id);
            if (course != null)
            {
                course.Title = title;
                course.Duration = duration;
                course.Price = price;
                Console.WriteLine("\nCourse Update Successfully..");
            }
            else
            {
                Console.WriteLine("Course Not Found ..");
            }
        }


    }
}

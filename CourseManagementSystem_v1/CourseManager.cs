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

        public void CreateCourse(string courseId, string title, string duration, decimal price)
        {

            var courseObj = new Course(courseId, title, duration, price);
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
                Console.WriteLine("No Courses available.");
            }
        }
        public void UpdateCourse(string id, string title, string duration, decimal price)
        {
            var course = courses.Find(c => c.CourseId == id);
            if (course != null)
            {
                course.Title = title;
                course.Duration = duration;
                course.Price = price;
                Console.WriteLine("\nCourse Update Successfully.");
            }
            else
            {
                Console.WriteLine("Course Not Found ...");
            }
        }

        public void DeleteCourse(string id)
        {
            var course = courses.Find(c => c.CourseId == id);
            if (course != null)
            {
                courses.Remove(course);
                Console.WriteLine("\nCourse Delete Successfully...");
            }
            else
            {
                Console.WriteLine("Course Not Found ...");
            }
        }

        public decimal ValidateCoursePrice()
        {
            decimal price;
            do
            {
                Console.Write("Enter Course Price: ");
                price = decimal.Parse(Console.ReadLine());
                if (price <= 0)
                {
                    Console.WriteLine("Price must be a positive value.");
                }

            } while (price <= 0);
            return price;
        }



    }
}

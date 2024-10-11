using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagementSystem_v1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var courseManager = new CourseManager();
            bool exit = false;
            while (!exit)
            {
                Console.Clear();
                Console.WriteLine("\n --- Course Management System ---");
                Console.WriteLine("1. Add a Courses");
                Console.WriteLine("2. View All Courses");
                Console.WriteLine("3. Update a Course");
                Console.WriteLine("4. Delete a Course");
                Console.WriteLine("5. Exit");
                Console.Write("Choose an option: ");
                string option = Console.ReadLine();


                switch (option)
                {
                    case "1":

                        Console.Clear();

                        Console.Write("Enter Course ID: ");
                        string courseId = Console.ReadLine();

                        Console.Write("Enter Course Title: ");
                        string title = Console.ReadLine();

                        Console.Write("Enter Course Duration: ");
                        string duration = Console.ReadLine();

                        Console.Write("Enter Course Price: ");
                        decimal price = decimal.Parse(Console.ReadLine());

                        courseManager.CreateCourse(courseId, title, duration, price);
                        Console.WriteLine("Course added successfully.");
                       

                        break;

                    case "2":

                        Console.Clear();

                        courseManager.ReadCourses();

                        break;

                    case "3":

                        Console.Clear();

                        Console.Write("Enter the Course ID to update: ");
                        string courseid = Console.ReadLine();

                        Console.Write("Enter new Title:  ");
                        string newTitle = Console.ReadLine();

                        Console.Write("Enter new Duration:  ");
                        string newDuration = Console.ReadLine();

                        Console.Write("Enter new Price:  ");
                        decimal newPrice = decimal.Parse(Console.ReadLine());

                        courseManager.UpdateCourse(courseid, newTitle, newDuration, newPrice);
                   
                        break;

                    case "4":

                        Console.Clear();

                        Console.Write("Enter CourseId to Delete: ");
                        string CourseId = Console.ReadLine();

                        courseManager.DeleteCourse(CourseId);

                        break;

                    case "5":

                        exit = true;
                        break;

                    default:
                        Console.WriteLine("Invalid Option Please try again.");
                        break;
                };

                if (exit == false)
                {
                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
                }

            }
        }
    }
}

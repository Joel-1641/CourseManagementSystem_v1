using System;
using System.Collections.Generic;
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

                        Console.Write("Enter Course Title: ");
                        string title = Console.ReadLine();

                        Console.Write("Enter Course Duration: ");
                        string duration = Console.ReadLine();

                        Console.Write("Enter Course Price: ");
                        decimal price = decimal.Parse(Console.ReadLine());

                        courseManager.CreateCourse(title, duration, price);

                        break;

                    case "2":

                        Console.Clear();

                        courseManager.ReadCourses();

                        break;

                    case "3":

                        Console.Clear();

                        Console.Write("Enter course ID to update: ");
                        int courseid = int.Parse(Console.ReadLine());

                        Console.Write("Enter Course Title: ");
                        string newTitle = Console.ReadLine();

                        Console.Write("Enter Course Duration: ");
                        string newDuration = Console.ReadLine();

                        decimal newPrice = decimal.Parse(Console.ReadLine());

                        courseManager.UpdateCourse(courseid, newTitle, newDuration, newPrice);

                        break;

                    case "4":

                        Console.Clear();

                        Console.Write("Enter CourseId to Delete: ");
                        int CourseId = int.Parse(Console.ReadLine());

                        courseManager.DeleteCourse(CourseId);

                        break;

                    case "5":

                        exit = true;
                        break;

                    default:
                        Console.WriteLine("Invalid Option Please try again.");
                        break;
                };

                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();

            }
        }
    }
}

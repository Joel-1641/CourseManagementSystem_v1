using System;
using System.Collections.Generic;
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

    }
}

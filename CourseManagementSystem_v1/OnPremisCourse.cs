using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagementSystem_v1
{
        internal class OnPremisCourse : Course
        {
            public string Schedule { get; set; }
            public int ClassRoomCapacity { get; set; }

            public OnPremisCourse(int courseId, string title, string duration, decimal price, string schedule, int classRoomCapacity) : base(courseId, title, duration, price)
            {
                Schedule = schedule;
                ClassRoomCapacity = classRoomCapacity;
            }           
        }
    }


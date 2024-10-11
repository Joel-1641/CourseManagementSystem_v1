﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagementSystem_v1
{
    internal class Course
    {
        private int CourseId { get; set; }
        private string Title { get; set; }
        private string Duration { get; set; }
        private decimal Price { get; set; }

        public Course(int courseId, string title, string duration, decimal price)
        {
            CourseId = courseId;
            Title = title;
            Duration = duration;
            Price = price;
        }

        public override string ToString()
        {
            return $"{CourseId}, Title: {Title}, Duration: {Duration}, Price: {Price}";
        }

    }

}


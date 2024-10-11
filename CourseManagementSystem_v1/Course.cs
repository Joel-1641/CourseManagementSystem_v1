﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagementSystem_v1
{
    public class Course
    {
        public int CourseId { get; set; }
        public string Title { get; set; }
        public string Duration { get; set; }
        public decimal Price { get; set; }

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


﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagementSystem_v1
{

    internal class DigitalCourse : Course
    {
        public string CourseLink { get; set; }
        public int FileSize { get; set; }

        public DigitalCourse(string courseId, string title, string duration, decimal price, string courseLink, int fileSize) : base(courseId, title, duration, price)
        {
            CourseLink = courseLink;
            FileSize = fileSize;
        }

        public override string DisplayCourseInfo()
        {
            return base.DisplayCourseInfo() + $", Link: {CourseLink}, FileSize: {FileSize}";
        }

    }
}


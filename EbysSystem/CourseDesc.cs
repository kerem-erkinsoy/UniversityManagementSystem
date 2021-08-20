using System;
using System.Collections.Generic;
using System.Text;

namespace EbysSystem
{
    class CourseDesc
    {
        private string courseName;
        private int courseId;
        private string courseTitle;
        public string CourseName { get => courseName; set => courseName = value; }
        public int CourseId { get => courseId; set => courseId = value; }
        public string CourseTitle { get => courseTitle; set => courseTitle = value; }
        public CourseDesc(string courseName, int courseId, string courseTitle)
        {
            this.courseName = courseName;
            this.courseId = courseId;
            this.courseTitle = courseTitle;
        }
    }
}

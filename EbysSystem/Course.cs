using System;
using System.Collections.Generic;
using System.Text;

namespace EbysSystem
{
    class Course
    {
        private CourseDesc courseDesc;
        private Location courseLocation;
        private Instructor crsInstructor;
        private Schedule schedule;
        public Schedule Schedule { get => schedule; set => schedule = value; }
        internal CourseDesc CourseDesc { get => courseDesc; set => courseDesc = value; }
        internal Location CourseLocation { get => courseLocation; set => courseLocation = value; }
        internal Instructor CrsInstructor { get => crsInstructor; set => crsInstructor = value; }

        public Course(CourseDesc courseDesc)
        {
            this.CourseDesc = courseDesc;
        }
    }
}

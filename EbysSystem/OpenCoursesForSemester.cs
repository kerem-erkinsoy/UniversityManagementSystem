using System;
using System.Collections.Generic;
using System.Text;

namespace EbysSystem
{
    class OpenCoursesForSemester
    {
        private Dictionary<int,Course> openCourseList;
        public OpenCoursesForSemester()
        {
            openCourseList = new Dictionary<int, Course>();
        }
        public void AddOpenCourse(int id,CourseDesc courseDesc)
        {
            Course course = new Course(courseDesc);
            openCourseList.Add(id, course);
        }
        public Course GetOpenCourse(int id)
        {
            return openCourseList[id];
        }
        public List<Course> GetOpenCourseList()
        {
            List<Course> temp = new List<Course>();
            for(int i = 0; i < openCourseList.Count; i++)
            {
                temp.Add(openCourseList[i]);
            }
            return temp;
        }
    }
}

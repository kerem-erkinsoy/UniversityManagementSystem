using System;
using System.Collections.Generic;
using System.Text;

namespace EbysSystem
{
    class EducationPlan
    {
        private Dictionary<int, List<CourseDesc>> termCourses;
        public EducationPlan()
        {
            termCourses = new Dictionary<int, List<CourseDesc>>();
        }
        public List<CourseDesc> GetTermCourses(int term)
        {
            return termCourses[term];
        }
        public void AddCourseList(int term, List<CourseDesc> courseList)
        {
            termCourses.Add(term, courseList);
        }
    }
}

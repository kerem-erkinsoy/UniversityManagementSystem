using System;
using System.Collections.Generic;
using System.Text;

namespace EbysSystem
{
    class CourseCatalog
    {
        private Dictionary<int, CourseDesc> crsCat;
        public CourseCatalog()
        {
            crsCat = new Dictionary<int, CourseDesc>();
        }
        public void AddCourse(int id, CourseDesc course)
        {
            crsCat.Add(id, course);
        }
        public CourseDesc GetCourse(int id)
        {
            return crsCat[id];
        }
        public void ShowCourses()
        {
            Console.WriteLine("-----------------------------------------------");

            foreach (int item in crsCat.Keys)
            {
                Console.WriteLine(" \nCourse no: " + item + " Course name: " + crsCat[item].CourseName);
            }
        }
        public Dictionary<int,CourseDesc> GetCoureCatalog()
        {
            return crsCat;
        }
        public List<CourseDesc> GetCourseList()
        {
            List<CourseDesc> temp = new List<CourseDesc>();
            for (int i = 1; i < crsCat.Count; i++)
            {
                temp.Add(crsCat[i]);
            }
            return temp;
        }
    }
}

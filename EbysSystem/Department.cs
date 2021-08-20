using System;
using System.Collections.Generic;
using System.Text;

namespace EbysSystem
{
    class Department
    {
        private int departmentId;
        private string departmentName;
        private EducationPlan eduPlan;
        private CourseCatalog crsCat;
        private InstructorCatalog insCat;
        private LocationCatalog locCatalog;
        private OpenCoursesForSemester openCoursesForSemester;
        public int DepartmentId { get => departmentId; set => departmentId = value; }
        public string DepartmentName { get => departmentName; set => departmentName = value; }
        internal EducationPlan EduPlan { get => eduPlan; set => eduPlan = value; }
        public Department(int departmentId, string departmentName, EducationPlan eduPlan, CourseCatalog crsCat,LocationCatalog locCatalog,InstructorCatalog insCat)
        {
            this.departmentId = departmentId;
            this.departmentName = departmentName;
            this.eduPlan = eduPlan;
            this.crsCat = crsCat;
            this.locCatalog = locCatalog;
            this.insCat = insCat;
            openCoursesForSemester = new OpenCoursesForSemester();
        }
        
        public void ShowTermCourses(int term)
        {
            List<CourseDesc> termCourses =  eduPlan.GetTermCourses(term);
            for(int i = 0; i < termCourses.Count; i++)
            {
                Console.WriteLine("Course Id: " +  termCourses[i].CourseId + "\nCourse name: "+ termCourses[i].CourseName);
                Console.WriteLine("------------");
            }
        }
        public void OpenCourse(int courseId)
        {
            CourseDesc crsDec = crsCat.GetCourse(courseId);
            //openCourseList.Add(crs);
            openCoursesForSemester.AddOpenCourse(courseId,crsDec);
            ShowLocationCatalog(locCatalog);
            Console.WriteLine("Please enter Location Id");
            int locId = Convert.ToInt32(Console.ReadLine());
            Location courseLoc = locCatalog.GetLocation(locId);
            Schedule sch = new Schedule();
            Course course = openCoursesForSemester.GetOpenCourse(courseId);
            course.CourseLocation = courseLoc;
            courseLoc.AddCourseInLocation(course);
            sch.GetAvailibleSchedule();
            Console.WriteLine("Please enter schedule Id");
            int scheduleId = Convert.ToInt32(Console.ReadLine());
            courseLoc.AddScheduleToLocation(scheduleId);
            course.Schedule = sch.SetSchedule(scheduleId);
            insCat.ShowInstructors();
            Console.WriteLine("Please enter Instructor");
            int instructorId = Convert.ToInt32(Console.ReadLine());
            Instructor ins = insCat.GetInstructor(instructorId);
            course.CrsInstructor = ins;
        }
        public void ShowLocationCatalog(LocationCatalog locCatalog)
        {
            locCatalog.ShowLocations();
            //Console.WriteLine(locCatalog.GetLocationList());
        }
        public void AddLocationToCourse(int locId)
        {
            Location loc = locCatalog.GetLocation(locId);
        }
    }
}

using System;
using System.Collections.Generic;

namespace EbysSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            CourseDesc crsDesc1 = new CourseDesc("Data Science", 1, "Subject1");
            CourseDesc crsDesc2 = new CourseDesc("Artificial Intelligence",2, "Subject2");
            CourseDesc crsDesc3 = new CourseDesc("Data Science", 3, "Subject3");

            CourseCatalog crsCat = new CourseCatalog();
            crsCat.AddCourse(1, crsDesc1);
            crsCat.AddCourse(2, crsDesc2);
            crsCat.AddCourse(3, crsDesc3);

            LocationCatalog locCat = new LocationCatalog();
            Location loc1 = new Location(1, "Computer Science", "B4");
            Location loc2 = new Location(2, "Computer Science", "B6");
            locCat.AddLocation(1,loc1);
            locCat.AddLocation(2,loc2);

            InstructorCatalog insCat = new InstructorCatalog();
            Instructor ins1 = new Instructor(1, "Kerem", "kerem@b.com");
            Instructor ins2 = new Instructor(2, "Hasan", "hasan@b.com");
            Instructor ins3 = new Instructor(3, "Alp", "alp@b.com");
            insCat.AddInstructor(1,ins1);
            insCat.AddInstructor(2,ins2);
            insCat.AddInstructor(3,ins3);

            EducationPlan eduPlan = new EducationPlan();
            eduPlan.AddCourseList(6, crsCat.GetCourseList());
            Department dep = new Department(1,"CS",eduPlan,crsCat,locCat,insCat);
            Console.Write("Please enter Term: (6 girilmesi gerekiyor) ");
            int termId = Convert.ToInt32(Console.ReadLine());
            dep.ShowTermCourses(termId);

            //Console.WriteLine(dep.GetTermCoursesWithTerm(6));
            Console.Write("Please enter Course Id: ");
            int courseId = Convert.ToInt32(Console.ReadLine());
            dep.OpenCourse(courseId);        
        }
    }
}

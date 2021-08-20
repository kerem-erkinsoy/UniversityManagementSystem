using System;
using System.Collections.Generic;
using System.Text;

namespace EbysSystem
{
    class Location
    {
        private int id;
        private string building;
        private string classroomNo;
        private List<Course> courseInLocation;

        public string Building { get => building; set => building = value; }
        public string ClassroomNo { get => classroomNo; set => classroomNo = value; }
        public int Id { get => id; set => id = value; }

        public Location(int id, string building, string classroomNo)
        {
            this.Id = id;
            this.Building = building;
            this.ClassroomNo = classroomNo;
            courseInLocation = new List<Course>();
        }
        public void AddCourseInLocation(Course crs)
        {
            courseInLocation.Add(crs);
        }
        public void ShowAvailableSchedule()
        {
            // TODO
        }

        public void AddScheduleToLocation(int scheduleId)
        {
            // TODO 
        }
    }
}

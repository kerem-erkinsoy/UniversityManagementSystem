using System;
using System.Collections.Generic;
using System.Text;

namespace EbysSystem
{
    class Schedule
    {
        private int id;
        private DateTime weekDay;
        private DateTime courseHours;
        public int Id { get => id; set => id = value; }
        public DateTime Weekday { get => weekDay; set => weekDay = value; }
        public DateTime Coursehours { get => courseHours; set => courseHours = value; }

        public Schedule()
        {
           // TODO
        }

        public void GetAvailibleSchedule()
        {
            // TODO
        }

        public Schedule SetSchedule(int scheduleid)
        {
            return null;
        }
    }
}

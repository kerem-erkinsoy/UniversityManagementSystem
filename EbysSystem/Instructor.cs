using System;
using System.Collections.Generic;
using System.Text;

namespace EbysSystem
{
    class Instructor
    {
        private int instructorId;
        private string instructorName;
        private string instructorEmail;
        public int InstructorId { get => instructorId; set => instructorId = value; }
        public string InstructorName { get => instructorName; set => instructorName = value; }
        public string InstructorEmail { get => instructorEmail; set => instructorEmail = value; }

        public Instructor(int instructorId, string instructorName, string instructorEmail)
        {
            this.InstructorId = instructorId;
            this.InstructorName = instructorName;
            this.InstructorEmail = instructorEmail;
        }
    }
}

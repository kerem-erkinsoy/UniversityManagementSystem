using System;
using System.Collections.Generic;
using System.Text;

namespace EbysSystem
{
    class InstructorCatalog
    {
        private Dictionary<int, Instructor> insCat;
        public InstructorCatalog()
        {
            insCat = new Dictionary<int, Instructor>();
        }
        public Instructor GetInstructor(int id)
        {
            return insCat[id];
        }
        public void AddInstructor(int id, Instructor instructor)
        {
            insCat.Add(id, instructor);
        }
        public void ShowInstructors()
        {
            Console.WriteLine("-----------------------------------------------");
            foreach (int item in insCat.Keys)
            {
                Console.WriteLine(" \nInstructor no: " +  item + ", Instructor name: " + insCat[item].InstructorName);
            }
        }
    }
}

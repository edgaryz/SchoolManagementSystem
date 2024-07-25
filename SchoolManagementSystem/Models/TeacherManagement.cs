using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Models
{
    public class TeacherManagement
    {
        public List<Teacher> Teachers  { get; set; }

        public void AddTeacher(Teacher teacher)
        {
            Teachers = new List<Teacher> { teacher };
        }

        public void GetAllTeachers()
        {
            foreach (Teacher teacher in Teachers)
            {
                Console.WriteLine($"teacher");
            }
        }
    }
}

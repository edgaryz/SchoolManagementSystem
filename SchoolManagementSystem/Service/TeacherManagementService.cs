using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolManagementSystem.Models;

namespace SchoolManagementSystem.Service
{
    public class TeacherManagementService
    {
        public List<Teacher> Teachers { get; set; } = new List<Teacher>();

        public void AddTeacher(Teacher teacher)
        {
            Teachers.Add(teacher);
        }

        public List<Teacher> GetAllTeachers()
        {
            return Teachers;
        }

        public bool FindTeacher(string firstName, string lastName)
        {
            Teacher teacher = Teachers.Find(x => x.FirstName == firstName && x.LastName == lastName);
            return teacher != null;
        }
    }
}

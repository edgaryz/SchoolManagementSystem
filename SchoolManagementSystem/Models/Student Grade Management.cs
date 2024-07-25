using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Models
{
    public class Student_Grade_Management
    {
        public void AddGrade(Student student, Teacher teacher, Grade grade)
        {
            student.AddGrade(grade);
            Console.WriteLine($"{teacher.FirstName} {teacher.LastName} has graded {student.Name} {student.SurName} with grade {grade}");
        }

        public void GetTeacherStudentGrades(Teacher teacher)
        {

        }
    }
}
using SchoolManagementSystem.Models;

namespace SchoolManagementSystem.Service
{
    public class StudentGradeManagementService
    {
        public void AddGrade(Student student, Teacher teacher, Grade grade)
        {
            student.AddGrade(grade);
            Console.WriteLine($"{teacher.FirstName} {teacher.LastName} has graded {student.FirstName} {student.LastName} with grade {grade}");
        }

        public void GetTeacherStudentGrades(Teacher teacher)
        {

        }
    }
}
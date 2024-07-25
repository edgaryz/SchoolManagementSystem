using SchoolManagementSystem.Models;

namespace SchoolManagementSystem.Service
{
    public class StudentManagementService
    {
        public List<Student> Students { get; set; }
        public StudentManagementService()
        {
            Students = new List<Student>();
        }

        public void AddStudent(Student student)
        {
            Students.Add(student);
        }

        public void GetAllStudents()
        {
            foreach (Student student in Students)
            {
                Console.WriteLine(student);
            }
        }

        public void GetStudentGrades(Student student)
        {
            foreach(var studentGrade in student.Grades)
            {
                Console.WriteLine(studentGrade);
            }
        }
    }
}

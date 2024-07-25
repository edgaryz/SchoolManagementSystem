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

        public List<Student> GetAllStudents()
        {
            return Students;
        }

        public void GetStudentGrades(Student student)
        {
            foreach(var studentGrade in student.Grades)
            {
                Console.WriteLine(studentGrade);
            }
        }

        public Student FindStudent(string firstName, string lastName)
        {
            Student student = Students.Find(x => x.FirstName == firstName && x.LastName == lastName);
            return student;
        }
    }
}

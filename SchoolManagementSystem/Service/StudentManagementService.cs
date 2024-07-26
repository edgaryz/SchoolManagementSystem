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
            foreach (Student st in Students)
            {
                if (st.FirstName == student.FirstName && st.LastName == student.LastName)
                {
                    Console.WriteLine($"Student with the name {st.FirstName} {st.LastName} already exists!");
                    break;
                } else
                {
                    Students.Add(student);
                    break;
                }
            }
        }

        public List<Student> GetAllStudents()
        {
            foreach (var student in Students)
            {
                Console.WriteLine(student);
            }
            return Students;
        }

        public void GetStudentGrades(Student student)
        {
            foreach (var studentGrade in student.Grades)
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

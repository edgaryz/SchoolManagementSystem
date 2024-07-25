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
            foreach (var teacher in Teachers)
            {
                Console.WriteLine(teacher);
            }
            return Teachers;
        }

        public Teacher FindTeacher(string firstName, string lastName)
        {
            Teacher teacher = Teachers.Find(x => x.FirstName == firstName && x.LastName == lastName);
            return teacher;
        }

        public void AddGrade(Student student, Teacher teacher, Grade grade)
        {
            student.AddGrade(grade);
            Console.WriteLine($"{teacher.FirstName} {teacher.LastName} has graded {student.FirstName} {student.LastName} with grade {grade}");
        }

        public List<Grade> GetTeacherStudentGrades(Teacher teacher, List<Student> gradeList)
        {
            foreach (var grade in gradeList)
            {
                if (grade.Grades == teacher.Subject)
                {

                }
            }

                return gradeList;


        }
    }
}

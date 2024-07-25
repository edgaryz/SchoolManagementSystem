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

        public void AddGrade(Student student, Teacher teacher, int grade)
        {
            string subject = teacher.Subject;
            DateOnly currentDate = DateOnly.FromDateTime(DateTime.Now);
            int gradeValue = grade;
            Grade newGrade = new Grade(subject, currentDate, gradeValue);
            student.AddGrade(newGrade);
            Console.WriteLine($"{teacher.FirstName} {teacher.LastName} has graded {student.FirstName} {student.LastName} with grade {grade}");
        }

        public List<Grade> GetTeacherStudentGrades(Teacher teacher, List<Student> gradeList)
        {
            List<Grade> teacherGrades = new List<Grade>();

            foreach (Student student in gradeList)
            {
                foreach (Grade grade in student.Grades)
                {
                    if (grade.Subject == teacher.Subject)
                    {
                        teacherGrades.Add(grade);
                    }
                }
            }
            return teacherGrades;
        }
    }
}

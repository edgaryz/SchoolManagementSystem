using SchoolManagementSystem.Models;

namespace SchoolManagementSystem.Service
{
    public class TeacherManagementService
    {
        public List<Teacher> Teachers { get; set; } = new List<Teacher>();

        public void AddTeacher(Teacher teacher)
        {
            foreach (Teacher t in Teachers)
            {
                if (t.FirstName == teacher.FirstName && t.LastName == teacher.LastName)
                {
                    Console.WriteLine($"Student with the name {t.FirstName} {t.LastName} already exists!");
                    break;
                }
                else
                {
                    Teachers.Add(teacher);
                    break;
                }
            }
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
            if (grade < 0 || grade > 10)
            {
                Console.WriteLine("Your grade: {grade} cant be lower than 0 or larger than 10");
            } else
            {
                string subject = teacher.Subject;
                DateOnly currentDate = DateOnly.FromDateTime(DateTime.Now);
                int gradeValue = grade;
                Grade newGrade = new Grade(subject, currentDate, gradeValue);
                student.AddGrade(newGrade);
                Console.WriteLine($"{teacher.FirstName} {teacher.LastName} has graded {student.FirstName} {student.LastName} with grade {grade}");
            }
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

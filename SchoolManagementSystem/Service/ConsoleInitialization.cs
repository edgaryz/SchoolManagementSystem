using SchoolManagementSystem.Models;

namespace SchoolManagementSystem.Service
{
    public class ConsoleInitialization
    {
        public void Initialization()
        {
            StudentManagementService _studentManagement = new StudentManagementService();
            TeacherManagementService _teacherManagement = new TeacherManagementService();
            SchoolService _schoolService = new SchoolService(_studentManagement, _teacherManagement);

            Student student1 = new Student("Edgar", "Sokol", 28, 10);
            student1.AddGrade(new Grade("Math", DateOnly.Parse("2024-07-25"), 7));
            student1.AddGrade(new Grade("Russian", DateOnly.Parse("2024-07-24"), 10));

            Student student2 = new Student("Kirill", "Bravin", 33, 10);
            Student student3 = new Student("Harry", "Potter", 11, 10);
            student3.AddGrade(new Grade("Russian", DateOnly.Parse("2024-07-24"), 10));

            _studentManagement.AddStudent(student1);
            _studentManagement.AddStudent(student2);
            _studentManagement.AddStudent(student3);

            _studentManagement.GetAllStudents();
            _studentManagement.GetStudentGrades(student1);

            Teacher teacher1 = new Teacher("Gandalf", "The Grey", "Magic");
            Teacher teacher2 = new Teacher("Albus", "Dumbledore", "Defence Against The Dark Arts");

            _teacherManagement.AddTeacher(teacher1);
            _teacherManagement.AddTeacher(teacher2);

            _teacherManagement.FindTeacher("Gandalf", "The Grey");
            _teacherManagement.GetAllTeachers();

            _teacherManagement.AddGrade(student3, teacher1, 6);
            _studentManagement.GetStudentGrades(student3);
        }
    }
}

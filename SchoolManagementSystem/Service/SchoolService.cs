using SchoolManagementSystem.Models;

namespace SchoolManagementSystem.Service
{
    public class SchoolService
    {
        StudentManagementService _studentManagementService;
        TeacherManagementService _teacherManagementService;

        public SchoolService(StudentManagementService studentManagement, TeacherManagementService teacherManagement)
        {
            _studentManagementService = studentManagement;
            _teacherManagementService = teacherManagement;
        }

        public void AddStudent(Student student)
        {
            _studentManagementService.AddStudent(student);
        }

        public void AddTeacher(Teacher teacher)
        {
            _teacherManagementService.AddTeacher(teacher);
        }

        public void AddGrade(string studentFirstName, string studentLastName, string teacherFirstName, string teacherLastName, Grade grade)
        {
            Student requiredStudent = _studentManagementService.FindStudent(studentFirstName, studentLastName);
            Teacher requiredTeacher = _teacherManagementService.FindTeacher(teacherFirstName, teacherLastName);

            if (requiredStudent != null && requiredTeacher != null)
            {

            }
        }
    }
}

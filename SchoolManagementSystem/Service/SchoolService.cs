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

        public void ShowAllStudents()
        {
            _studentManagementService.GetAllStudents();
        }

        public void ShowAllTeachers() 
        {
            _teacherManagementService.GetAllTeachers();
        }

        public void ShowStudentGrades(Student student)
        {
            _studentManagementService.GetStudentGrades(student);
        }

        public void FindStudent(string firstName, string lastName)
        {
            _studentManagementService.FindStudent(firstName, lastName);
        }

        public void FindTeacher(string firstName, string lastName)
        {
            _teacherManagementService.FindTeacher(firstName, lastName);
        }

        public void AddGrade(Student student, Teacher teacher, int grade)
        {
            _teacherManagementService.AddGrade(student, teacher, grade);
        }

        public void ShowMarksByTeacherOfStudents(Teacher teacher, List<Student> gradeList)
        {
            _teacherManagementService.GetTeacherStudentGrades(teacher, gradeList);
        }
    }
}

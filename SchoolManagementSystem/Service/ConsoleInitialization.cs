using SchoolManagementSystem.Models;

namespace SchoolManagementSystem.Service
{
    public class ConsoleInitialization
    {
        public void Initialization()
        {
            /*StudentManagementService _studentManagement = new StudentManagementService();
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
            _studentManagement.GetStudentGrades(student3);*/

            // Console
            StudentManagementService _studentManagement = new StudentManagementService();
            TeacherManagementService _teacherManagement = new TeacherManagementService();
            SchoolService _schoolService = new SchoolService(_studentManagement, _teacherManagement);

            while (true)
            {
                Console.WriteLine("1. Pridėti mokinį");
                Console.WriteLine("2. Pridėti mokytoją");
                Console.WriteLine("3. Pridėti pažymį");
                Console.WriteLine("4. Peržiūrėti visus mokinius");
                Console.WriteLine("5. Peržiūrėti visus mokytojus");
                Console.WriteLine("6. Peržiūrėti mokinio pažymius");
                Console.WriteLine("0. Išeiti");
                Console.Write("Pasirinkite veiksmą: ");
                string menuChoice = Console.ReadLine();

                try
                {
                    switch (menuChoice)
                    {
                        case "1":
                            Console.Write("Įveskite mokinio vardą: ");
                            string studentFirstName = Console.ReadLine();
                            Console.Write("Įveskite mokinio pavardę: ");
                            string studentLastName = Console.ReadLine();
                            Console.Write("Įveskite mokinio amžių: ");
                            int studentAge = int.Parse(Console.ReadLine());
                            Console.Write("Įveskite mokinio klasę: ");
                            int studentGrade =  int.Parse(Console.ReadLine());
                            _schoolService.AddStudent(new Student(studentFirstName, studentLastName, studentAge, studentGrade));
                            break;
                        case "2":
                            Console.Write("Įveskite mokytojo vardą: ");
                            string teacherFirstName = Console.ReadLine();
                            Console.Write("Įveskite mokytojo pavardę: ");
                            string teacherLastName = Console.ReadLine();
                            Console.Write("Įveskite mokytojo dėstomą dalyką: ");
                            string subject = Console.ReadLine();
                            _schoolService.AddTeacher(new Teacher(teacherFirstName, teacherLastName, subject));
                            break;
                        case "3":
                            Console.Write("Įveskite mokinio vardą: ");
                            studentFirstName = Console.ReadLine();
                            Console.Write("Įveskite mokinio pavardę: ");
                            studentLastName = Console.ReadLine();
                            Console.Write("Įveskite mokytojo vardą: ");
                            teacherFirstName = Console.ReadLine();
                            Console.Write("Įveskite mokytojo pavardę: ");
                            teacherLastName = Console.ReadLine();
                            Console.Write("Įveskite dalyką: ");
                            subject = Console.ReadLine();
                            Console.Write("Įveskite pažymį: ");
                            int gradeValue = int.Parse(Console.ReadLine());
                            DateOnly now = new DateOnly();
                            Grade grade = new Grade(subject, now, gradeValue);
                            Teacher reqTeacher = _teacherManagement.FindTeacher(teacherFirstName, teacherLastName);
                            _schoolService.AddGrade((_studentManagement.FindStudent(studentFirstName, studentLastName)), reqTeacher, gradeValue);
                            break;
                        case "4":
                            _schoolService.ShowAllStudents();
                            break;
                        case "5":
                            _schoolService.ShowAllTeachers();
                            break;
                        case "6":
                            Console.Write("Įveskite mokinio vardą: ");
                            studentFirstName = Console.ReadLine();
                            Console.Write("Įveskite mokinio pavardę: ");
                            studentLastName = Console.ReadLine();
                            Student studentForGrades = new Student();
                            var grades = (_studentManagement.FindStudent(studentFirstName, studentLastName));
                            foreach (var p in grades.Grades)
                            {
                                Console.WriteLine($"{p.Subject}, {p.GradeDate}, {p.GradeValue}");
                            }
                            break;
                        case "0":
                            return;
                        default:
                            Console.WriteLine("Neteisingas pasirinkimas.");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Klaida: {ex.Message}");
                }

                Console.WriteLine();
            }


        }
    }
}

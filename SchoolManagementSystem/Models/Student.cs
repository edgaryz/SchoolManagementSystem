namespace SchoolManagementSystem.Models
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int Grade { get; set; }
        public List<Grade> Grades { get; set; }

        public Student() { }
        public Student(string name, string surName, int age, int grade)
        {
            FirstName = name;
            LastName = surName;
            Age = age;
            Grade = grade;
            Grades = new List<Grade>();
        }

        public string GetStudentInfo()
        {
            return $"Student: {FirstName} {LastName} age {Age} grade {Grade} his grades are {Grades}";
        }

        public void AddGrade(Grade grade)
        {
            Grades.Add(grade);
        }

    }
}

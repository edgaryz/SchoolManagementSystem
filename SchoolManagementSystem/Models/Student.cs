namespace SchoolManagementSystem.Models
{
    public class Student
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public int Age { get; set; }
        public int Grade { get; set; }
        public List<Grade> Grades { get; set; }

        public Student() { }
        public Student(string name, string surName, int age, int grade)
        {
            Name = name;
            SurName = surName;
            Age = age;
            Grade = grade;
            Grades = new List<Grade>();
        }

        public string GetStudentInfo()
        {
            return $"Student: {Name} {SurName} age {Age} grade {Grade} his grades are {Grades}";
        }

        public void AddGrade(Grade grade)
        {
            Grades.Add(grade);
        }

    }
}

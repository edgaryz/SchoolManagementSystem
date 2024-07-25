using static System.Formats.Asn1.AsnWriter;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SchoolManagementSystem.Models
{
    public class Grade
    {
        public string Subject { get; set; }
        public DateOnly GradeDate { get; set; }
        public int GradeValue { get; set; }

        public Grade() { }

        public Grade(string subject, DateOnly gradeDate, int gradeValue)
        {
            Subject = subject;
            GradeDate = gradeDate;
            GradeValue = gradeValue;
        }

        public override string ToString()
        {
            return $"{Subject}: {GradeValue} on {GradeDate.ToShortDateString()}";
        }
    }
}

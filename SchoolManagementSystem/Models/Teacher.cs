﻿namespace SchoolManagementSystem.Models
{
    public class Teacher
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Subject { get; set; }

        public Teacher(string firstName, string lastName, string subject)
        {
            FirstName = firstName;
            LastName = lastName;
            Subject = subject;
        }

        public void GetInfo()
        {
            Console.WriteLine($"Teacher - {FirstName} {LastName} teaches {Subject}");
        }

        public override string ToString()
        {
            return $"{Subject}: {FirstName} {LastName}";
        }
    }
}

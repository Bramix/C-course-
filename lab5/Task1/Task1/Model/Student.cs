using System;

namespace Task1
{
    public class Student : Person
    {
        private int course;
        private string faculty;

        public Student(string firstName, string secondName, DateTime birthDay, string faculty, int course) : base(firstName, secondName, birthDay)
        {
            this.faculty = faculty;
            this.course = course;
        }

        public override void ShowInformation()
        {
            Console.WriteLine("Information about student:");
            Console.WriteLine(ToString());
        }
        
        public override string ToString()
        {
            return $"{base.ToString()}, {nameof(course)}: {course}";
        }
    }
}
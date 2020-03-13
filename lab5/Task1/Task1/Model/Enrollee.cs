using System;

namespace Task1
{
    public class Enrollee : Person
    {
        public Enrollee(string firstName, string secondName, DateTime birthDay) : base(firstName, secondName, birthDay) {}

        public override void ShowInformation()
        {
            Console.WriteLine("Information about enrollee:");
            Console.WriteLine(base.ToString());
        }
        
    }
}
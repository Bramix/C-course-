using System;

namespace Task1
{
    public class Teacher : Person
    {
        private String position;
        private DateTime expirience;
        
        public override void ShowInformation()
        {
            Console.WriteLine("Information about teacher:");
            Console.WriteLine(ToString());
        }
        
        public Teacher(string firstName, string secondName, DateTime birthDay, String position, DateTime expirience) : base(firstName, secondName, birthDay)
        {
            this.position = position;
            this.expirience = expirience;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, {nameof(position)}: {position}, {nameof(expirience)}: {expirience}";
        }
    }
}
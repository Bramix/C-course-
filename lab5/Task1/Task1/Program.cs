using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test for enroleee");
            Person enrolee = new Enrollee("Vladyslav", "Bozhenko", new DateTime(2000, 10, 9));
            enrolee.ShowInformation();
            Console.WriteLine($"Calculated age: {enrolee.CalculateAge()}");
            Console.WriteLine();

            Console.WriteLine("Test for student");
            Person student = new Student("Noname", "NoSecondName", new DateTime(2000, 10, 9), "ElIT",2);
            student.ShowInformation();
            Console.WriteLine($"Calculated age: {student.CalculateAge()}");
            Console.WriteLine();
            
            Console.WriteLine("Test for teacher");
            Person teacher = new Teacher("Teacher", "Teacherov", new DateTime(1990, 1, 1), "Good teacher", new DateTime(2));
            teacher.ShowInformation();
            Console.WriteLine($"Calculated age: {teacher.CalculateAge()}");
            Console.WriteLine();
        }
    }
}
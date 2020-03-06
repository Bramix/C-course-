using System;

namespace Task1
{
    class SomethingUnInterestion
    {
        public int a;
        public int b;
        public int C
        {
            get { return a + b; }
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            SomethingUnInterestion somethingUnInterestion = new SomethingUnInterestion();
            Console.WriteLine("Please, input a");
            somethingUnInterestion.a = int.Parse(Console.ReadLine());
            Console.WriteLine("Please, input b");
            somethingUnInterestion.b = int.Parse(Console.ReadLine());
            var i = somethingUnInterestion.C;
            Console.WriteLine($"Result of a + b = {i}");
        }
    }
}
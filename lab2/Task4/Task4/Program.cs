using System;
using System.Reflection.Metadata;

namespace Task4
{
    class Program
    {
        private static void Exit(string text)
        {
            Console.WriteLine(text);
            Environment.Exit(0);
        }
        public static void Main(string[] args)
        {
            double res = 0, x = 0;
            string key = "";
            try
            {
                Console.WriteLine("Input x");
                x = double.Parse(Console.ReadLine());
                Console.WriteLine("Input a number of the function to calculate");
                key = Console.ReadLine().ToLower();
            }
            catch (FormatException e)
            {
                Exit("Incorrect format of input");
            }
            
            switch (key)
            {
                case "first":
                    res = Math.Sin(x) * Math.Sin(x);
                    break;
                case "second":
                    if (x <= 0) Exit("X should be > 0 for this function");
                    else res = Math.Log10(x) * Math.Log10(x);
                    break;
                case "third":
                    double buf = Math.Cos(x);
                    if (buf == 0) Exit("cos shouldn't equals 0 for such function");
                    else res = Math.Pow(buf, 3);
                    break;
                default:
                    Console.WriteLine("Such operation is not supported");
                    break;
            }
            Console.WriteLine($"Result = {res}");
            
        }
    }
    
}
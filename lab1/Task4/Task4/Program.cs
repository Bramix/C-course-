using System;

namespace Task4
{
    class Program {
    private static double Pow()
        {
            Console.WriteLine("Input a and b (a ^ b)");
            Console.WriteLine("Input a");
            double a = Double.Parse(Console.ReadLine());
            Console.WriteLine("Input b");
            double b = Double.Parse(Console.ReadLine());
            
            if (a > 0) return Math.Pow(a, b);
            else return -Math.Pow(-a, b);
        }
        private static double GetPercent()
        {
            Console.WriteLine("Input a and b (a % b)");
            Console.WriteLine("Input a");
            double a = Double.Parse(Console.ReadLine());
            Console.WriteLine("Input b");
            double b = Double.Parse(Console.ReadLine());
            double res = a / b * 100;
            return res ;
        }

        private static double Sqrt()
        {
            Console.WriteLine("Input number");
            double a = Double.Parse(Console.ReadLine());
            return Math.Sqrt(a);
        }

        public static void Main(string[] args)
        {
            string operation;
            double res = 0;
            while (true)
            {
                Console.WriteLine("Input type of operation (pow, sqrt, %) or exit");
                operation = Console.ReadLine();
                switch (operation)
                {
                    case ("pow"):   
                        res = Pow();
                        break;
                    case ("sqrt"):
                        res = Sqrt();
                        break;
                    case ("%"):
                        res = GetPercent();
                        break;
                    case ("exit"):
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Such operation isn't supported");
                        break;
                }
                Console.WriteLine($"Result = {res}");
            }
        }
    }

    class Person
    {
        static
        {
            
        }
    }
    
}
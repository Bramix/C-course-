using System;

namespace ConsoleApp
{
    class Program
    {
        private static void exit(String message)
        {
            Console.WriteLine(message);
            Environment.Exit(0);
        }
        
        public static void Main(string[] args)
        {
            double xMin, xMax, delta, res, c;
            Console.WriteLine("Input parameters for calculating");
            Console.WriteLine("Input parameter с");
            c = double.Parse(Console.ReadLine());
            Console.WriteLine("Input xMin (double)");
            xMin = double.Parse(Console.ReadLine());
            Console.WriteLine("Input xMax (double)");
            xMax = double.Parse(Console.ReadLine());
            Console.WriteLine("Input delta (double)");
            delta = double.Parse(Console.ReadLine());
            if (delta < 0) {
                exit ("delta should be > 0");
            }

            for (double i = xMin; i <= xMax; i+= delta)
            {
                res = Math.Pow(c * c * i * i + 2, (double) 1 / 3) + Math.Log(i * i + 1) / (2 * Math.PI);
                Console.WriteLine("для x = " + i + ", y = " + res);
            }

        }
    }
}
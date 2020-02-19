using System;
using System.Linq;

namespace Task3
{
    public class Utility
    {
        public static double[] InputArray(string text)
        {
            Console.WriteLine(text);
            int size = int.Parse(Console.ReadLine());
            Console.WriteLine("Input array in format: 1 2 3 4 5 ...");
            return Console.ReadLine()
                .Split(' ')
                .Select(numb => double.Parse(numb))
                .ToArray();
            
        }

        public static void PrintArray(double [] array)
        {
            Console.WriteLine("Output arary:");
            foreach (var d in array)
            {
                Console.Write($"{d} ");
            }
            Console.WriteLine();
        }
    }
}
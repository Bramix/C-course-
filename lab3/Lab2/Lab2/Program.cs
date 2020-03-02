using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, input the size of arrays");
            try
            {
                int size = int.Parse(Console.ReadLine());
                int[] height = GetArray(size, "Input the first array");
                int[] mass = GetArray(size, "Input the second array");
                Array.Sort(height, mass);
                PrintArray(height,  "The array of height:");
                PrintArray(mass,  "The array of mass:");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        private static int[] GetArray (int length, string text)
        {
            int[] array = new int[length];
            Console.WriteLine(text);
            for (int i = 0; i < length; i++)
            {
                Console.Write($"{i}:");
                array[i] = int.Parse(Console.ReadLine());
            }

            return array;
        }

        private static void PrintArray(int [] array, string text)
        {
            Console.WriteLine(text);
            foreach (var i in array)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }

        private static void FilterDate(int[] height, int[] mass)
        {
            
        }
    }
}
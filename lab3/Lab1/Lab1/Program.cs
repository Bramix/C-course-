using System;
using System.Linq;

namespace Lab3
{
    public class Program
    {
        private static Random _random;
        private static int MIN = 0;
        private static int MAX = 100;
        public static void Main(string[] args)
        {
            _random = new Random();
            int size = 0;
            Console.WriteLine("Input size of array:");
            try
            { 
                size = int.Parse(Console.ReadLine());  
                int[] first = ReadArray(size);
                int[] second = ReadArray(size);
                PrintArray(first, "First array");
                PrintArray(second, "Second array");
                Array.Sort(first, second);
                PrintArray(first, "The resulted first array:");
                PrintArray(second, "The resulted second array:");
            }
            catch (Exception e)
            {
                Exit(e.Message);
            }
           
            
        }
        private static void Exit(string text)
        {
            Console.WriteLine(text);
            Environment.Exit(1);
        }
        private static int[] ReadArray(int size)
        {
            
            
            int [] array = new int[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = _random.Next(MIN, MAX);
            }
            

            return array;
        }
        private static void PrintArray(int[] array, string text)
        {
            Console.WriteLine(text);
            foreach (var i in array)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }
    }
    
}
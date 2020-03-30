using System;
using System.Collections;
using System.IO;

namespace Task5
{
    public class Program
    {
        private static readonly Random _random = new Random();
        private static void PrintAllElements(ArrayList arrayList)
        {
            foreach (int item in arrayList) {
                Console.Write($"{item} ");
            }
            if (arrayList.Count == 0) {
                Console.WriteLine("The list is empty");
            }
            Console.WriteLine();
        }
      
        public static void Main(string[] args)
        {
            var numbers = new ArrayList();
            for (var i = 0; i < 1850; i++) {
                numbers.Add(_random.Next(200, 700));
            }
            
            numbers.Sort();
            Console.WriteLine("Sorted list:");
            PrintAllElements(numbers);
            
            numbers.Insert(1,2);
            var newValue = _random.Next(0, 2 + 1000);
            Console.WriteLine(numbers.Contains(newValue)
                ? $"Index of newValue = {numbers.IndexOf(newValue)}"
                : "New value is not presented in the list");

            newValue = _random.Next(0, numbers.Count - 1);
            Console.WriteLine($"Deleting element with value = {newValue}");
            numbers.Remove(newValue);
            PrintAllElements(numbers);
            
            Console.WriteLine("Removing all elements");
            numbers.Clear();
            PrintAllElements(numbers);
        }
    }
}
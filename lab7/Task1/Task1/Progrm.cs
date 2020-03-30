using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace Task1
{
    public class Progrm
    {
        private const string FilePath = "..\\..\\..\\input.txt";
        
        public static void Main(string[] args)
        {
            if (!File.Exists(FilePath))
            {
                Console.WriteLine("File input.txt is not exist");
                Environment.Exit(1);
            }
            
            string input = File.ReadAllText(FilePath);
            if (String.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("File input.txt is empty");
                Environment.Exit(1);
            }
            
            var stack = new Stack<int>();
            foreach (char el in input)
            {
                if (el == '(' ) stack.Push(1);
                if (el == ')' && stack.Count != 0) stack.Pop();
            }

            if (stack.Count == 0)
            {
                Console.WriteLine("Opened hooks equal to closed");
            }
            else
            {
                Console.WriteLine("Opened hooks not equal to closed");
            }
        }
    }
}
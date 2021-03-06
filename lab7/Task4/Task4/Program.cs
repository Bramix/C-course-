﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Task4
{
    public class Program
    {
        private const string FilePath = "..\\..\\..\\input.txt";

        private static void Exit (string text) {
            Console.WriteLine(text);
            Environment.Exit(1);
        }
        
        public static void Main(string[] args)
        {
            if (!File.Exists(FilePath)) { 
                Exit("File input.txt is not exist");
            }
            var stack = new Stack<string>();
            try
            {
                string[] numbers = File.ReadAllText(FilePath).Split(" ");
                foreach (var number in numbers)
                {
                    stack.Push(number);
                }
            }
            catch (FormatException)
            {
                Exit("Incorrect format of the file, please input numbers, splited by the space");
            }
            
            Console.WriteLine("Reversed numbers");
            while (stack.Count != 0)
            {
                Console.Write($"{stack.Pop()} ");
            }
        }
    }
}
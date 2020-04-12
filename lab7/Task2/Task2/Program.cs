using System;
using System.Collections.Generic;
using System.IO;

namespace Task2
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
            var queue = new Queue<string>();
            if (!File.Exists(FilePath)) { 
                Exit("File input.txt is not exist");
            }

            try {
                string[] persons = File.ReadAllLines(FilePath);
                foreach (string element in persons) {
                    if (int.Parse(element.Split(" ")[3]) < 40)
                        queue.Enqueue(element);
                }

                foreach (string element in persons) {
                    if (int.Parse(element.Split(" ")[3]) >= 40)
                        queue.Enqueue(element);
                }
            }
            catch (FormatException) {
                Exit("Invalid format of the file. Please restart and write all lines as in example: Bozhenko Vladyslav Sergeevich 30 60");
            }
            

            Console.WriteLine("Result:");
            while (queue.Count != 0) {
                Console.WriteLine(queue.Dequeue());
            }
        }
    }
}
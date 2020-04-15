using System;
using System.Collections.Generic;
using System.IO;

namespace Task2
{
    public class Program
    {
        private const string FilePath = "..\\..\\..\\input.txt";
        private static void Exit(string text)
        {
            Console.WriteLine(text);
            Environment.Exit(1);
        }

        public static void Main(string[] args)
        {
            if (!File.Exists(FilePath))
            {
                Exit("File input.txt is not exist");
            } 
            var operations = new List<Operation>()
            {
                Operation.PrintAllTextFromFile,
                Operation.PrintNumbersFromFile,
                Operation.ReplacePointsOnSpace,
                Operation.PrintAllTextFromFile
            };
            OperationService.PerformListOfOperations(operations, FilePath);
        }
    }
}
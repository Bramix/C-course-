using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Task2
{
    public enum Operation
    {
        PrintAllTextFromFile,
        PrintNumbersFromFile,
        ReplacePointsOnSpace,
    }

    public class OperationService
    {
        private static string _allText;

        private static readonly Dictionary<Operation, Action<string>> _operations = new Dictionary<Operation, Action<string>>()
        {
            {Operation.PrintAllTextFromFile, PrintAllTextFromFile},
            {Operation.PrintNumbersFromFile, PrintNumbers},
            {Operation.ReplacePointsOnSpace, ReplacePointsOnSpace},
        };
    
        
        public static void PerformListOfOperations(List<Operation> operations, string filePath)
        {
            operations.ForEach(operation => PerformOperation(operation, filePath));
        }

        private static void PerformOperation(Operation operation, string filePath)
        {
            if (_operations.ContainsKey(operation)) 
                _operations[operation](filePath);
            else {
                throw new ArgumentException($"The Operation {operation} is not valid");      
            }
        }
        private static void PrintAllTextFromFile(string filePath)
        {
            Console.WriteLine("Starting the operation of printing all information from the file");
            var allText = ReadAllTextFromFile(filePath);
            Console.WriteLine(allText);
        }

        private static void PrintNumbers(string filePath)
        {
            Console.WriteLine("Starting the operation of printing all numbers from the file:");
            var allText = ReadAllTextFromFile(filePath);
            var numbers = new List<string>();
            for (int i = 0; i < allText.Length; i++) {
                if (Char.IsDigit(allText[i])) {
                    StringBuilder number = new StringBuilder(allText[i].ToString());
                    int j = i + 1;
                    while (j < allText.Length  && Char.IsDigit(allText[j])) {
                        number.Append(allText[j]);
                        j++;
                    }
                    i += j - i;
                    numbers.Add(number.ToString());
                }
            }
            numbers.ForEach(number => Console.Write($"{number} "));
            Console.WriteLine();
        }

        private static void ReplacePointsOnSpace(string filePath)
        {
            Console.WriteLine("Starting the operation of replacing all points in the file");
            var allText = ReadAllTextFromFile(filePath);
            var stringBuilder = new StringBuilder(allText);
            for (var i = 0; i < stringBuilder.Length; i++)
            {
                if (stringBuilder[i] == '.' || stringBuilder[i] == ',')
                {
                    stringBuilder[i] = ' ';
                }
            }
            File.WriteAllText(filePath, stringBuilder.ToString());
        }

        private static string ReadAllTextFromFile(string filePath)
        {
            return _allText ??= File.ReadAllText(filePath);
        }
    }
}
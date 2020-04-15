using System;
using System.Collections.Generic;

namespace Task1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please, input A for size of matrix (AxB)");
            var a = int.Parse(Console.ReadLine());
            Console.WriteLine("Please, input B for size of matrix (AxB)");
            var b = int.Parse(Console.ReadLine());
            Console.WriteLine("Generating of numbers");
            var matrix = new double [a, b];
            
            var operations = new List<Operation>()
            {
                Operation.GenerateMatrix, 
                Operation.PrintAll, 
                Operation.PrintPositive, 
                Operation.Multiply, 
                Operation.PrintAll
            };
            OperationService.ChangeMatrix(matrix, operations);
        }

    }
}
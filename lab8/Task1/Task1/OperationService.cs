using System;
using System.Collections.Generic;

namespace Task1
{
    public enum Operation
    {
        GenerateMatrix,
        PrintAll,
        Multiply,
        PrintPositive
    }
    public class OperationService
    {  
        private static readonly Random _random = new Random();
        private static readonly Dictionary<Operation, Action<double[,]>> _operations = new Dictionary<Operation, Action<double[,]>>()
            {
                {Operation.GenerateMatrix, GenerateMatrix},
                {Operation.PrintAll, PrintMatrix},
                {Operation.PrintPositive, PrintPositive},
                {Operation.Multiply, MultiplyMatrix3},
            };
        

        public static void ChangeMatrix(double[,] matrix, List<Operation> operations)
        {
            foreach (Operation operation in operations)
            {
                PerformOperation(operation, matrix);
            }
        }

        private static void PerformOperation(Operation operation, double[,] matrix)
        {
            if (_operations.ContainsKey(operation)) 
                _operations[operation](matrix);
            else {
                throw new ArgumentException($"The Operation {operation} is not valid");      
            }
        }

        private static void GenerateMatrix(double[,] matrix)
        {
            for (var i = 0; i < matrix.GetLength(0); i++)
            for (var j = 0; j < matrix.GetLength(1); j++)
                matrix[i, j] = -10 + _random.NextDouble() * 20;
        }
        private static void PrintMatrix(double[,] matrix)
        {
            Console.WriteLine("The Operation of printing all elements of the matrix is performed");
            for (var i = 0; i < matrix.GetLength(0); i++)
            {
                for (var j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        private static void PrintPositive(double[,] matrix)
        {
            Console.WriteLine("The Operation of printing of the positive elements is performed");
            for (var i = 0; i < matrix.GetLength(0); i++)
            {
                for (var j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] > 0) Console.Write($"{matrix[i, j]} ");
                }
            }
            Console.WriteLine();
        }

        private static void MultiplyMatrix3(double[,] matrix)
        {
            Console.WriteLine("The Operation of multiplying is performed");
            for (var i = 0; i < matrix.GetLength(0); i++)
            {
                for (var j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] *= 3;
                }
            }
        }
    }
}
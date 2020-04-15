using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task5
{
    public class Program
    {
        private delegate double UseOperation(double a, double b);
        private static Dictionary<string, UseOperation> _operations = new Dictionary<string, UseOperation>()
        {
            {"+", Plus},
            {"-", Minus},
            {"/", Div} ,
            {"*", MultiPly}
        };
        public static void Main(string[] args)
        {
            try
            {
                GreetingsService.SayGreetings();

                Console.WriteLine("Please, input the first number for operation");
                var firstNumb = double.Parse(Console.ReadLine());

                Console.WriteLine("Input the second number for operation");
                var secondNumb = double.Parse(Console.ReadLine());

                Console.WriteLine($"Input the operation from the next list: {GetAllOperations()}");
                var operation = Console.ReadLine();

                double result = PerformOperation(operation, firstNumb, secondNumb);
                Console.WriteLine($"The result = {result}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Input number has incorrect format");
            }
            catch (ArgumentException)
            {
                Console.WriteLine($"Such operation is not supported21");
            }
            

        }

        private static string GetAllOperations()
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (string operationsKey in _operations.Keys)
            {
                stringBuilder.Append(operationsKey).Append(", ");
            }

            return stringBuilder.ToString();
        }

        private static double PerformOperation(string keyOfUseOperation, double a, double b)
        {
            if (_operations.ContainsKey(keyOfUseOperation))
                return _operations[keyOfUseOperation](a, b);
            else
                throw new ArgumentException();
        }

        private static double Plus(double a, double b)
        {
            return a + b;
        }

        private static double Minus(double a, double b)
        {
            return a - b;
        }

        private static double MultiPly(double a, double b)
        {
            return a * b;
        }

        private static double Div(double a, double b)
        {
            return a / b;
        }
    }

    
}
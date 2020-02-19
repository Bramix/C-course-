
using System;
using static System.Console;

namespace Task2
{
    public class Utility
    {
        
        public static double [][] InputArray()
        {
            WriteLine("Input count of rows");
            int rows = Int32.Parse(ReadLine());
            double [][] res = new double [rows][];
            for (int i = 0; i < rows; i++)
            {
                WriteLine($"Input count of columns for row № {i} ");
                int columns = int.Parse(ReadLine()); 
                res[i] = new double [columns];
                for (int j = 0; j < columns; j++)
                {
                    WriteLine($"Input element [{i}][{j}]: ");
                    res[i][j] = double.Parse(ReadLine());
                }
            }

            return res;
        } 
        
        public static void PrintArray(double [][] array, string text)
        {
            WriteLine(text);
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    Write($"{array[i][j]} ");
                }
                WriteLine();
            }
        }
    }
}
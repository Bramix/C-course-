using System;
using static Task2.Utility;

namespace Task2
{
    class Program
    {
        private static double[][] GetResult( double [][] array)
        {
            double average ;
            for (int i = 0; i < array.Length; i++)
            {
                average = 0;
                for (int j = 0; j < array[i].Length; j++)
                {
                    average += array[i][j];
                }

                average /= (double) array[i].Length;

                for (int j = 0; j < array[i].Length; j++)
                {
                    array[i][j] -= average;
                }
            }
            return array;
        }
        public static void Main(string[] args)
        {
            try
            {
                double[][] array = InputArray();
                PrintArray(array, "Input matrix");
                GetResult(array);
                PrintArray(array, "OutPut matrix");
            }
            catch (FormatException e)
            {
                Console.WriteLine("Invalid format of the input parameter");
            }
            catch (OverflowException e)
            {
                Console.WriteLine("Invalid value of the input parameter");
            }
            
        }
    }
}
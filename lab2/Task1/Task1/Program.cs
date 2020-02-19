using System;

namespace Task1
{
    class Program
    {
        private static double[] ProductVector(double [,] matrix, int x, int y, double [] vector)
        {
            double [] res = new double [x];
            for (int i = 0; i < x; i++)
            for (int j = 0; j < y; j++)
            {
                res[i] += matrix[i,j] * vector[j];
            }

            return res;
        }

        private static void Exit()
        {
            Console.WriteLine("Programme has been successfully finished");
            Environment.Exit(0);
        }
        private static void ProvideMatrix()
        {
            double [,] arr;
            double [] vector ;
            Console.WriteLine("Input count of rows or print -1 to exit: ");
            int rows = int.Parse(Console.ReadLine());
            
            if (rows == -1) Exit();
            
            Console.WriteLine("Input count of rows: ");
            int columns = int.Parse(Console.ReadLine());
            
            arr = Utility.InputArray(rows, columns);
            vector = new double [rows];
            Utility.PrintArray(arr, rows, columns);
            Utility.InputArray(vector);
            
            double[] res = ProductVector(arr, rows, columns, vector);
            Utility.PrintArray(res);
        }
        public static void Main(string[] args)
        {
            try
            {
                ProvideMatrix();
            }
            catch (FormatException e)
            {
                Console.WriteLine("Invalid format of printed element");
                ProvideMatrix();
            }
            catch (OverflowException)
            {
                Console.WriteLine("Invalid value of previous element.");
                ProvideMatrix();
            }
            catch (Exception)
            {
                Console.WriteLine("Catch exception during runtime. Please, try again!");
                ProvideMatrix();
            }
        }
    }
}
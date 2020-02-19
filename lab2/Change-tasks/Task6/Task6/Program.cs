using System;
using System.Linq;

namespace Arrays
{
    class Class
    {
        static int[][] Input(out int n, out int m)
        {
            Console.WriteLine("введіть розмірність масиву");
            Console.Write("n = ");
            n = int.Parse(Console.ReadLine());
            Console.Write("m = ");
            m = int.Parse(Console.ReadLine());
            int[][] a = new int[n][];
            for (int i = 0; i < n; i++)
            {
                a[i] = new int [m];
                for (int j = 0; j < m; ++j)
                {
                    Console.Write("a[{0},{1}]= ", i, j);
                    a[i][j] = int.Parse(Console.ReadLine());
                }

            }
            return a;
        }

        static void Print(int[][] a, int n, int m)
        {
            for (int i = 0; i < a.Length; ++i, Console.WriteLine())
            for (int j = 0; j < a[i].Length; ++j)
                Console.Write("{0,5} ", a[i][j]);
        }

        static int [][] DeleteArray(int [][] inputArray, int k)
        {
            k--;
            return inputArray.Select(arr => arr.Where((item, i) => i != k)
                    .ToArray())
                .ToArray();
        }

        static void Main()
        {
            int n, m;
            int[][] myArray = Input(out n, out m);
            Console.WriteLine("Output massive:");
            Print(myArray, n, m);
            Console.WriteLine("Input a number of a column for deleting:");
            int k = int.Parse(Console.ReadLine());
            myArray = DeleteArray(myArray, k);
            Console.WriteLine("змінений масив:");
            Print(myArray, n, m);
        }
    }
}
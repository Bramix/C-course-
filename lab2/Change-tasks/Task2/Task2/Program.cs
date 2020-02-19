using System;
namespace Arrays
{
    class Program
    {
        static void Main()
        {
            try
            {
                int[][] MyArray;
                Console.Write("Input count of rows: ");
                int n = int.Parse(Console.ReadLine());
                MyArray = new int[n][];
                for (int i = 0; i < MyArray.Length; i++)
                {
                    Console.WriteLine($"Input count of elements in {i} row");
                    int j = int.Parse(Console.ReadLine());
                    MyArray[i] = new int[j];
                    for (j = 0; j < MyArray[i].Length; j++)
                    {
                        Console.Write("a[{0}][{1}]= ", i, j);
                        MyArray[i][j] = int.Parse(Console.ReadLine());
                    }
                }
                PrintArray("output array:", MyArray);
                for (int i = 0; i < MyArray.Length; i++)
                    Array.Sort(MyArray[i]);
                PrintArray("updated array:", MyArray);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid format of date");
            }
            catch (OverflowException)
            {
                Console.WriteLine("OverFlow");
            }
            catch (OutOfMemoryException)
            {
                Console.WriteLine("OutOfMemory");
            }
        }
        static void PrintArray(string a, int[][] mas)
        {
            Console.WriteLine(a);
            for (int i = 0; i < mas.Length; i++)
            {
                for (int j = 0; j < mas[i].Length; j++)
                    Console.Write("{0} ",
                        mas[i][j]);
                Console.WriteLine();
            }
        }
    }
}
using System;
namespace Arrays
{
    class Program
    {
        public static void Main()
        {
            try
            {
                Console.Write("Уведіть кількість рядків: ");
                int n = int.Parse(Console.ReadLine());
                int[][] array = new int[n][];
                MakeArray(array);
                PrintArray(array);
            }
            catch (FormatException)
            {
                Console.WriteLine("невірний формат вводу даних");
            }
            catch (OverflowException)
            {
                Console.WriteLine("переповнення");
            }
            catch (OutOfMemoryException)
            {
                Console.WriteLine("недостатньо пам'яті для створення нового об'єкта");
            }
        }
        private static void PrintArray( int[][] mas)
        {
            Console.WriteLine("Updated array: ");
            for (int i = 0; i < mas.Length; i++)
            {
                for (int j = 0; j < mas[i].Length; j++)
                    Console.Write("{0} ",
                        mas[i][j]);
                Console.WriteLine();
            }
        }

        private static void MakeArray(int[][] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new int [i * 2];
                for (int j = 0; j < array[i].Length; j++)
                {
                    array[i][j] = i + j;
                }
            }
        }
    }
}
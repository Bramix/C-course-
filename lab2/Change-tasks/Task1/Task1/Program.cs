using System;

namespace Task1
{
    class Program
    {
        private const int x = 3;
        private const int y = 3;
        
        private static void InputArray(int [,] array) {
            Console.WriteLine($"Input massive with size {x}x{y}");
            for (int i = 0; i < array.GetLength(0); i++)
                for (int j = 0; j < array.GetLength(1); j++)
                    array[i, j] = Int32.Parse(Console.ReadLine());
        }
        static void PrintArray(string a, int[,] mas)
        {
            Console.WriteLine(a);
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++) Console.Write("{0} ", mas[i, j]);
                Console.WriteLine();
            }
        }
        static int Change(int[,] mas)
        {
            int res = 0;
            for (int i = 0; i < mas.GetLength(0); i++)
            for (int j = 0; j < mas.GetLength(1); j++)
                if (mas[i, j] % 2 == 0) res += mas [i, j];
            return res;
        }
        public static void Main () {
            try
            {
                int[,] myArray = new int[x , y];
                InputArray(myArray);
                PrintArray("вихідний масив:", myArray);
                int res = Change(myArray);
                Console.WriteLine($"Сума непарних = {res}");
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
    }

}
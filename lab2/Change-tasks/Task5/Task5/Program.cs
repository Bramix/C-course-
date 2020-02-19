using System;
namespace Arrays
{
    class Class
    {
        static int[] Input()
        {
            Console.WriteLine("введіть розмірність масиву");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < n; ++i)
            {
                Console.Write("a[{0}]= ", i);
                a[i] = int.Parse(Console.ReadLine());
            }
            return a;
        }
        static void Print(int[] a, int n)
        {
            for (int i = 0; i < n; ++i) Console.Write("{0} ", a[i]);
            Console.WriteLine();
        }
        static void DeleteArray(int[] a, ref int n, int m)
        {
            for (int i = m; i < n - 1; ++i)
                a[i] = a[i + 1];
            --n;
        }
        static void Main()
        {
            try
            {
                int[] myArray = Input();
                int n = myArray.Length;
                Console.WriteLine("Вихідний масив:");
                Print(myArray, n);
                Console.WriteLine("Введіть номер елемента для видалення:");
                int m = int.Parse(Console.ReadLine());
                DeleteArray(myArray, ref n, m);
                Console.WriteLine("змінений масив:");
                Print(myArray, n);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Format Exception");
            }
            catch (OverflowException e)
            {
                Console.WriteLine("OwerFlow Exception");
            }
            catch (OutOfMemoryException e)
            {
                Console.WriteLine("Тут могла быфы быть ваша реклама");
            }
            
        }
    }
}
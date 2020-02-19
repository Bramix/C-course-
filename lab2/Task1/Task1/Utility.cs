    using System;

    namespace Task1
    {
        public class Utility
        {
            public static double [,] InputArray(int x, int y)
            {
                double [,] array  = new double [x, y];
                Console.WriteLine("Input matrix");
                for (int i = 0; i < x; i++)
                {
                    for (int j = 0; j < y; j++)
                    {
                        Console.WriteLine($"Input arr [{i}][{j}]: ");
                        array[i, j] = int.Parse(Console.ReadLine());
                    }
                }

                return array;
            }

            public static void InputArray(Double [] array)
            {
                Console.WriteLine("Input vector");
                for (int i = 0; i < array.Length; i++)
                {
                    Console.WriteLine($"Input vector[{i}]");
                    array[i] = Double.Parse(Console.ReadLine());
                }
            } 

            public static void PrintArray(double [,] array, int x , int y) 
            {
                Console.WriteLine("Output array");
                for (int i = 0; i < x; i++)
                {
                    for (int j = 0; j < y; j++)
                    {
                        Console.Write(array [i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }

            public static void PrintArray(double[] array)
            {
                Console.WriteLine("Output vector: ");
                for (int i = 0; i < array.Length; i++)
                {
                    Console.WriteLine($"vecror[{i}] == {array[i]}");
                }
            }
        }
    }
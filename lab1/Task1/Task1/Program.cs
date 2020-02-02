using System;

namespace Task1
{
    class Program
    {
        private static void exit(String message)
        {
            Console.WriteLine(message);
            Environment.Exit(1);
        }
        private static double pow(double a, double b)
        {
            if (a > 0) return Math.Pow(a, b);
            else return -Math.Pow(-a, b);
        }
        public static void Main(string[] args)
        {
            double a, c, x;
            Console.WriteLine("Введите параметры(a, c, x) для исследуемой функции");
            Console.WriteLine("Введите параметр a (double)");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите параметр c (double)");
            c = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите параметр x (double)");
            x = double.Parse(Console.ReadLine());

            if (Math.Sin(Math.PI / 3 + x) == 0) {
                exit("2 * sin (pi/3 + x) не может равняться 0");
            }
            if (x <= 0) {
                exit("x должен быть > 0 ");
            }
            double res = pow(c * x - a, (double) 1 / 3) + Math.Log(x) / (2 * Math.Sin(Math.PI / 3 + x));
            Console.WriteLine($"Результат равен: {res}");
        }
    }
}
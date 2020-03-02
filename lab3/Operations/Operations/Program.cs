using System;

namespace Operations
{
    //1+6*x-x^2-x*y-y^2
    public class Program
    {
        public static void Main(string[] args)
        {
            double x = 3, y = 3, step = 1, res;
            res = GetRes(x, y);
            while (step >= 0.1)
            {
                Console.WriteLine($"Начинаем новую итерацию с точки ({y.ToString("#.##")};{x.ToString("#.##")})");
                double buf = res;
                if (GetRes(x + step, y) > res)
                {
                    res = GetRes(x + step, y);
                    x += step;
                }
                
                if (GetRes(x - step, y) > res)
                {
                    res = GetRes(x + step, y);
                    x -= step;
                }

                if (GetRes(x, y + step) > res)
                {
                    res = GetRes(x, y + step);
                    y += step;
                }
                if (GetRes(x, y - step) > res)
                {
                    res = GetRes(x, y - step);
                    y -= step;
                }

                if (buf == res)
                {
                    if (step != 0.1)
                    {
                        if (step == 0.25) step = 0.1;
                        else step /= 2.0;
                        Console.WriteLine($"Уменьшаем шаг h до {step}");
                    }
                    else break;
                }

                PrintPoint(x, y);

            }
            Console.WriteLine($"Максимум функции равен = {res} в точке ({x.ToString("#.##")};{y.ToString("#.##")}) ");
        }
        private static double GetRes (double x, double y)
        {
            return 1 + 6 * x - x * x - x * y - y * y;
        }

        private static void PrintPoint(double x, double y)
        {
            Console.WriteLine($"Точка ({x.ToString("#.##")};{y.ToString("#.##")}) имеет максимальное значение = {GetRes(x, y)} на этом шаге");
        }

    }
    
}
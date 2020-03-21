using System;
using Lab1.Implementation;
using Lab1.Interface;

namespace Lab1
{
  internal class Program
    {
        public static void Main(string[] args)
        {
            IDemo[] a = new IDemo[4];
            // заповнення масиву
            a[0] = new DemoPoint(0, 1);
            a[1] = new DemoPoint(-3, 0);
            a[2] = new DemoShape(3, 4, 0);
            a[3] = new DemoShape(0, 5, 6);
            // перегляд масиву
            foreach (IDemo x in a)
            {
                x.Show();
                Console.WriteLine("Length = {0:f2}", x.Length());
                Console.WriteLine("x = " + x.X);
                x[1] += x[0];
                Console.Write("new cordinates - ");
                x.Show();
                Console.WriteLine();
            }
        }
    }
}
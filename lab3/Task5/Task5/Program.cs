using System;
using System.Linq;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            String one = "Hello ";
            String two = "World ";
            Console.WriteLine(string.Concat(one, two));
            var inserted = one.Insert(one.Length - 1, two);
            Console.WriteLine(inserted);
            Console.WriteLine(one.Replace('l','r'));
            Console.WriteLine(String.Compare(one, two));
            Console.WriteLine(one.IndexOf("el"));
        }
    }
}
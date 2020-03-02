using System;
using System.Collections.Generic;
using System.Linq;

namespace Task3
{
    class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                double [] first = Utility.InputArray("Input a size of the first massive");
                double [] second = Utility.InputArray("Input a size of the second massive ");
                double[] res = Join(first, second);
                Utility.PrintArray(res);   
            }
            catch (FormatException e)
            {
                Console.WriteLine("Invalid format of the input parameter");
            }
            catch (OverflowException e)
            {
                Console.WriteLine("Invalid value of the input parameter");
            }

        }

        private static double[] Join(double[] first, double[] second)
        {
            Func<double, int, bool> filter = (d, i) => i % 2 == 1 ;    
            double [] array = first.Where(filter)
                .ToArray()
                .Concat(second.Where(filter).ToArray())
                .ToArray();
            Array.Sort(array);
            List <integer> list 
            return array;
        }
         
    }
    
}
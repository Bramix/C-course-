using System;
using System.Net.Mime;

namespace Task3
{
    public class Program
    {
        private delegate double Delegator(double r); 
        private static CalculationService _calculationService = new CalculationService();
        public static void Main(string[] args)
        {
            var r = 0.0;
            Console.WriteLine("Please input a radius of the figure:");
            try
            {
                r = double.Parse(Console.ReadLine());
                if (r < 0) throw new ArgumentException();
            } catch (Exception)
            {
                Console.WriteLine("Please input correct number in such format: x.zyl, which > 0");
                Environment.Exit(1);
            }
            
            Delegator delegator = _calculationService.CalculateLengthOfCircle;
            Console.WriteLine($"CalculateLengthOfCircle executed. Res = {delegator(r)}");
            
            delegator = _calculationService.CalculateVOfSphere;
            Console.WriteLine($"CalculateVOfSphere executed. Res = {delegator(r)}");

            delegator = _calculationService.CalculateSquareOfCircle;
            Console.WriteLine($"CalculateSquareOfCircle executed. Res = {delegator(r)}");
        }
    }
}
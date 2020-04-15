using System;

namespace Task3
{
    public class CalculationService : ICalculationService
    {
        
        public double CalculateSquareOfCircle(double r)
        {
            return Math.PI * Math.Pow(r, 2);
        }

        public double CalculateLengthOfCircle(double r)
        {
            return 2 * Math.PI * r;
        }

        public double CalculateVOfSphere(double r)
        {
            return (4.0 / 3) * Math.PI * Math.Pow(r, 3);
        }
    }
}
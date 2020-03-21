using System;
using Task2.Interface;

namespace Task2.Implementation
{
    public class Square : IMeasurable, ICircumcircleIncircle, IComparable<Square>
    {
        private double side;
        
        public double Perimeter()
        {
            return 4 * side;
        }

        public double Area()
        {
            return side * side;
        }
        
        public double R
        {
            get => side / Math.Sqrt(2);
        }

        public double r
        {
            get => side / 2;
        }
        
        public int CompareTo(Square square)
        {
            if (square == null) return -1;
            return Perimeter().CompareTo(square.Perimeter());
        }

        public Square(double side)
        {
            this.side = side;
        }

        public double Side
        {
            get => side;
        }

        public override string ToString()
        {
            return $"The square has next parameters : {nameof(Side)}: {Side}, {nameof(r)}: {r}, {nameof(R)}: {R}";
        }
        
    }
}
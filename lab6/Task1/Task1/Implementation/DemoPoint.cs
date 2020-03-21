using System;
using Lab1.Interface;

namespace Lab1.Implementation
{
    class DemoPoint : IDemo
    {
        private const string InvalidValueOfIndex = "Invalid value of index"; 
        protected int x;
        protected int y;
        public DemoPoint(int x, int y)
        {
            this.x = x; this.y = y;
        }
        public void Show() 
        {
            Console.WriteLine($"Point in space: ({x}, {y})");
        }

        public double Length()
        {
            return Math.Sqrt(x * x + y * y);
        }
        
        public int X => x;

        public int Y => y;

        public int this[int i] 
        {
            get
            {
                if (i == 0) return x;
                if (i == 1) return y;
                throw new Exception(InvalidValueOfIndex);
            }
            set
            {
                if (i == 0) x = value;
                else if (i == 1) y = value;
                else throw new Exception(InvalidValueOfIndex);
            }
        }
    }
}
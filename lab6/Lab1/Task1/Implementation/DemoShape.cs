using System;
using System.Security.Permissions;
using Lab1.Interface;

namespace Lab1.Implementation
{
    class DemoShape : DemoPoint, IDemo
    {
        protected int z;
        public DemoShape(int x, int y, int z) : base(x, y)
        {
            this.z = z;
        }
        public new void Show()
        {
            Console.WriteLine($"Point in Space: ({x}, {y}, {z})");
        }

        public double Length()
        {
            return Math.Sqrt(x * x + y * y + z * z);
        }
      
        public new int this[int i]
        {
            get
            {
                if (i == 2) return z;
                else return base[i];
            }
            set
            {
                if (i == 2) z = value;
                else base[i] = value;
            }
        }
    }
}
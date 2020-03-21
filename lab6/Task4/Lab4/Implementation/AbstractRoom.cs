using System;
using Lab4.Interface;

namespace Lab4.Implementation
{
    public abstract class AbstractRoom: IRoom
    {
        private double width;
        private double length;
        private double height;
        private double countOfWindows;
        private double area;
        
        public double Width => width;
        public double Length => length;
        public double Height => height;
        public double CountOfWindows => countOfWindows;
        public double Area => area;

        protected AbstractRoom(double width, double length, double height, double countOfWindows)
        {
            this.width = width;
            this.length = length;
            this.height = height;
            this.countOfWindows = countOfWindows;
            area = length * width;
        }

        public int CompareTo(object? obj)
        {
            if (obj == null)
            {
                return 1;
            }

            if (!(obj is AbstractRoom))
            {
                throw new ArgumentException("An argument should be a child of AbstractRoom");
            }
            var item = (IRoom) obj;
            if (Area.Equals(item.Area)) return 0;
            if (Area > item.Area) return 1;
            else return -1;
        }

        public override string ToString()
        {
            return $"{nameof(width)}: {width}, {nameof(length)}: {length}, {nameof(height)}: {height}, {nameof(countOfWindows)}: {countOfWindows}, {nameof(area)}: {area}";
        }
    }
}
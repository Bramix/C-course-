using System;
using System.Collections.Generic;

namespace Lab4.Implementation
{
    public class RoomComparer: IComparer <AbstractRoom>
    {
        public int Compare(AbstractRoom x, AbstractRoom y)
        {
            if (x == y) return 0;
            if (x != null && y != null)
                return x.CountOfWindows.CompareTo(y.CountOfWindows);
            return -1;
        }
    }
}
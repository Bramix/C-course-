using Lab4.Interface;

namespace Lab4.Implementation
{
    public class MyRoom : AbstractRoom
    {
        public MyRoom(double width, double length, double height, double countOfWindows) : base(width, length, height, countOfWindows) { }
    }
}
using System;
using System.Collections.Generic;
using Lab4.Implementation;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<AbstractRoom>
            {
                new ClassRoom(200, 150, 80, 4, 30, true),
                new ClassRoom(200, 150, 80, 100, 30, true),
                new MyRoom(100, 400, 60, 2),
                new MyRoom(100, 200, 50, 3),
            };
            
            list.Sort(new RoomComparer());
            Console.WriteLine("Sorted list by countOfWindows");
            foreach (AbstractRoom item in list)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }

}
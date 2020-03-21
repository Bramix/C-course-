using System;
using System.Collections.Generic;
using Task2.Implementation;

namespace Task2
{
  internal class Program
  {
    public static void Main(string[] args)
    {
        var square = new Square(10);
        Console.WriteLine(square.ToString());
        Console.WriteLine($"P = {square.Perimeter()}");
        Console.WriteLine($"S = {square.Area()}");
        
        var squares = new List<Square>
        {
            square, new Square(100), new Square(15), new Square(7)
        };
        squares.Sort();
        
        Console.WriteLine("Sorted squared");
        foreach (Square item in squares)
        {
            Console.WriteLine(item.ToString());
        }
    }
  }
}
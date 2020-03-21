#nullable enable
using System;

namespace Lab4.Interface
{
    public interface IRoom : IComparable
    {
        double Width { get; }
        double Length { get; }
        double Height { get; }
        double CountOfWindows { get; }
        double Area { get; }
    }
}
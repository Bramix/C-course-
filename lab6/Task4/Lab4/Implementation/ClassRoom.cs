using System;
using Lab4.Interface;

namespace Lab4.Implementation
{
    public class ClassRoom : AbstractRoom
    {
        private int maxCountOfPupils;
        private Boolean hasInteractiveWhiteboard;
        public ClassRoom(double width, double length, double height, double countOfWindows, int maxCountOfPupils, Boolean hasInteractiveWhiteboard) : base(width, length, height, countOfWindows)
        {
            this.maxCountOfPupils = maxCountOfPupils;
            this.hasInteractiveWhiteboard = hasInteractiveWhiteboard;
        }

        public int MaxCountOfPupils
        {
            get => maxCountOfPupils;
            set => maxCountOfPupils = value;
        }

        public bool HasInteractiveWhiteboard
        {
            get => hasInteractiveWhiteboard;
            set => hasInteractiveWhiteboard = value;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, {nameof(maxCountOfPupils)}: {maxCountOfPupils}, {nameof(hasInteractiveWhiteboard)}: {hasInteractiveWhiteboard}";
        }
    }
}
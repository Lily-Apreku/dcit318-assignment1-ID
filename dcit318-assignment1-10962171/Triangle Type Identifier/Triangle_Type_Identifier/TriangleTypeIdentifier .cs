// Triangle.cs
using System;

namespace TriangleTypeIdentifier
{
    class TriangleTypeIdentifier
    {
        public double Side1 { get; }
        public double Side2 { get; }
        public double Side3 { get; }

        public TriangleTypeIdentifier(double side1, double side2, double side3)
        {
            Side1 = side1;
            Side2 = side2;
            Side3 = side3;
        }

        public string DetermineTriangleType()
        {
            if (Side1 == Side2 && Side2 == Side3)
            {
                return "Equilateral triangle";
            }
            else if (Side1 == Side2 || Side2 == Side3 || Side1 == Side3)
            {
                return "Isosceles triangle";
            }
            else
            {
                return "Scalene triangle";
            }
        }
    }
}

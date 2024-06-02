// TriangleTypeIdentifier.cs
using System;

namespace TriangleTypeIdentifier
{
    class Triangle
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Triangle Type Identifier!");

            Console.Write("Enter the length of the first side: ");
            double side1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the length of the second side: ");
            double side2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the length of the first side: ");
            double side3 = Convert.ToDouble(Console.ReadLine());

            // Creating a TriangleTypeIdentifier object
            TriangleTypeIdentifier triangle = new TriangleTypeIdentifier(side1, side2, side3);

            // Determine the type of triangle
            string triangleType = triangle.DetermineTriangleType();

            // Display the type of triangle
            Console.WriteLine($"The triangle is a/an: {triangleType}");

            Console.WriteLine("Thank you for using the Triangle Type Identifier!");
        }
    }
}

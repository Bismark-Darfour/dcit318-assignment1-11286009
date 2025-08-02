// Triangle Type Identifier Application
// This program determines the type of a triangle based on its side lengths.

using System;

namespace TriangleTypeIdentifier
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Get the three side lengths from the user.
            double side1 = GetSideLength("Enter the length of the first side:");
            double side2 = GetSideLength("Enter the length of the second side:");
            double side3 = GetSideLength("Enter the length of the third side:");
            
            // 1. Call the function to identify the triangle type.
            string triangleType = IdentifyTriangleType(side1, side2, side3);

            // 2. Display the result.
            Console.WriteLine($"The triangle is: {triangleType}");
        }

        /// <summary>
        /// Prompts the user for a side length and validates the input.
        /// </summary>
        /// <param name="prompt">The message to display to the user.</param>
        /// <returns>A valid, positive number for a side length.</returns>
        public static double GetSideLength(string prompt)
        {
            double side;
            while (true)
            {
                Console.WriteLine(prompt);
                string input = Console.ReadLine();

                // Ensure the input is a number and is greater than 0.
                if (double.TryParse(input, out side) && side > 0)
                {
                    return side; // Return the valid side length.
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid input. Please enter a positive number.");
                    Console.ResetColor();
                }
            }
        }

        /// <summary>
        /// Determines the type of a triangle from its three side lengths.
        /// </summary>
        /// <param name="a">Length of side 1.</param>
        /// <param name="b">Length of side 2.</param>
        /// <param name="c">Length of side 3.</param>
        /// <returns>The type of triangle (Equilateral, Isosceles, Scalene, or invalid).</returns>
        public static string IdentifyTriangleType(double a, double b, double c)
        {
            // First, check the Triangle Inequality Theorem.
            // The sum of any two sides must be greater than the third side.
            if ((a + b <= c) || (a + c <= b) || (b + c <= a))
            {
                return "Not a valid triangle";
            }
            
            // Now, determine the type.
            if (a == b && b == c)
            {
                return "Equilateral"; // All three sides are equal.
            }
            else if (a == b || b == c || a == c)
            {
                return "Isosceles"; // Two sides are equal.
            }
            else
            {
                return "Scalene"; // No sides are equal.
            }
        }
    }
}
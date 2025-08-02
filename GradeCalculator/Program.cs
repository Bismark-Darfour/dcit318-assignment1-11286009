// Grade Calculator Application (Refined Version)
// Demonstrates separation of concerns and robust input handling.

using System;

namespace GradeCalculator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double numericalGrade;

            // Loop until the user provides a valid grade.
            while (true)
            {
                Console.WriteLine("Enter a numerical grade between 0 and 100:");
                string input = Console.ReadLine();

                // Attempt to parse the input and validate the range.
                if (double.TryParse(input, out numericalGrade) && numericalGrade >= 0 && numericalGrade <= 100)
                {
                    // If valid, break the loop.
                    break;
                }
                else
                {
                    // Provide feedback and prompt again.
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid input. Please enter a number between 0 and 100.");
                    Console.ResetColor(); // Reset console color
                }
            }
            
            // 1. Call the dedicated function to get the letter grade.
            string letterGrade = GetLetterGrade(numericalGrade);

            // 2. Display the final result to the user.
            Console.WriteLine($"The corresponding letter grade is: {letterGrade}");
        }

        /// <summary>
        /// Calculates the letter grade based on a numerical score.
        /// This function isolates the core business logic from the user interface code.
        /// </summary>
        /// <param name="grade">The numerical grade (0-100).</param>
        /// <returns>The corresponding letter grade (A, B, C, D, or F).</returns>
        public static string GetLetterGrade(double grade)
        {
            // Use a C# switch expression with relational patterns for a clean and readable implementation.
            string result = grade switch
            {
                >= 90 => "A",   // 90 and above
                >= 80 => "B",   // 80-89
                >= 70 => "C",   // 70-79
                >= 60 => "D",   // 60-69
                _     => "F"    // Below 60
            };
            return result;
        }
    }
}
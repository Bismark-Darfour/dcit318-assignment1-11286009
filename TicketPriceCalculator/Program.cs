// Ticket Price Calculator Application
// This program calculates a ticket price based on the user's age.

using System;

namespace TicketPriceCalculator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int age;

            // Loop until the user provides a valid age.
            while (true)
            {
                // Prompt the user to enter their age.
                Console.WriteLine("Please enter your age:");
                string input = Console.ReadLine();

                // Check for valid, non-negative integer input.
                if (int.TryParse(input, out age) && age >= 0)
                {
                    break; // Exit loop if input is valid.
                }
                else
                {
                    // Provide feedback for invalid input.
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid input. Please enter a valid age as a whole number.");
                    Console.ResetColor();
                }
            }
            
            // 1. Call the function to calculate the ticket price.
            int price = CalculateTicketPrice(age);

            // 2. Display the final ticket price to the user.
            Console.WriteLine($"Your ticket price is: GHC{price}");
        }

        /// <summary>
        /// Calculates the ticket price based on age.
        /// </summary>
        /// <param name="age">The customer's age.</param>
        /// <returns>The ticket price in GHC.</returns>
        public static int CalculateTicketPrice(int age)
        {
            // Check if the customer is a senior (65+) or a child (12-).
            if (age >= 65 || age <= 12)
            {
                return 7; // Discounted price for seniors and children is GHC7.
            }
            else
            {
                return 10; // Standard ticket price is GHC10.
            }
        }
    }
}
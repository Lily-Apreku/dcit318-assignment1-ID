using System;

namespace TicketPriceCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Welcome to the Cinema!");

            Console.Write("Please enter your age to get your ticket: ");
            int age = Convert.ToInt32(Console.ReadLine());

            // Calculate ticket price using the function from the TicketPriceGenerator class
            double ticketPrice = TicketPriceGenerator.CalculateTicketPrice(age);

            // Display the ticket price
            if (ticketPrice == 7.0)
            {
                Console.WriteLine($"You have some discount. Your ticket costs: GHC{ticketPrice}");
            }
            else
            {
                Console.WriteLine($"Your ticket costs: GHC{ticketPrice}");
            }

            Console.WriteLine("Please proceed to pay for your ticket.");
            Console.WriteLine("Thank you for using the Ticket Price Calculator!");
        }
    }
}

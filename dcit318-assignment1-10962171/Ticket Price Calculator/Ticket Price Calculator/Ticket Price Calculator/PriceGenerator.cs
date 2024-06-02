// TicketPricing.cs
using System;

namespace TicketPriceCalculator
{
    public class TicketPriceGenerator
    {
        public static double CalculateTicketPrice(int age)
        {
            double regularPrice = 10.0;
            double discountedPrice = 7.0;

            // Logic for ticket price
            if (age >= 65 || age <= 12)
            {
                return discountedPrice;
            }
            else
            {
                return regularPrice;
            }
        }
    }
}

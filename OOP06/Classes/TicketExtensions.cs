using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP06.Classes
{
    internal static class TicketExtensions
    {
        public static string GenerateReceipt(this Ticket ticket)
        {
            return $"Receipt:\nMovie: {ticket.MovieName}\nPrice: {ticket.CalculateFinalPrice()}";
        }

        public static decimal TotalRevenue(this Ticket[] tickets)
        {
            decimal total = 0;

            foreach (var ticket in tickets)
            {
                total += ticket.CalculateFinalPrice();
            }

            return total;
        }
    }
}

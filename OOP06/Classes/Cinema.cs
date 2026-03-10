using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP06.Classes
{
    internal partial class Cinema
    {
        private List<Ticket> tickets = new List<Ticket>();

        public void AddTicket(Ticket ticket)
        {
            tickets.Add(ticket);
        }

        public List<Ticket> GetTickets()
        {
            return tickets;
        }

        public void OpenCinema()
        {
            Console.WriteLine("Cinema is now opened.");
        }

        public void CloseCinema()
        {
            Console.WriteLine("Cinema is now closed.");
        }

        public void PrintAllTickets()
        {
            foreach (var ticket in tickets)
            {
                Console.WriteLine(
                    $"{ticket.MovieName} - Final Price: {ticket.CalculateFinalPrice()}"
                );
            }
        }

        public void ShowStatistics()
        {
            Console.WriteLine($"Total tickets: {tickets.Count}");
        }

    }
}

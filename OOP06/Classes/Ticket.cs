using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP06.Classes
{
    public abstract class Ticket
    {
        public Ticket(string movieName, decimal price, bool isBooked)
        {
            MovieName = movieName;
            Price = price;
            IsBooked = isBooked;
        }

        public string MovieName { get; set; }
        public decimal Price { get; set; }
        public bool IsBooked { get; set; }

        public abstract decimal CalculateFinalPrice();
    }
}

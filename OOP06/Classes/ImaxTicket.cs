using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP06.Classes
{
    internal class ImaxTicket : Ticket
    {
        public ImaxTicket(string movieName, decimal price, bool isBooked) : base(movieName, price, isBooked)
        {
        }

        public override decimal CalculateFinalPrice()
        {
            return Price + 5;
        }
    }
}

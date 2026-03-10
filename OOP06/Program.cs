using OOP06.Classes;

namespace OOP06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 01 : Theoretical Questions
            /* Q1
             * Abstraction means hiding complex implementation details and showing only the essential features of an object.
             * Abstraction : Hides complex implementation
             * Encapsulation : Hides internal data
             */

            /* Q1
             * Abstract class: A class can inherit only one abstract class , Can contain implemented methods , Can have fields, constructors, and properties , Members can have access modifiers
             * Interface : A class can implement multiple interfaces , Usually contains method signatures only , Cannot have fields or constructors , Members are usually public by default
             */
            #endregion


            #region Extending the Movie Ticket Booking System
            Ticket t1 = new Standard("inception" , 200 , true);
            Ticket t2 = new VipTicket("interstaller", 250, true);
            Ticket t3 = new ImaxTicket("Avengers", 300, true);

            Cinema c = new Cinema();

            c.AddTicket(t1);
            c.AddTicket(t2);    
            c.AddTicket(t3);
            c.PrintAllTickets();

            #endregion
        }
    }
}

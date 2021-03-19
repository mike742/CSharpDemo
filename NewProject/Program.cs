using System;

namespace NewProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // bool b = null; // true / false / null
            // int a = null; 

            int availableTickets;
            int? ticketsOnSale = null;
            /*
            if (ticketsOnSale == null)
            {
                availableTickets = 0;
            }
            else
            {
                availableTickets = (int)ticketsOnSale;
            }
            */
            // ? :

            //availableTickets = (ticketsOnSale == null) ? 0 : (int)ticketsOnSale;

            // null coalesce operator
            availableTickets = ticketsOnSale ?? 0;


            // Console.WriteLine("availableTickets = " + availableTickets);
            // Console.WriteLine("availableTickets = {0}", availableTickets);
            Console.WriteLine($"availableTickets = {availableTickets}");

            Console.WriteLine("Have a great day");
        }
    }
}

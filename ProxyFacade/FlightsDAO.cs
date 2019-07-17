using System;

namespace ProxyFacade
{
    public class FlightsDAO
    {

        public void InsertTicket()
        {
            Console.WriteLine("Inserting the ticket to the DB");
        }

        public void GetTickets()
        {
            Console.WriteLine("Getting the tickets from the DB");
        }

        public void InsertFlight()
        {
            Console.WriteLine("Inserting the flight to the DB");
        }

        public void RemoveFlight()
        {
            Console.WriteLine("Removing the flight to the DB");
        }

        public void InsertCustomer()
        {
            Console.WriteLine("Inserting the customer to the DB");
        }

        public void InsertCompany()
        {
            Console.WriteLine("Inserting the company to the DB");
        }
    }
}